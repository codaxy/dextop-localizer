using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Codaxy.Dextop.Localizer.Windows.Forms
{
    public partial class MainWindow : Form
    {
        public LocalizationProfile LocalizationProfile { get; private set; }

        public String ProjectFolder { get; private set; }
        String lpp;
        public String LocalizationProfileFilePath
        {
            get { return lpp; }
            private set
            {
                lpp = value;
                if (File.Exists(lpp))
                    ProjectFolder = new FileInfo(lpp).DirectoryName;
            }
        }
        public WindowLogger WindowLogger { get; private set; }
        public EnvironmentVariables EnvironmentVariables { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            LocalizationProfile = new LocalizationProfile();
            LocalizationProfileFilePath = null;

            EnvironmentVariables = new Windows.EnvironmentVariables();

            dgvNew.AutoGenerateColumns = false;
            dgvCurrent.AutoGenerateColumns = false;
            dgvDeleted.AutoGenerateColumns = false;

            WindowLogger = new WindowLogger(lbStatus);
        }

        public MainWindow(String fileName)
            : this()
        {
            if (!String.IsNullOrEmpty(fileName))
            {
                LocalizationProfileFilePath = fileName;
                DoLoadLocalizationProfile();
            }
        }

        void Diff(Dictionary<String, LocalizableEntity> newValues, Dictionary<String, LocalizableEntity> currentValues, Dictionary<String, LocalizableEntity> deletedValues)
        {
            foreach (var o in currentValues.Keys)
            {
                if (newValues.ContainsKey(o))
                {
                    currentValues[o].EnclosingEntity.FilePath = newValues[o].EnclosingEntity.FilePath;
                    newValues.Remove(o);
                }
                else
                    deletedValues.Add(o, currentValues[o]);
            }

            foreach (var d in deletedValues.Keys)
                if (currentValues.ContainsKey(d))
                    currentValues.Remove(d);
        }

        EntityLocalizationEntry[] GetLocalizationGridDataSource(Dictionary<String, LocalizableEntity> map, bool defaultCheck)
        {
            return (from q in map.Values
                    select new EntityLocalizationEntry
                    {
                        IsChecked = defaultCheck,
                        Property = q.ShallowEntityPath,
                        Value = q.Value,
                        OriginalValue = q.Value,
                        LocalizableProperty = q
                    }).ToArray();
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void Run()
        {
            List<String> fileNames = tbInputFiles.Text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<String> includes = new List<string>();
            List<String> excludes = new List<string>();
            foreach (var fileName in fileNames)
            {
                if (fileName.StartsWith("-"))
                    excludes.Add(fileName.Substring(1));
                else if (!fileName.StartsWith("#"))
                    includes.Add(fileName);
            }

            try
            {
                EntityExtractor ext = LocalizationModule.Create(LocalizerType).Extractor;
                ext.Logger = WindowLogger;

                Dictionary<String, LocalizableEntity> map1 = new Dictionary<string, LocalizableEntity>();
                ext.ProcessFileList(includes.ToArray(), excludes.ToArray(), RootPathResolved, FileExtension, map1);

                Dictionary<String, LocalizableEntity> map2 = new Dictionary<string, LocalizableEntity>();
                try
                {
                    ext.ProcessFile(ReferenceResolved, map2);
                }
                catch (Exception ex)
                {
                    WindowLogger.LogFormat("Warning: error parsing reference input ({0})", ex.Message);
                }

                Dictionary<String, LocalizableEntity> map3 = new Dictionary<string, LocalizableEntity>();
                Diff(map1, map2, map3);

                dgvNew.DataSource = GetLocalizationGridDataSource(map1, false);
                dgvCurrent.DataSource = GetLocalizationGridDataSource(map2, true);
                dgvDeleted.DataSource = GetLocalizationGridDataSource(map3, false);
            }
            catch (Exception ex)
            {
                WindowLogger.Log(ex.Message);
            }
        }

        String GenerateOutput(EntityLocalizationEntry[] dsCurrent, EntityLocalizationEntry[] dsNew, EntityLocalizationEntry[] dsDeleted)
        {
            var list = new List<EntityLocalizationEntry>();
            if (dsCurrent != null) list.AddRange(dsCurrent);
            if (dsNew != null) list.AddRange(dsNew);
            if (dsDeleted != null) list.AddRange(dsDeleted);

            var blocks = (from c in list
                          where c.IsChecked
                          group c by new { 
                              EntityNameForOverride = c.LocalizableProperty.EnclosingEntity.EntityNameForOverride,
                              IsDextopLocalize = c.LocalizableProperty.EnclosingEntity.IsDextopLocalize
                          } into grp
                          select new LocalizedEntityBlock { 
                              EntityNameForOverride = grp.Key.EntityNameForOverride, 
                              IsDextopLocalize = grp.Key.IsDextopLocalize,
                              LocalizationGridRows = grp.ToArray() 
                          }
                    ).ToArray();


            var com = LocalizationModule.Create(LocalizerType).Composer;
            return com.GenerateOutputFile(blocks);
        }

        private void btShowOutput_Click(object sender, EventArgs e)
        {
            var dsCurrent = dgvCurrent.DataSource as EntityLocalizationEntry[];
            var dsNew = dgvNew.DataSource as EntityLocalizationEntry[];
            var dsDeleted = dgvDeleted.DataSource as EntityLocalizationEntry[];

            String output = GenerateOutput(dsCurrent, dsNew, dsDeleted);
            FrmOutput frm = new FrmOutput
            {
                OutputText = output,
                OutputFile = ReferenceResolved
            };
            if (frm.ShowDialog() == DialogResult.OK)
                Run();
        }

        private void btChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog w = new FolderBrowserDialog();
            if (w.ShowDialog() == DialogResult.OK)
                tbRootFolder.Text = w.SelectedPath;
        }

        private void btChooseReferenceFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog w = new OpenFileDialog();
            if (w.ShowDialog() == DialogResult.OK)
                tbReferenceFile.Text = w.FileName;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to close the application? This will destroy all the unsaved changes!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                == DialogResult.Yes)
            {
                //if (MessageBox.Show("Do you want to save your localization profile?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                //    == DialogResult.Yes)

                //    SaveLocalizationProfile(false);
            }
            else
                e.Cancel = true;
        }

        private void SaveLocalizationProfile(bool saveAs)
        {
            if (saveAs || String.IsNullOrEmpty(LocalizationProfileFilePath))
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Title = "Save localization profile",
                    Filter = "Localization profile files (*.lcp) | *.lcp",
                    DefaultExt = "*.lcp"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                    LocalizationProfileFilePath = sfd.FileName;
                else
                    return;
            }

            DoSaveLocalizationProfile();
        }

        private void DoSaveLocalizationProfile()
        {
            LocalizationProfile.InputFiles = tbInputFiles.Text;
            LocalizationProfile.LocalizerType = LocalizerType;
            LocalizationProfile.RootFolderPath = tbRootFolder.Text;
            LocalizationProfile.ReferenceFilePath = tbReferenceFile.Text;

            try
            {
                using (XmlTextWriter xml = new XmlTextWriter(LocalizationProfileFilePath, Encoding.UTF8))
                {
                    xml.Formatting = Formatting.Indented;
                    xml.Indentation = 4;

                    System.Xml.Serialization.XmlSerializer s = new XmlSerializer(typeof(LocalizationProfile));
                    s.Serialize(xml, LocalizationProfile);
                }

                UpdateWindowTitle();
                WindowLogger.Log("Profile saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Localizer could not save the file. Check status for more details!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                WindowLogger.Log(ex.Message);
            }
        }

        private void LoadLocalizationProfile()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Load localization profile",
                Filter = "Localization profile files (*.lcp) | *.lcp",
                DefaultExt = "*.lcp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                LocalizationProfileFilePath = ofd.FileName;
            else
                return;

            DoLoadLocalizationProfile();
        }

        private void DoLoadLocalizationProfile()
        {
            try
            {
                using (XmlTextReader xml = new XmlTextReader(LocalizationProfileFilePath))
                {
                    System.Xml.Serialization.XmlSerializer s = new XmlSerializer(typeof(LocalizationProfile));
                    LocalizationProfile = (LocalizationProfile)s.Deserialize(xml);
                }

                tbInputFiles.Text = LocalizationProfile.InputFiles;
                cbLocalizerType.SelectedItem = LocalizationProfile.LocalizerType;
                tbRootFolder.Text = LocalizationProfile.RootFolderPath;
                tbReferenceFile.Text = LocalizationProfile.ReferenceFilePath;

                UpdateWindowTitle();
                WindowLogger.Log("Profile loaded successfully.");

                DoLoadEnvironment();
            }
            catch (Exception ex)
            {
                WindowLogger.Log(ex.Message);
                MessageBox.Show("Localizer could not open this file. File format is not supported", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DoLoadEnvironment()
        {
            try
            {
                var defaults = Path.Combine(ProjectFolder ?? "", "defaults.xml");
                if (!File.Exists(defaults))
                    throw new Exception("No defaults.xml file provided in project folder!");

                using (XmlTextReader xml = new XmlTextReader(defaults))
                {
                    System.Xml.Serialization.XmlSerializer s = new XmlSerializer(typeof(EnvironmentVariables));
                    EnvironmentVariables = (EnvironmentVariables)s.Deserialize(xml);
                }
                WindowLogger.Log("Environment variables loaded successfully.");
            }
            catch (Exception ex)
            {
                WindowLogger.Log("Could not load environment: " + ex.Message);
                EnvironmentVariables = new Dextop.Localizer.Windows.EnvironmentVariables();
            }
        }

        private void DoSaveEnvironment()
        {
            try
            {
                var defaults = Path.Combine(ProjectFolder ?? "", "defaults.xml");
                using (XmlTextWriter xml = new XmlTextWriter(defaults, Encoding.UTF8))
                {
                    System.Xml.Serialization.XmlSerializer s = new XmlSerializer(typeof(EnvironmentVariables));
                    s.Serialize(xml, EnvironmentVariables);
                }
                WindowLogger.Log("Environment variables saved successfully.");
            }
            catch (Exception ex)
            {
                WindowLogger.Log("Could not save environment: " + ex.Message);
            }
        }

        private void UpdateWindowTitle()
        {
            Text = "Localizer - " + LocalizationProfileFilePath;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).Rows[e.RowIndex].DataBoundItem as EntityLocalizationEntry;
            if (row != null)
            {
                tbOriginalText.Text = row.OriginalValue;
                tbOriginalText.BackColor = (sender as DataGridView).BackgroundColor;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            cbLocalizerType.Items.Clear();
            foreach (var v in Enum.GetValues(typeof(LocalizerType)))
                cbLocalizerType.Items.Add(v);

            cbLocalizerType.SelectedItem = LocalizationProfile.LocalizerType;
        }

        private LocalizerType LocalizerType
        {
            get { return (LocalizerType)(cbLocalizerType.SelectedItem ?? LocalizerType.JavaScript); }
        }

        private String FileExtension
        {
            get
            {
                switch (LocalizerType)
                {
                    case LocalizerType.JavaScript:
                    case LocalizerType.JavaScript2:
                        return "*.js";
                    case LocalizerType.Xml:
                        return "*.xml";
                    case LocalizerType.Resx:
                        return "*.resx";

                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private void btChooseConfigFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog w = new OpenFileDialog();
            if (w.ShowDialog() != DialogResult.OK)
                return;
        }


        void GetFileNameParts(String fullPath, out String dirName, out String fileName, out String rawFileName, out String extension)
        {
            var indexOfBSlash = fullPath.LastIndexOf(@"\");

            dirName = fullPath.Substring(0, indexOfBSlash);
            fileName = fullPath.Substring(indexOfBSlash + 1);

            var indexOfDot = fileName.LastIndexOf(@".");

            rawFileName = indexOfDot != -1 ? fileName.Substring(0, indexOfDot) : fileName;
            extension = indexOfDot != -1 ? fileName.Substring(indexOfDot + 1) : "";
        }

        private void btSimpleSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = String.Format("{0}|{0}|All files|*.*", FileExtension)
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String fileName, rawFileName, dirName, extension;
                GetFileNameParts(ofd.FileName, out dirName, out fileName, out rawFileName, out extension);

                tbInputFiles.Text = fileName;
                tbRootFolder.Text = dirName;

                FrmDefineReference fdr = new FrmDefineReference();
                if (fdr.ShowDialog() == DialogResult.OK)
                {
                    var refDef = fdr.ReferenceDefinition;
                    tbReferenceFile.Text = refDef.Replace("{path}", dirName).Replace("{name}", rawFileName).Replace("{ext}", extension);

                    Run();
                }
            }
        }

        private void btClearStatus_Click(object sender, EventArgs e)
        {
            lbStatus.Items.Clear();
        }

        private void btSaveProfile_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(LocalizationProfileFilePath))
                if (MessageBox.Show("Do you really want to save your profile? Note: this will overwrite the previous one!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

            SaveLocalizationProfile(false);
        }

        private void btSaveAs_Click(object sender, EventArgs e)
        {
            SaveLocalizationProfile(true);
        }

        private void btLoadProfile_Click(object sender, EventArgs e)
        {
            LoadLocalizationProfile();
        }

        private String ApplyEnvironmentTo(String s)
        {
            foreach (var e in EnvironmentVariables.Entries)
                s = s.Replace("{" + e.Name + "}", e.Value);
            s = s.Replace("{projectPath}", ProjectFolder).Replace("\\\\", "\\");
            return Path.GetFullPath(s);            
        }

        private String ReferenceResolved
        {
            get
            {
                return ApplyEnvironmentTo(tbReferenceFile.Text);
            }
        }

        private String RootPathResolved
        {
            get
            {
                return ApplyEnvironmentTo(tbRootFolder.Text);
            }
        }

        private void btEnvironment_Click(object sender, EventArgs e)
        {
            FrmEnvironment frm = new FrmEnvironment { Environment = EnvironmentVariables };
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK);
                DoSaveEnvironment();
        }

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dgv = contextMenu.SourceControl as DataGridView ?? dgvCurrent;
            dgv.EndEdit();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var item = row.DataBoundItem as EntityLocalizationEntry;
                if (item != null) item.IsChecked = true;
            }

            dgv.Refresh();
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dgv = contextMenu.SourceControl as DataGridView ?? dgvCurrent;
            dgv.EndEdit();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var item = row.DataBoundItem as EntityLocalizationEntry;
                if (item != null) item.IsChecked = false;
            }

            dgv.Refresh();
        }

        private void checkSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dgv = contextMenu.SourceControl as DataGridView ?? dgvCurrent;
            dgv.EndEdit();

            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            foreach (DataGridViewCell cell in dgv.SelectedCells)
            {
                var item = cell.OwningRow.DataBoundItem as EntityLocalizationEntry;
                if (item != null) item.IsChecked = true;
            }

            dgv.Refresh();
        }

        private void uncheckSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dgv = contextMenu.SourceControl as DataGridView ?? dgvCurrent;
            dgv.EndEdit();

            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            foreach (DataGridViewCell cell in dgv.SelectedCells)
            {
                var item = cell.OwningRow.DataBoundItem as EntityLocalizationEntry;
                if (item != null) item.IsChecked = false;
            }

            dgv.Refresh();
        }

        FrmSearch frmSearch;
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dgv = contextMenu.SourceControl as DataGridView ?? dgvCurrent;

            if (frmSearch == null || frmSearch.IsDisposed)
            {
                frmSearch = new FrmSearch
                {
                    SearchSource = dgv
                };
                frmSearch.SearchRequested += new EventHandler<SearchEventArgs>(frmFind_SearchRequested);
            }

            frmSearch.Show();
            frmSearch.Focus();
        }

        void frmFind_SearchRequested(object sender, SearchEventArgs e)
        {
            var dgv = (sender as FrmSearch).SearchSource ?? dgvCurrent;

            Func<String, String, bool> comparer;
            Func<String, String> modifier;

            if (!e.MatchCase)
                modifier = a => a.ToLower();
            else
                modifier = a => a;

            switch (e.SearchCriteria)
            {
                case SearchCriteria.Contains:
                    comparer = (a, b) => modifier(a).Contains(modifier(b));
                    break;
                case SearchCriteria.StartsWith:
                default:
                    comparer = (a, b) => modifier(a).StartsWith(modifier(b));
                    break;
            }

            bool fromBeginning = false;
            do
            {
                int index = dgv.SelectedCells.Count > 0 ? dgv.SelectedCells[0].RowIndex : -1;
                while (++index < dgv.Rows.Count)
                {
                    var entry = dgv.Rows[index].DataBoundItem as EntityLocalizationEntry;
                    if (e.CheckFields)
                        if (comparer(entry.Property, e.Pattern))
                            break;

                    if (e.CheckValues)
                        if (comparer(entry.Value, e.Pattern))
                            break;
                }

                if (index < dgv.Rows.Count)
                {
                    dgv.ClearSelection();
                    dgv.Rows[index].Selected = true;
                    dgv.FirstDisplayedScrollingRowIndex = index;
                    break;
                }

                if (!fromBeginning)
                {
                    if (MessageBox.Show("Pattern not found. Do you want to start the search from the beginning?", "Search", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                    {
                        dgv.ClearSelection();
                        fromBeginning = true;
                    }
                    else
                        break;
                }
                else
                {
                    MessageBox.Show("Pattern not found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
            } while (true);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGoogle_Click(object sender, EventArgs e)
        {
            this.UseGoogle();
        }

        private void UseGoogle()
        {
            FrmGoogleTranslate googleTranslate = new FrmGoogleTranslate(dgvNew.DataSource as EntityLocalizationEntry[]);
            googleTranslate.ShowDialog();
            dgvNew.Refresh();
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;

            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
                dgv.Rows[e.RowIndex].Cells[0].Value = true;
        }
    }
}

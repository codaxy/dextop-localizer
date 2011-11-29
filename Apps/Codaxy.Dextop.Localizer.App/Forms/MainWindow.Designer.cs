namespace Codaxy.Dextop.Localizer.Windows.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btRun = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btChooseFolder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btChooseReferenceFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvCurrent = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.selCheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvNew = new System.Windows.Forms.DataGridView();
            this.cmAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeleted = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbLocalizerType = new System.Windows.Forms.ComboBox();
            this.tbOriginalText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReferenceFile = new System.Windows.Forms.TextBox();
            this.tbRootFolder = new System.Windows.Forms.TextBox();
            this.tbInputFiles = new System.Windows.Forms.TextBox();
            this.btSimpleSelect = new System.Windows.Forms.Button();
            this.btClearStatus = new System.Windows.Forms.Button();
            this.btLoadProfile = new System.Windows.Forms.Button();
            this.btSaveProfile = new System.Windows.Forms.Button();
            this.btSaveAs = new System.Windows.Forms.Button();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.btEnvironment = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrent)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleted)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input files";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            // 
            // btRun
            // 
            this.btRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRun.Location = new System.Drawing.Point(920, 439);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 52);
            this.btRun.TabIndex = 6;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 513);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.ScrollAlwaysVisible = true;
            this.lbStatus.Size = new System.Drawing.Size(1067, 82);
            this.lbStatus.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Root folder";
            // 
            // btChooseFolder
            // 
            this.btChooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btChooseFolder.Location = new System.Drawing.Point(736, 440);
            this.btChooseFolder.Name = "btChooseFolder";
            this.btChooseFolder.Size = new System.Drawing.Size(75, 23);
            this.btChooseFolder.TabIndex = 11;
            this.btChooseFolder.Text = "Choose...";
            this.btChooseFolder.UseVisualStyleBackColor = true;
            this.btChooseFolder.Click += new System.EventHandler(this.btChooseFolder_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reference";
            // 
            // btChooseReferenceFile
            // 
            this.btChooseReferenceFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btChooseReferenceFile.Location = new System.Drawing.Point(736, 469);
            this.btChooseReferenceFile.Name = "btChooseReferenceFile";
            this.btChooseReferenceFile.Size = new System.Drawing.Size(75, 23);
            this.btChooseReferenceFile.TabIndex = 14;
            this.btChooseReferenceFile.Text = "Choose...";
            this.btChooseReferenceFile.UseVisualStyleBackColor = true;
            this.btChooseReferenceFile.Click += new System.EventHandler(this.btChooseReferenceFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Current values";
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Location = new System.Drawing.Point(1001, 439);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 20;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btShowOutput_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(912, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "New values / non-existing values";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(265, 83);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvCurrent);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(811, 345);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.TabIndex = 24;
            // 
            // dgvCurrent
            // 
            this.dgvCurrent.AllowUserToAddRows = false;
            this.dgvCurrent.AllowUserToDeleteRows = false;
            this.dgvCurrent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvCurrent.ContextMenuStrip = this.contextMenu;
            this.dgvCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCurrent.GridColor = System.Drawing.SystemColors.Window;
            this.dgvCurrent.Location = new System.Drawing.Point(0, 0);
            this.dgvCurrent.Name = "dgvCurrent";
            this.dgvCurrent.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCurrent.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrent.Size = new System.Drawing.Size(351, 345);
            this.dgvCurrent.TabIndex = 23;
            this.dgvCurrent.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsChecked";
            this.dataGridViewCheckBoxColumn2.Frozen = true;
            this.dataGridViewCheckBoxColumn2.HeaderText = "+";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn2.Width = 20;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Property";
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Property";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Value";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem,
            this.toolStripMenuItem2,
            this.selCheckedToolStripMenuItem,
            this.uncheckSelectionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.searchToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(172, 126);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.selectAllToolStripMenuItem.Text = "Check All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.deselectAllToolStripMenuItem.Text = "Uncheck All";
            this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 6);
            // 
            // selCheckedToolStripMenuItem
            // 
            this.selCheckedToolStripMenuItem.Name = "selCheckedToolStripMenuItem";
            this.selCheckedToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.selCheckedToolStripMenuItem.Text = "Check Selection";
            this.selCheckedToolStripMenuItem.Click += new System.EventHandler(this.checkSelectionToolStripMenuItem_Click);
            // 
            // uncheckSelectionToolStripMenuItem
            // 
            this.uncheckSelectionToolStripMenuItem.Name = "uncheckSelectionToolStripMenuItem";
            this.uncheckSelectionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.uncheckSelectionToolStripMenuItem.Text = "Uncheck Selection";
            this.uncheckSelectionToolStripMenuItem.Click += new System.EventHandler(this.uncheckSelectionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.searchToolStripMenuItem.Text = "Find...";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvNew);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvDeleted);
            this.splitContainer2.Size = new System.Drawing.Size(456, 345);
            this.splitContainer2.SplitterDistance = 162;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvNew
            // 
            this.dgvNew.AllowUserToAddRows = false;
            this.dgvNew.AllowUserToDeleteRows = false;
            this.dgvNew.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmAdd,
            this.cmProperty,
            this.cmValue});
            this.dgvNew.ContextMenuStrip = this.contextMenu;
            this.dgvNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNew.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNew.GridColor = System.Drawing.SystemColors.Window;
            this.dgvNew.Location = new System.Drawing.Point(0, 0);
            this.dgvNew.Name = "dgvNew";
            this.dgvNew.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvNew.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNew.Size = new System.Drawing.Size(456, 162);
            this.dgvNew.TabIndex = 21;
            this.dgvNew.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // cmAdd
            // 
            this.cmAdd.DataPropertyName = "IsChecked";
            this.cmAdd.Frozen = true;
            this.cmAdd.HeaderText = "+";
            this.cmAdd.Name = "cmAdd";
            this.cmAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmAdd.Width = 20;
            // 
            // cmProperty
            // 
            this.cmProperty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmProperty.DataPropertyName = "Property";
            this.cmProperty.FillWeight = 50F;
            this.cmProperty.HeaderText = "Property";
            this.cmProperty.Name = "cmProperty";
            this.cmProperty.ReadOnly = true;
            // 
            // cmValue
            // 
            this.cmValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmValue.DataPropertyName = "Value";
            this.cmValue.FillWeight = 50F;
            this.cmValue.HeaderText = "Value";
            this.cmValue.Name = "cmValue";
            // 
            // dgvDeleted
            // 
            this.dgvDeleted.AllowUserToAddRows = false;
            this.dgvDeleted.AllowUserToDeleteRows = false;
            this.dgvDeleted.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleted.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvDeleted.ContextMenuStrip = this.contextMenu;
            this.dgvDeleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeleted.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDeleted.GridColor = System.Drawing.SystemColors.Window;
            this.dgvDeleted.Location = new System.Drawing.Point(0, 0);
            this.dgvDeleted.Name = "dgvDeleted";
            this.dgvDeleted.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvDeleted.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeleted.Size = new System.Drawing.Size(456, 179);
            this.dgvDeleted.TabIndex = 24;
            this.dgvDeleted.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsChecked";
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "+";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Property";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Property";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cbLocalizerType
            // 
            this.cbLocalizerType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbLocalizerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalizerType.FormattingEnabled = true;
            this.cbLocalizerType.Items.AddRange(new object[] {
            "JavaScript",
            "XML"});
            this.cbLocalizerType.Location = new System.Drawing.Point(128, 440);
            this.cbLocalizerType.Name = "cbLocalizerType";
            this.cbLocalizerType.Size = new System.Drawing.Size(126, 21);
            this.cbLocalizerType.TabIndex = 25;
            // 
            // tbOriginalText
            // 
            this.tbOriginalText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOriginalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOriginalText.Location = new System.Drawing.Point(266, 25);
            this.tbOriginalText.Name = "tbOriginalText";
            this.tbOriginalText.ReadOnly = true;
            this.tbOriginalText.Size = new System.Drawing.Size(811, 22);
            this.tbOriginalText.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Original field value";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbReferenceFile
            // 
            this.tbReferenceFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbReferenceFile.Location = new System.Drawing.Point(340, 469);
            this.tbReferenceFile.Name = "tbReferenceFile";
            this.tbReferenceFile.Size = new System.Drawing.Size(390, 20);
            this.tbReferenceFile.TabIndex = 13;
            this.tTip.SetToolTip(this.tbReferenceFile, "Use {projectPath} for paths relative to the profile file location");
            // 
            // tbRootFolder
            // 
            this.tbRootFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbRootFolder.Location = new System.Drawing.Point(340, 441);
            this.tbRootFolder.Name = "tbRootFolder";
            this.tbRootFolder.Size = new System.Drawing.Size(390, 20);
            this.tbRootFolder.TabIndex = 9;
            this.tTip.SetToolTip(this.tbRootFolder, "Use {projectPath} for paths relative to the profile file location");
            // 
            // tbInputFiles
            // 
            this.tbInputFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tbInputFiles.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputFiles.Location = new System.Drawing.Point(12, 25);
            this.tbInputFiles.Multiline = true;
            this.tbInputFiles.Name = "tbInputFiles";
            this.tbInputFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInputFiles.Size = new System.Drawing.Size(245, 403);
            this.tbInputFiles.TabIndex = 0;
            this.tbInputFiles.Text = "# Use # to place comments\r\n# Use / suffix to denote folders\r\n# Use - prefix to de" +
                "note files and folders to ignore\r\n\r\n# Example:\r\n\r\n# client/js/\r\n# client/cache/c" +
                "m.js\r\n# -client/js/locale/";
            this.tTip.SetToolTip(this.tbInputFiles, "Use # to place comments\r\nUse / suffix to denote folders\r\nUse - prefix to denote f" +
                    "iles and folders to ignore\r\n\r\nExample:\r\n\r\nclient/js/\r\nclient/cache/cm.js\r\n-clien" +
                    "t/js/locale/");
            // 
            // btSimpleSelect
            // 
            this.btSimpleSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSimpleSelect.Location = new System.Drawing.Point(12, 439);
            this.btSimpleSelect.Name = "btSimpleSelect";
            this.btSimpleSelect.Size = new System.Drawing.Size(110, 23);
            this.btSimpleSelect.TabIndex = 31;
            this.btSimpleSelect.Text = "1-File Localization";
            this.btSimpleSelect.UseVisualStyleBackColor = true;
            this.btSimpleSelect.Click += new System.EventHandler(this.btSimpleSelect_Click);
            // 
            // btClearStatus
            // 
            this.btClearStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClearStatus.Location = new System.Drawing.Point(1069, 500);
            this.btClearStatus.Name = "btClearStatus";
            this.btClearStatus.Size = new System.Drawing.Size(10, 10);
            this.btClearStatus.TabIndex = 32;
            this.btClearStatus.Text = "button1";
            this.tTip.SetToolTip(this.btClearStatus, "Clear status messages");
            this.btClearStatus.UseVisualStyleBackColor = true;
            this.btClearStatus.Click += new System.EventHandler(this.btClearStatus_Click);
            // 
            // btLoadProfile
            // 
            this.btLoadProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLoadProfile.Location = new System.Drawing.Point(12, 469);
            this.btLoadProfile.Name = "btLoadProfile";
            this.btLoadProfile.Size = new System.Drawing.Size(75, 23);
            this.btLoadProfile.TabIndex = 33;
            this.btLoadProfile.Text = "Load profile";
            this.btLoadProfile.UseVisualStyleBackColor = true;
            this.btLoadProfile.Click += new System.EventHandler(this.btLoadProfile_Click);
            // 
            // btSaveProfile
            // 
            this.btSaveProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSaveProfile.Location = new System.Drawing.Point(93, 469);
            this.btSaveProfile.Name = "btSaveProfile";
            this.btSaveProfile.Size = new System.Drawing.Size(75, 23);
            this.btSaveProfile.TabIndex = 34;
            this.btSaveProfile.Text = "Save Profile";
            this.btSaveProfile.UseVisualStyleBackColor = true;
            this.btSaveProfile.Click += new System.EventHandler(this.btSaveProfile_Click);
            // 
            // btSaveAs
            // 
            this.btSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSaveAs.Location = new System.Drawing.Point(174, 469);
            this.btSaveAs.Name = "btSaveAs";
            this.btSaveAs.Size = new System.Drawing.Size(80, 23);
            this.btSaveAs.TabIndex = 35;
            this.btSaveAs.Text = "Save As...";
            this.btSaveAs.UseVisualStyleBackColor = true;
            this.btSaveAs.Click += new System.EventHandler(this.btSaveAs_Click);
            // 
            // tTip
            // 
            this.tTip.AutomaticDelay = 0;
            this.tTip.AutoPopDelay = 5000;
            this.tTip.InitialDelay = 0;
            this.tTip.ReshowDelay = 100;
            // 
            // btEnvironment
            // 
            this.btEnvironment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEnvironment.Location = new System.Drawing.Point(817, 469);
            this.btEnvironment.Name = "btEnvironment";
            this.btEnvironment.Size = new System.Drawing.Size(75, 23);
            this.btEnvironment.TabIndex = 36;
            this.btEnvironment.Text = "Environment";
            this.btEnvironment.UseVisualStyleBackColor = true;
            this.btEnvironment.Click += new System.EventHandler(this.btEnvironment_Click);
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(1001, 468);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 37;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 604);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btEnvironment);
            this.Controls.Add(this.btSaveAs);
            this.Controls.Add(this.btSaveProfile);
            this.Controls.Add(this.btLoadProfile);
            this.Controls.Add(this.btClearStatus);
            this.Controls.Add(this.btSimpleSelect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbOriginalText);
            this.Controls.Add(this.cbLocalizerType);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btChooseReferenceFile);
            this.Controls.Add(this.tbReferenceFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btChooseFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRootFolder);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInputFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Dextop Localizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrent)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.TextBox tbRootFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btChooseFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReferenceFile;
        private System.Windows.Forms.Button btChooseReferenceFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvCurrent;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvNew;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cmAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmValue;
        private System.Windows.Forms.DataGridView dgvDeleted;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox cbLocalizerType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox tbOriginalText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSimpleSelect;
        private System.Windows.Forms.Button btClearStatus;
        private System.Windows.Forms.Button btLoadProfile;
        private System.Windows.Forms.Button btSaveProfile;
        private System.Windows.Forms.Button btSaveAs;
        private System.Windows.Forms.ToolTip tTip;
        private System.Windows.Forms.Button btEnvironment;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selCheckedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Button btExport;
    }
}


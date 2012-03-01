using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Codaxy.Dextop.Localizer.Windows.Forms
{
    public partial class FrmGoogleTranslate : Form
    {
        EntityLocalizationEntry[] dgvNewDataSource = null;

        public FrmGoogleTranslate(EntityLocalizationEntry[] dgvNewDataSource)
        {
            InitializeComponent();
            this.dgvNewDataSource = dgvNewDataSource;
            LoadOriginal();
        }

        private void LoadOriginal()
        {
            string newLinw = "";
            if (dgvNewDataSource != null)
                foreach (var entry in dgvNewDataSource)
                {
                    tbOriginal.Text += newLinw + entry.Value;
                    newLinw = "\r\n";
                }
            tbApiKey.Text = Properties.Settings.Default.ApiKey;
        }

        private void BingAddItems(ComboBox cb)
        {
            foreach (String item in bingLanguages)
                cb.Items.Add(item);
        }

        private void GoogleAddItems(ComboBox cb)
        {
            foreach (String item in googleLanguages)
                cb.Items.Add(item);
        }

        private void BingComboLoad()
        {
            cbFrom.Items.Clear();
            cbTo.Items.Clear();

            this.BingAddItems(cbTo);
            this.BingAddItems(cbFrom);

            cbFrom.SelectedIndex = 4;
            cbTo.SelectedIndex = 4;
        }

        private void GoogleComboLoad()
        {
            cbFrom.Items.Clear();
            cbTo.Items.Clear();

            this.GoogleAddItems(cbTo);
            this.GoogleAddItems(cbFrom);

            cbFrom.SelectedIndex = 8;
            cbTo.SelectedIndex = 8;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save()
        {
            String[] lines = null;
            String[] delimiter = { "\r\n" };
            if (tbTranslated.Text != null)
                lines = tbTranslated.Text.Split(delimiter, StringSplitOptions.None);
            if (lines.Length != dgvNewDataSource.Length)
            {
                MessageBox.Show("Number of lines in Translated is not valid !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int i = 0;
            foreach (var entry in dgvNewDataSource)
            {
                entry.Value = lines[i];
                i++;
            }
            this.Close();
        }

        private void btnCyrlToLat_Click(object sender, EventArgs e)
        {
            tbTranslated.Text = CyrlLatConv.Convert(tbTranslated.Text, false);
        }

        private void btnLatToCyrl_Click(object sender, EventArgs e)
        {
            tbTranslated.Text = CyrlLatConv.Convert(tbTranslated.Text, true);
        }

        private void btnApiTranslation_Click(object sender, EventArgs e)
        {
            if (tbApiKey.Text == null || tbApiKey.Text == "")
            {
                MessageBox.Show("You have to input Api Key!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(rbBing.Checked || rbGoogle.Checked))
                MessageBox.Show("You have to select Google or Bing !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (rbBing.Checked)
                BingTranslation();
            else if (rbGoogle.Checked)
                GoogleTranslation();
        }

        protected void BingTranslation()
        {
            String apiKey = Properties.Settings.Default.ApiKey;
            try
            {
                String fromLanguage = bingLanguagesAbr[cbFrom.SelectedIndex];
                String toLanguage = bingLanguagesAbr[cbTo.SelectedIndex];
                TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient("BasicHttpBinding_LanguageService");
                String translatedLine = client.Translate(apiKey, tbOriginal.Text, fromLanguage, toLanguage);
                tbTranslated.Text = translatedLine;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace, "Error");
                throw new Exception();
            }
        }

        protected void GoogleTranslation()
        {
            String apiKey = Properties.Settings.Default.ApiKey; // get key from https://code.google.com/apis/console/
            String fromLanguage = googleLanguagesAbr[cbFrom.SelectedIndex];
            String toLanguage = googleLanguagesAbr[cbTo.SelectedIndex];

            // create the url for making web request
            String apiUrl = "https://www.googleapis.com/language/translate/v2?key={0}&source={1}&target={2}&q={3}";

            try
            {
                tbTranslated.Text = GoogleApi(String.Format(apiUrl, apiKey, fromLanguage, toLanguage, tbOriginal.Text));
            }
            catch (Exception)
            {
            }
        }

        protected string GoogleApi(string url)
        {
            string text = string.Empty;
            try
            {
                WebRequest req = HttpWebRequest.Create(url);
                req.Method = "GET";

                using (WebResponse res = req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.UTF8))
                    {
                        text = sr.ReadToEnd();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace, "Error");
                throw new Exception();
            }

            return text;
        }

        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ApiKey = tbApiKey.Text;
        }

        private void rbBing_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBing.Checked)
                BingComboLoad();
        }

        private void rbGoogle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGoogle.Checked)
                GoogleComboLoad();
        }

        private String[] bingLanguagesAbr = {
                                        "ar",//	Arabic	العربية
                                        "cs",//	Czech	česky, čeština
                                        "da",//	Danish	dansk
                                        "nl",//	Dutch	Nederlands, Vlaams
                                        "en",//	English	English
                                        "et",//	Estonian	eesti, eesti keel
                                        "fi",//	Finnish	suomi, suomen kieli
                                        "fr",//	French	français
                                        "de",//	German	Deutsch
                                        "el",//	Greek	Ελληνικά
                                        "he",//	Hebrew	עברית
                                        "ht",//	Haitian Creole	Kreyòl ayisyen
                                        "hu",//	Hungarian	Magyar
                                        "id",//	Indonesian	Bahasa Indonesia
                                        "it",//	Italian	Italiano
                                        "ja",//	Japanese	日本語
                                        "ko",//	Korean	한국어
                                        "lt",//	Lithuanian	lietuvių kalba
                                        "lv",//	Latvian	latviešu valoda
                                        "no",//	Norwegian	Norsk
                                        "pl",//	Polish	polski
                                        "pt",//	Portuguese	Português
                                        "ro",//	Romanian	română
                                        "es",//	Spanish	español
                                        "ru",//	Russian	русский язык
                                        "sk",//	Slovak	slovenčina
                                        "sl",//	Slovene	slovenščina
                                        "sv",//	Swedish	svenska
                                        "th",//	Thai	ไทย
                                        "tr",//	Turkish	Türkçe
                                        "uk",//	Ukrainian	українська
                                        "vi",//	Vietnamese	Tiếng Việt
                                        "zh-CHS",//	Simplified Chinese	中文
                                        "zh-CHT"//	Traditional Chinese
                                   };
        private String[] bingLanguages = {
                                        "Arabic",
                                        "Czech",
                                        "Danish",
                                        "Dutch",
                                        "English",
                                        "Estonian",
                                        "Finnish",
                                        "French",
                                        "German",
                                        "Greek",
                                        "Hebrew",
                                        "Haitian Creole",
                                        "Hungarian",
                                        "Indonesian",
                                        "Italian",
                                        "Japanese",
                                        "Korean",
                                        "Lithuanian",
                                        "Latvian",
                                        "Norwegian",
                                        "Polish",
                                        "Portuguese",
                                        "Romanian",
                                        "Spanish",
                                        "Russian",
                                        "Slovak",
                                        "Slovene",
                                        "Swedish",
                                        "Thai",
                                        "Turkish",
                                        "Ukrainian",
                                        "Vietnamese",
                                        "Simplified Chinese",
                                        "Traditional Chinese",
                                        };


        private String[] googleLanguagesAbr = {
                                        "ar", //Arabic
                                        "bg", //Bulgarian
                                        "ca", //Catalan
                                        "zh", //Chinese (simplified)
                                        "hr", //Croatian
                                        "cs", //Czech
                                        "da", //Danish
                                        "nl", //Dutch
                                        "en", //English
                                        "et", //Estonian
                                        "tl", //Filipino
                                        "fi", //Finnish
                                        "fr", //French
                                        "de", //German
                                        "el", //Greek
                                        "iw", //Hebrew
                                        "hi", //Hindi
                                        "hu", //Hungarian
                                        "is", //Icelandic
                                        "id", //Indonesian
                                        "it", //Italian
                                        "ja", //Japanese
                                        "ko", //Korean
                                        "lv", //Latvian
                                        "lt", //Lithuanian
                                        "no", //Norwegian
                                        "pl", //Polish
                                        "pt", //Portuguese
                                        "ro", //Romanian
                                        "ru", //Russian
                                        "sr", //Serbian
                                        "sk", //Slovak
                                        "sl", //Slovenian
                                        "es", //Spanish
                                        "sv", //Swedish
                                        "th", //Thai
                                        "tr", //Turkish
                                        "uk", //Ukrainian
                                        "ur", //Urdu
                                        "vi", //Vietnamese
                                      };
        private String[] googleLanguages = {
                                        "Arabic",
                                        "Bulgarian",
                                        "Catalan",
                                        "Chinese (simplified)",
                                        "Croatian",
                                        "Czech",
                                        "Danish",
                                        "Dutch",
                                        "English",
                                        "Estonian",
                                        "Filipino",
                                        "Finnish",
                                        "French",
                                        "German",
                                        "Greek",
                                        "Hebrew",
                                        "Hindi",
                                        "Hungarian",
                                        "Icelandic",
                                        "Indonesian",
                                        "Italian",
                                        "Japanese",
                                        "Korean",
                                        "Latvian",
                                        "Lithuanian",
                                        "Norwegian",
                                        "Polish",
                                        "Portuguese",
                                        "Romanian",
                                        "Russian",
                                        "Serbian",
                                        "Slovak",
                                        "Slovenian",
                                        "Spanish",
                                        "Swedish",
                                        "Thai",
                                        "Turkish",
                                        "Ukrainian",
                                        "Urdu",
                                        "Vietnamese" 
                                      };

    }
}

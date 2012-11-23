namespace Codaxy.Dextop.Localizer.Windows.Forms
{
    partial class FrmGoogleTranslate
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
            this.tbOriginal = new System.Windows.Forms.TextBox();
            this.lbOriginal = new System.Windows.Forms.Label();
            this.lbTranslated = new System.Windows.Forms.Label();
            this.tbTranslated = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCyrlToLat = new System.Windows.Forms.Button();
            this.btnLatToCyrl = new System.Windows.Forms.Button();
            this.btnApiTranslation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbBing = new System.Windows.Forms.RadioButton();
            this.rbGoogle = new System.Windows.Forms.RadioButton();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.lbFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.lbApiKey = new System.Windows.Forms.Label();
            this.tbApiKey = new System.Windows.Forms.TextBox();
            this.btnSaveKey = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOriginal
            // 
            this.tbOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOriginal.Location = new System.Drawing.Point(6, 26);
            this.tbOriginal.Multiline = true;
            this.tbOriginal.Name = "tbOriginal";
            this.tbOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOriginal.Size = new System.Drawing.Size(340, 442);
            this.tbOriginal.TabIndex = 0;
            // 
            // lbOriginal
            // 
            this.lbOriginal.AutoSize = true;
            this.lbOriginal.Location = new System.Drawing.Point(3, 10);
            this.lbOriginal.Name = "lbOriginal";
            this.lbOriginal.Size = new System.Drawing.Size(45, 13);
            this.lbOriginal.TabIndex = 1;
            this.lbOriginal.Text = "Original:";
            // 
            // lbTranslated
            // 
            this.lbTranslated.AutoSize = true;
            this.lbTranslated.Location = new System.Drawing.Point(5, 10);
            this.lbTranslated.Name = "lbTranslated";
            this.lbTranslated.Size = new System.Drawing.Size(60, 13);
            this.lbTranslated.TabIndex = 3;
            this.lbTranslated.Text = "Translated:";
            // 
            // tbTranslated
            // 
            this.tbTranslated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTranslated.Location = new System.Drawing.Point(8, 26);
            this.tbTranslated.Multiline = true;
            this.tbTranslated.Name = "tbTranslated";
            this.tbTranslated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTranslated.Size = new System.Drawing.Size(364, 442);
            this.tbTranslated.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(581, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(662, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCyrlToLat
            // 
            this.btnCyrlToLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCyrlToLat.Location = new System.Drawing.Point(414, 489);
            this.btnCyrlToLat.Name = "btnCyrlToLat";
            this.btnCyrlToLat.Size = new System.Drawing.Size(60, 23);
            this.btnCyrlToLat.TabIndex = 6;
            this.btnCyrlToLat.Text = "CyrlToLat";
            this.btnCyrlToLat.UseVisualStyleBackColor = true;
            this.btnCyrlToLat.Click += new System.EventHandler(this.btnCyrlToLat_Click);
            // 
            // btnLatToCyrl
            // 
            this.btnLatToCyrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLatToCyrl.Location = new System.Drawing.Point(480, 489);
            this.btnLatToCyrl.Name = "btnLatToCyrl";
            this.btnLatToCyrl.Size = new System.Drawing.Size(65, 23);
            this.btnLatToCyrl.TabIndex = 7;
            this.btnLatToCyrl.Text = "LatToCyrl";
            this.btnLatToCyrl.UseVisualStyleBackColor = true;
            this.btnLatToCyrl.Click += new System.EventHandler(this.btnLatToCyrl_Click);
            // 
            // btnApiTranslation
            // 
            this.btnApiTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApiTranslation.Location = new System.Drawing.Point(414, 518);
            this.btnApiTranslation.Name = "btnApiTranslation";
            this.btnApiTranslation.Size = new System.Drawing.Size(131, 23);
            this.btnApiTranslation.TabIndex = 8;
            this.btnApiTranslation.Text = "Api Translation";
            this.btnApiTranslation.UseVisualStyleBackColor = true;
            this.btnApiTranslation.Click += new System.EventHandler(this.btnApiTranslation_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.rbBing);
            this.panel1.Controls.Add(this.rbGoogle);
            this.panel1.Location = new System.Drawing.Point(12, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 41);
            this.panel1.TabIndex = 11;
            // 
            // rbBing
            // 
            this.rbBing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbBing.AutoSize = true;
            this.rbBing.Checked = true;
            this.rbBing.Location = new System.Drawing.Point(3, 3);
            this.rbBing.Name = "rbBing";
            this.rbBing.Size = new System.Drawing.Size(89, 17);
            this.rbBing.TabIndex = 1;
            this.rbBing.TabStop = true;
            this.rbBing.Text = "Bing trans api";
            this.rbBing.UseVisualStyleBackColor = true;
            this.rbBing.CheckedChanged += new System.EventHandler(this.rbBing_CheckedChanged);
            // 
            // rbGoogle
            // 
            this.rbGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbGoogle.AutoSize = true;
            this.rbGoogle.Location = new System.Drawing.Point(3, 21);
            this.rbGoogle.Name = "rbGoogle";
            this.rbGoogle.Size = new System.Drawing.Size(102, 17);
            this.rbGoogle.TabIndex = 0;
            this.rbGoogle.TabStop = true;
            this.rbGoogle.Text = "Google trans api";
            this.rbGoogle.UseVisualStyleBackColor = true;
            this.rbGoogle.CheckedChanged += new System.EventHandler(this.rbGoogle_CheckedChanged);
            // 
            // cbFrom
            // 
            this.cbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(168, 490);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(95, 21);
            this.cbFrom.TabIndex = 12;
            // 
            // lbFrom
            // 
            this.lbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(129, 494);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(33, 13);
            this.lbFrom.TabIndex = 13;
            this.lbFrom.Text = "From:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "To:";
            // 
            // cbTo
            // 
            this.cbTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(313, 490);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(95, 21);
            this.cbTo.TabIndex = 14;
            // 
            // lbApiKey
            // 
            this.lbApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbApiKey.AutoSize = true;
            this.lbApiKey.Location = new System.Drawing.Point(123, 521);
            this.lbApiKey.Name = "lbApiKey";
            this.lbApiKey.Size = new System.Drawing.Size(46, 13);
            this.lbApiKey.TabIndex = 16;
            this.lbApiKey.Text = "Api Key:";
            // 
            // tbApiKey
            // 
            this.tbApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbApiKey.Location = new System.Drawing.Point(168, 518);
            this.tbApiKey.Name = "tbApiKey";
            this.tbApiKey.Size = new System.Drawing.Size(174, 20);
            this.tbApiKey.TabIndex = 17;
            // 
            // btnSaveKey
            // 
            this.btnSaveKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveKey.Location = new System.Drawing.Point(348, 517);
            this.btnSaveKey.Name = "btnSaveKey";
            this.btnSaveKey.Size = new System.Drawing.Size(60, 23);
            this.btnSaveKey.TabIndex = 18;
            this.btnSaveKey.Text = "SaveKey";
            this.btnSaveKey.UseVisualStyleBackColor = true;
            this.btnSaveKey.Click += new System.EventHandler(this.btnSaveKey_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbOriginal);
            this.splitContainer1.Panel1.Controls.Add(this.lbOriginal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbTranslated);
            this.splitContainer1.Panel2.Controls.Add(this.tbTranslated);
            this.splitContainer1.Size = new System.Drawing.Size(734, 471);
            this.splitContainer1.SplitterDistance = 349;
            this.splitContainer1.TabIndex = 19;
            // 
            // FrmGoogleTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 543);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnSaveKey);
            this.Controls.Add(this.tbApiKey);
            this.Controls.Add(this.lbApiKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnApiTranslation);
            this.Controls.Add(this.btnLatToCyrl);
            this.Controls.Add(this.btnCyrlToLat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MinimumSize = new System.Drawing.Size(765, 581);
            this.Name = "FrmGoogleTranslate";
            this.Text = "FrmGoogleTranslate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOriginal;
        private System.Windows.Forms.Label lbOriginal;
        private System.Windows.Forms.Label lbTranslated;
        private System.Windows.Forms.TextBox tbTranslated;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCyrlToLat;
        private System.Windows.Forms.Button btnLatToCyrl;
        private System.Windows.Forms.Button btnApiTranslation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbBing;
        private System.Windows.Forms.RadioButton rbGoogle;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Label lbApiKey;
        private System.Windows.Forms.TextBox tbApiKey;
        private System.Windows.Forms.Button btnSaveKey;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
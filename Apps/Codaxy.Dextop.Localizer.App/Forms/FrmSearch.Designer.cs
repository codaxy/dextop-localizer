namespace Codaxy.Dextop.Localizer.Windows.Forms
{
    partial class FrmSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPattern = new System.Windows.Forms.TextBox();
            this.cbFields = new System.Windows.Forms.CheckBox();
            this.cbValues = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            this.rbContains = new System.Windows.Forms.RadioButton();
            this.rbStartsWith = new System.Windows.Forms.RadioButton();
            this.btFind = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // tbPattern
            // 
            this.tbPattern.Location = new System.Drawing.Point(15, 26);
            this.tbPattern.Name = "tbPattern";
            this.tbPattern.Size = new System.Drawing.Size(250, 20);
            this.tbPattern.TabIndex = 1;
            // 
            // cbFields
            // 
            this.cbFields.AutoSize = true;
            this.cbFields.Checked = true;
            this.cbFields.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFields.Location = new System.Drawing.Point(6, 19);
            this.cbFields.Name = "cbFields";
            this.cbFields.Size = new System.Drawing.Size(53, 17);
            this.cbFields.TabIndex = 2;
            this.cbFields.Text = "Fields";
            this.cbFields.UseVisualStyleBackColor = true;
            // 
            // cbValues
            // 
            this.cbValues.AutoSize = true;
            this.cbValues.Checked = true;
            this.cbValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbValues.Location = new System.Drawing.Point(6, 42);
            this.cbValues.Name = "cbValues";
            this.cbValues.Size = new System.Drawing.Size(58, 17);
            this.cbValues.TabIndex = 3;
            this.cbValues.Text = "Values";
            this.cbValues.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbValues);
            this.groupBox1.Controls.Add(this.cbFields);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search in";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMatchCase);
            this.groupBox2.Controls.Add(this.rbContains);
            this.groupBox2.Controls.Add(this.rbStartsWith);
            this.groupBox2.Location = new System.Drawing.Point(15, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criteria";
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.AutoSize = true;
            this.cbMatchCase.Location = new System.Drawing.Point(162, 21);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(82, 17);
            this.cbMatchCase.TabIndex = 2;
            this.cbMatchCase.Text = "Match case";
            this.cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // rbContains
            // 
            this.rbContains.AutoSize = true;
            this.rbContains.Location = new System.Drawing.Point(7, 43);
            this.rbContains.Name = "rbContains";
            this.rbContains.Size = new System.Drawing.Size(66, 17);
            this.rbContains.TabIndex = 1;
            this.rbContains.Text = "Contains";
            this.rbContains.UseVisualStyleBackColor = true;
            // 
            // rbStartsWith
            // 
            this.rbStartsWith.AutoSize = true;
            this.rbStartsWith.Checked = true;
            this.rbStartsWith.Location = new System.Drawing.Point(7, 20);
            this.rbStartsWith.Name = "rbStartsWith";
            this.rbStartsWith.Size = new System.Drawing.Size(74, 17);
            this.rbStartsWith.TabIndex = 0;
            this.rbStartsWith.TabStop = true;
            this.rbStartsWith.Text = "Starts with";
            this.rbStartsWith.UseVisualStyleBackColor = true;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(109, 211);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 6;
            this.btFind.Text = "Find next";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(190, 211);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FrmSearch
            // 
            this.AcceptButton = this.btFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(277, 240);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPattern);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmSearch";
            this.Text = "Find";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPattern;
        private System.Windows.Forms.CheckBox cbFields;
        private System.Windows.Forms.CheckBox cbValues;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbContains;
        private System.Windows.Forms.RadioButton rbStartsWith;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.CheckBox cbMatchCase;
    }
}
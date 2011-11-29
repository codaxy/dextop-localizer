namespace Codaxy.Dextop.Localizer.Windows.Forms
{
    partial class FrmEnvironment
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
            this.btClose = new System.Windows.Forms.Button();
            this.dgvEnvironment = new System.Windows.Forms.DataGridView();
            this.cmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemove = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvironment)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(603, 268);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "Cancel";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // dgvEnvironment
            // 
            this.dgvEnvironment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEnvironment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnvironment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvironment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmName,
            this.cmValue});
            this.dgvEnvironment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvEnvironment.Location = new System.Drawing.Point(20, 12);
            this.dgvEnvironment.Name = "dgvEnvironment";
            this.dgvEnvironment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEnvironment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEnvironment.Size = new System.Drawing.Size(658, 251);
            this.dgvEnvironment.TabIndex = 2;
            this.dgvEnvironment.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvEnvironment_RowValidating);
            // 
            // cmName
            // 
            this.cmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmName.DataPropertyName = "Name";
            this.cmName.FillWeight = 30F;
            this.cmName.HeaderText = "Name";
            this.cmName.Name = "cmName";
            // 
            // cmValue
            // 
            this.cmValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmValue.DataPropertyName = "Value";
            this.cmValue.FillWeight = 70F;
            this.cmValue.HeaderText = "Value";
            this.cmValue.Name = "cmValue";
            // 
            // btRemove
            // 
            this.btRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemove.Location = new System.Drawing.Point(20, 269);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 4;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(522, 268);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 5;
            this.btOk.Text = "Save";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // FrmEnvironment
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 304);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.dgvEnvironment);
            this.Controls.Add(this.btClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEnvironment";
            this.Text = "Environment variables";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvironment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView dgvEnvironment;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmValue;
        private System.Windows.Forms.Button btOk;
    }
}
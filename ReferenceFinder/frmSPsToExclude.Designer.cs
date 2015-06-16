namespace ReferenceFinder
{
    partial class frmSPsToExclude
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
            this.grdListToExclude = new System.Windows.Forms.DataGridView();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.grd_colSPsToExclude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdListToExclude)).BeginInit();
            this.SuspendLayout();
            // 
            // grdListToExclude
            // 
            this.grdListToExclude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdListToExclude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListToExclude.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grd_colSPsToExclude});
            this.grdListToExclude.Location = new System.Drawing.Point(1, 59);
            this.grdListToExclude.Name = "grdListToExclude";
            this.grdListToExclude.RowTemplate.Height = 24;
            this.grdListToExclude.Size = new System.Drawing.Size(556, 355);
            this.grdListToExclude.TabIndex = 0;
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(13, 13);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(110, 40);
            this.btnPaste.TabIndex = 1;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnSaveList
            // 
            this.btnSaveList.Location = new System.Drawing.Point(442, 13);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(105, 40);
            this.btnSaveList.TabIndex = 2;
            this.btnSaveList.Text = "Save List";
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // grd_colSPsToExclude
            // 
            this.grd_colSPsToExclude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grd_colSPsToExclude.HeaderText = "SPs To Exclude";
            this.grd_colSPsToExclude.Name = "grd_colSPsToExclude";
            // 
            // frmSPsToExclude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 418);
            this.Controls.Add(this.btnSaveList);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.grdListToExclude);
            this.Name = "frmSPsToExclude";
            this.Text = "frmSPsToExclude";
            ((System.ComponentModel.ISupportInitialize)(this.grdListToExclude)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdListToExclude;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.DataGridViewTextBoxColumn grd_colSPsToExclude;
    }
}
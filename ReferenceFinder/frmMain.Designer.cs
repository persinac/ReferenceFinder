namespace ReferenceFinder
{
    partial class frmMain
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnParseFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFindProduct = new System.Windows.Forms.Button();
            this.btnToXLS = new System.Windows.Forms.Button();
            this.btnMasterSave = new System.Windows.Forms.Button();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.btnSPsToExclude = new System.Windows.Forms.Button();
            this.grdMasterDLLs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grdColDLL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMasterDLLs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(189, 54);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(260, 22);
            this.txtFileName.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(13, 50);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(170, 31);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Select File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnParseFile
            // 
            this.btnParseFile.Location = new System.Drawing.Point(13, 88);
            this.btnParseFile.Name = "btnParseFile";
            this.btnParseFile.Size = new System.Drawing.Size(170, 33);
            this.btnParseFile.TabIndex = 2;
            this.btnParseFile.Text = "Parse File";
            this.btnParseFile.UseVisualStyleBackColor = true;
            this.btnParseFile.Click += new System.EventHandler(this.btnParseFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(630, 245);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(325, 88);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 33);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.Location = new System.Drawing.Point(189, 88);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(130, 32);
            this.btnFindProduct.TabIndex = 5;
            this.btnFindProduct.Text = "Find Product";
            this.btnFindProduct.UseVisualStyleBackColor = true;
            this.btnFindProduct.Click += new System.EventHandler(this.btnFindProduct_Click);
            // 
            // btnToXLS
            // 
            this.btnToXLS.Location = new System.Drawing.Point(456, 88);
            this.btnToXLS.Name = "btnToXLS";
            this.btnToXLS.Size = new System.Drawing.Size(141, 33);
            this.btnToXLS.TabIndex = 6;
            this.btnToXLS.Text = "Export to xls";
            this.btnToXLS.UseVisualStyleBackColor = true;
            this.btnToXLS.Click += new System.EventHandler(this.btnToXLS_Click);
            // 
            // btnMasterSave
            // 
            this.btnMasterSave.Location = new System.Drawing.Point(13, 390);
            this.btnMasterSave.Name = "btnMasterSave";
            this.btnMasterSave.Size = new System.Drawing.Size(170, 37);
            this.btnMasterSave.TabIndex = 7;
            this.btnMasterSave.Text = "Save to Master";
            this.btnMasterSave.UseVisualStyleBackColor = true;
            this.btnMasterSave.Click += new System.EventHandler(this.btnMasterSave_Click);
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Location = new System.Drawing.Point(482, 390);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(161, 37);
            this.btnOpenDB.TabIndex = 8;
            this.btnOpenDB.Text = "Open DB Form";
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // btnSPsToExclude
            // 
            this.btnSPsToExclude.Location = new System.Drawing.Point(340, 390);
            this.btnSPsToExclude.Name = "btnSPsToExclude";
            this.btnSPsToExclude.Size = new System.Drawing.Size(136, 37);
            this.btnSPsToExclude.TabIndex = 9;
            this.btnSPsToExclude.Text = "SPs To Exclude";
            this.btnSPsToExclude.UseVisualStyleBackColor = true;
            this.btnSPsToExclude.Click += new System.EventHandler(this.btnSPsToExclude_Click);
            // 
            // grdMasterDLLs
            // 
            this.grdMasterDLLs.AllowUserToAddRows = false;
            this.grdMasterDLLs.AllowUserToDeleteRows = false;
            this.grdMasterDLLs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMasterDLLs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdColDLL});
            this.grdMasterDLLs.Location = new System.Drawing.Point(13, 471);
            this.grdMasterDLLs.Name = "grdMasterDLLs";
            this.grdMasterDLLs.ReadOnly = true;
            this.grdMasterDLLs.RowTemplate.Height = 24;
            this.grdMasterDLLs.Size = new System.Drawing.Size(338, 150);
            this.grdMasterDLLs.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "DLLs in Master";
            // 
            // grdColDLL
            // 
            this.grdColDLL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdColDLL.HeaderText = "DLL";
            this.grdColDLL.Name = "grdColDLL";
            this.grdColDLL.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 639);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdMasterDLLs);
            this.Controls.Add(this.btnSPsToExclude);
            this.Controls.Add(this.btnOpenDB);
            this.Controls.Add(this.btnMasterSave);
            this.Controls.Add(this.btnToXLS);
            this.Controls.Add(this.btnFindProduct);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnParseFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtFileName);
            this.Name = "frmMain";
            this.Text = "Open File";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMasterDLLs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnParseFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFindProduct;
        private System.Windows.Forms.Button btnToXLS;
        private System.Windows.Forms.Button btnMasterSave;
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.Button btnSPsToExclude;
        private System.Windows.Forms.DataGridView grdMasterDLLs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColDLL;
    }
}


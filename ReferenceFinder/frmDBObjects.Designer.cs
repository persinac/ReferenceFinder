namespace ReferenceFinder
{
    partial class frmDBObjects
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
            this.rTxtInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.btnConnectToServer = new System.Windows.Forms.Button();
            this.btnGetSMO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdListOfSPs = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.btnScriptSPs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdListOfSPs)).BeginInit();
            this.SuspendLayout();
            // 
            // rTxtInfo
            // 
            this.rTxtInfo.Location = new System.Drawing.Point(12, 351);
            this.rTxtInfo.Name = "rTxtInfo";
            this.rTxtInfo.ReadOnly = true;
            this.rTxtInfo.Size = new System.Drawing.Size(672, 156);
            this.rTxtInfo.TabIndex = 0;
            this.rTxtInfo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(115, 38);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(210, 22);
            this.txtServerName.TabIndex = 2;
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Location = new System.Drawing.Point(12, 70);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(158, 32);
            this.btnConnectToServer.TabIndex = 3;
            this.btnConnectToServer.Text = "Connect";
            this.btnConnectToServer.UseVisualStyleBackColor = true;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
            // 
            // btnGetSMO
            // 
            this.btnGetSMO.Location = new System.Drawing.Point(177, 70);
            this.btnGetSMO.Name = "btnGetSMO";
            this.btnGetSMO.Size = new System.Drawing.Size(148, 32);
            this.btnGetSMO.TabIndex = 4;
            this.btnGetSMO.Text = "Get Info";
            this.btnGetSMO.UseVisualStyleBackColor = true;
            this.btnGetSMO.Click += new System.EventHandler(this.btnGetSMO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(115, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(210, 22);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(437, 10);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(247, 22);
            this.txtPass.TabIndex = 7;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // grdListOfSPs
            // 
            this.grdListOfSPs.AllowUserToAddRows = false;
            this.grdListOfSPs.AllowUserToDeleteRows = false;
            this.grdListOfSPs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListOfSPs.Location = new System.Drawing.Point(12, 119);
            this.grdListOfSPs.Name = "grdListOfSPs";
            this.grdListOfSPs.ReadOnly = true;
            this.grdListOfSPs.RowTemplate.Height = 24;
            this.grdListOfSPs.Size = new System.Drawing.Size(672, 226);
            this.grdListOfSPs.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Database";
            // 
            // cboDatabase
            // 
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(437, 36);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(247, 24);
            this.cboDatabase.TabIndex = 11;
            // 
            // btnScriptSPs
            // 
            this.btnScriptSPs.Location = new System.Drawing.Point(332, 70);
            this.btnScriptSPs.Name = "btnScriptSPs";
            this.btnScriptSPs.Size = new System.Drawing.Size(133, 31);
            this.btnScriptSPs.TabIndex = 12;
            this.btnScriptSPs.Text = "Script List of SPs";
            this.btnScriptSPs.UseVisualStyleBackColor = true;
            this.btnScriptSPs.Click += new System.EventHandler(this.btnScriptSPs_Click);
            // 
            // frmDBObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 519);
            this.Controls.Add(this.btnScriptSPs);
            this.Controls.Add(this.cboDatabase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdListOfSPs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetSMO);
            this.Controls.Add(this.btnConnectToServer);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTxtInfo);
            this.Name = "frmDBObjects";
            this.Text = "dbObjects";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dbObjects_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdListOfSPs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.Button btnGetSMO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdListOfSPs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Button btnScriptSPs;
    }
}
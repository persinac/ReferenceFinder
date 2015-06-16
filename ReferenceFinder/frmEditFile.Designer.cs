namespace ReferenceFinder
{
    partial class frmEditFile
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAddUse = new System.Windows.Forms.Button();
            this.btnAddDrop = new System.Windows.Forms.Button();
            this.btnAddGrant = new System.Windows.Forms.Button();
            this.txtWhichDB = new System.Windows.Forms.TextBox();
            this.lblWhichDBToUse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(13, 13);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(126, 32);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(748, 365);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnAddUse
            // 
            this.btnAddUse.Location = new System.Drawing.Point(13, 415);
            this.btnAddUse.Name = "btnAddUse";
            this.btnAddUse.Size = new System.Drawing.Size(214, 31);
            this.btnAddUse.TabIndex = 2;
            this.btnAddUse.Text = "Add Use";
            this.btnAddUse.UseVisualStyleBackColor = true;
            // 
            // btnAddDrop
            // 
            this.btnAddDrop.Location = new System.Drawing.Point(289, 415);
            this.btnAddDrop.Name = "btnAddDrop";
            this.btnAddDrop.Size = new System.Drawing.Size(227, 31);
            this.btnAddDrop.TabIndex = 3;
            this.btnAddDrop.Text = "Add Drop";
            this.btnAddDrop.UseVisualStyleBackColor = true;
            // 
            // btnAddGrant
            // 
            this.btnAddGrant.Location = new System.Drawing.Point(573, 415);
            this.btnAddGrant.Name = "btnAddGrant";
            this.btnAddGrant.Size = new System.Drawing.Size(188, 31);
            this.btnAddGrant.TabIndex = 4;
            this.btnAddGrant.Text = "Add Grant";
            this.btnAddGrant.UseVisualStyleBackColor = true;
            // 
            // txtWhichDB
            // 
            this.txtWhichDB.Location = new System.Drawing.Point(141, 454);
            this.txtWhichDB.Name = "txtWhichDB";
            this.txtWhichDB.Size = new System.Drawing.Size(86, 22);
            this.txtWhichDB.TabIndex = 5;
            // 
            // lblWhichDBToUse
            // 
            this.lblWhichDBToUse.AutoSize = true;
            this.lblWhichDBToUse.Location = new System.Drawing.Point(15, 457);
            this.lblWhichDBToUse.Name = "lblWhichDBToUse";
            this.lblWhichDBToUse.Size = new System.Drawing.Size(124, 17);
            this.lblWhichDBToUse.TabIndex = 6;
            this.lblWhichDBToUse.Text = "Which DB To Use:";
            // 
            // frmEditFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 493);
            this.Controls.Add(this.lblWhichDBToUse);
            this.Controls.Add(this.txtWhichDB);
            this.Controls.Add(this.btnAddGrant);
            this.Controls.Add(this.btnAddDrop);
            this.Controls.Add(this.btnAddUse);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "frmEditFile";
            this.Text = "frmEditFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAddUse;
        private System.Windows.Forms.Button btnAddDrop;
        private System.Windows.Forms.Button btnAddGrant;
        private System.Windows.Forms.TextBox txtWhichDB;
        private System.Windows.Forms.Label lblWhichDBToUse;
    }
}
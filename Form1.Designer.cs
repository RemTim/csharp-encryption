namespace csharp_encryption
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEncryptFile = new System.Windows.Forms.Button();
            this.buttonDecryptFile = new System.Windows.Forms.Button();
            this.buttonCreateAsmKeys = new System.Windows.Forms.Button();
            this.buttonExportPublicKey = new System.Windows.Forms.Button();
            this.buttonImportPublicKey = new System.Windows.Forms.Button();
            this.buttonGetPrivateKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._encryptOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._decryptOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonEncryptFile
            // 
            this.buttonEncryptFile.Location = new System.Drawing.Point(12, 352);
            this.buttonEncryptFile.Name = "buttonEncryptFile";
            this.buttonEncryptFile.Size = new System.Drawing.Size(148, 86);
            this.buttonEncryptFile.TabIndex = 0;
            this.buttonEncryptFile.Text = "Encrypt File";
            this.buttonEncryptFile.UseVisualStyleBackColor = true;
            this.buttonEncryptFile.Click += new System.EventHandler(this.buttonEncryptFile_Click);
            // 
            // buttonDecryptFile
            // 
            this.buttonDecryptFile.Location = new System.Drawing.Point(166, 352);
            this.buttonDecryptFile.Name = "buttonDecryptFile";
            this.buttonDecryptFile.Size = new System.Drawing.Size(148, 86);
            this.buttonDecryptFile.TabIndex = 1;
            this.buttonDecryptFile.Text = "Decrypt File";
            this.buttonDecryptFile.UseVisualStyleBackColor = true;
            this.buttonDecryptFile.Click += new System.EventHandler(this.buttonDecryptFile_Click);
            // 
            // buttonCreateAsmKeys
            // 
            this.buttonCreateAsmKeys.Location = new System.Drawing.Point(320, 352);
            this.buttonCreateAsmKeys.Name = "buttonCreateAsmKeys";
            this.buttonCreateAsmKeys.Size = new System.Drawing.Size(148, 86);
            this.buttonCreateAsmKeys.TabIndex = 2;
            this.buttonCreateAsmKeys.Text = "Create Keys";
            this.buttonCreateAsmKeys.UseVisualStyleBackColor = true;
            this.buttonCreateAsmKeys.Click += new System.EventHandler(this.buttonCreateAsmKeys_Click);
            // 
            // buttonExportPublicKey
            // 
            this.buttonExportPublicKey.Location = new System.Drawing.Point(474, 352);
            this.buttonExportPublicKey.Name = "buttonExportPublicKey";
            this.buttonExportPublicKey.Size = new System.Drawing.Size(148, 86);
            this.buttonExportPublicKey.TabIndex = 3;
            this.buttonExportPublicKey.Text = "Export Public Key";
            this.buttonExportPublicKey.UseVisualStyleBackColor = true;
            this.buttonExportPublicKey.Click += new System.EventHandler(this.buttonExportPublicKey_Click);
            // 
            // buttonImportPublicKey
            // 
            this.buttonImportPublicKey.Location = new System.Drawing.Point(474, 260);
            this.buttonImportPublicKey.Name = "buttonImportPublicKey";
            this.buttonImportPublicKey.Size = new System.Drawing.Size(148, 86);
            this.buttonImportPublicKey.TabIndex = 4;
            this.buttonImportPublicKey.Text = "Import Public Key";
            this.buttonImportPublicKey.UseVisualStyleBackColor = true;
            this.buttonImportPublicKey.Click += new System.EventHandler(this.buttonImportPublicKey_Click);
            // 
            // buttonGetPrivateKey
            // 
            this.buttonGetPrivateKey.Location = new System.Drawing.Point(474, 168);
            this.buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            this.buttonGetPrivateKey.Size = new System.Drawing.Size(148, 86);
            this.buttonGetPrivateKey.TabIndex = 5;
            this.buttonGetPrivateKey.Text = "Get Private Key";
            this.buttonGetPrivateKey.UseVisualStyleBackColor = true;
            this.buttonGetPrivateKey.Click += new System.EventHandler(this.buttonGetPrivateKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Key not set";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _encryptOpenFileDialog
            // 
            this._encryptOpenFileDialog.FileName = "openFileDialog1";
            this._encryptOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this._encryptOpenFileDialog_FileOk);
            // 
            // _decryptOpenFileDialog
            // 
            this._decryptOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this._decryptOpenFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGetPrivateKey);
            this.Controls.Add(this.buttonImportPublicKey);
            this.Controls.Add(this.buttonExportPublicKey);
            this.Controls.Add(this.buttonCreateAsmKeys);
            this.Controls.Add(this.buttonDecryptFile);
            this.Controls.Add(this.buttonEncryptFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEncryptFile;
        private Button buttonDecryptFile;
        private Button buttonCreateAsmKeys;
        private Button buttonExportPublicKey;
        private Button buttonImportPublicKey;
        private Button buttonGetPrivateKey;
        private Label label1;
        private OpenFileDialog _encryptOpenFileDialog;
        private OpenFileDialog _decryptOpenFileDialog;
    }
}
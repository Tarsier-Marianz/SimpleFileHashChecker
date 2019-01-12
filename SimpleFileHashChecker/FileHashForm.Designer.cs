namespace SimpleFileHashChecker {
    partial class FileHashForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.btnHash = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMd5 = new System.Windows.Forms.TextBox();
            this.txtSha256 = new System.Windows.Forms.TextBox();
            this.txtSha512 = new System.Windows.Forms.TextBox();
            this.txtSha1 = new System.Windows.Forms.TextBox();
            this.SHA512 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRIPEMD160 = new System.Windows.Forms.TextBox();
            this.txtSha384 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sha384 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHmacRIPEMD160 = new System.Windows.Forms.TextBox();
            this.txtHmacSha384 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHmacSha512 = new System.Windows.Forms.TextBox();
            this.txtHmacSha1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHmacSha256 = new System.Windows.Forms.TextBox();
            this.txtHmacMD5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "SHA256:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "MD5:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(846, 11);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.Tag = "BROWSE";
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // btnHash
            // 
            this.btnHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHash.Location = new System.Drawing.Point(882, 11);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(75, 23);
            this.btnHash.TabIndex = 11;
            this.btnHash.Tag = "HASH";
            this.btnHash.Text = "Hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(91, 13);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(749, 21);
            this.txtFile.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "File:";
            // 
            // txtMd5
            // 
            this.txtMd5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMd5.Location = new System.Drawing.Point(91, 61);
            this.txtMd5.Name = "txtMd5";
            this.txtMd5.ReadOnly = true;
            this.txtMd5.Size = new System.Drawing.Size(866, 21);
            this.txtMd5.TabIndex = 16;
            // 
            // txtSha256
            // 
            this.txtSha256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSha256.Location = new System.Drawing.Point(91, 87);
            this.txtSha256.Name = "txtSha256";
            this.txtSha256.ReadOnly = true;
            this.txtSha256.Size = new System.Drawing.Size(866, 21);
            this.txtSha256.TabIndex = 17;
            // 
            // txtSha512
            // 
            this.txtSha512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSha512.Location = new System.Drawing.Point(91, 139);
            this.txtSha512.Name = "txtSha512";
            this.txtSha512.ReadOnly = true;
            this.txtSha512.Size = new System.Drawing.Size(866, 21);
            this.txtSha512.TabIndex = 21;
            // 
            // txtSha1
            // 
            this.txtSha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSha1.Location = new System.Drawing.Point(91, 113);
            this.txtSha1.Name = "txtSha1";
            this.txtSha1.ReadOnly = true;
            this.txtSha1.Size = new System.Drawing.Size(866, 21);
            this.txtSha1.TabIndex = 20;
            // 
            // SHA512
            // 
            this.SHA512.AutoSize = true;
            this.SHA512.Location = new System.Drawing.Point(12, 142);
            this.SHA512.Name = "SHA512";
            this.SHA512.Size = new System.Drawing.Size(49, 13);
            this.SHA512.TabIndex = 19;
            this.SHA512.Text = "SHA512:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "SHA1:";
            // 
            // txtRIPEMD160
            // 
            this.txtRIPEMD160.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRIPEMD160.Location = new System.Drawing.Point(91, 191);
            this.txtRIPEMD160.Name = "txtRIPEMD160";
            this.txtRIPEMD160.ReadOnly = true;
            this.txtRIPEMD160.Size = new System.Drawing.Size(866, 21);
            this.txtRIPEMD160.TabIndex = 25;
            // 
            // txtSha384
            // 
            this.txtSha384.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSha384.Location = new System.Drawing.Point(91, 165);
            this.txtSha384.Name = "txtSha384";
            this.txtSha384.ReadOnly = true;
            this.txtSha384.Size = new System.Drawing.Size(866, 21);
            this.txtSha384.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "RIPEMD160 :";
            // 
            // Sha384
            // 
            this.Sha384.AutoSize = true;
            this.Sha384.Location = new System.Drawing.Point(12, 168);
            this.Sha384.Name = "Sha384";
            this.Sha384.Size = new System.Drawing.Size(49, 13);
            this.Sha384.TabIndex = 22;
            this.Sha384.Text = "SHA384:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "HMAC -Hash based Message Authentication Code. ";
            // 
            // txtHmacRIPEMD160
            // 
            this.txtHmacRIPEMD160.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHmacRIPEMD160.Location = new System.Drawing.Point(91, 395);
            this.txtHmacRIPEMD160.Name = "txtHmacRIPEMD160";
            this.txtHmacRIPEMD160.ReadOnly = true;
            this.txtHmacRIPEMD160.Size = new System.Drawing.Size(866, 21);
            this.txtHmacRIPEMD160.TabIndex = 38;
            // 
            // txtHmacSha384
            // 
            this.txtHmacSha384.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHmacSha384.Location = new System.Drawing.Point(91, 369);
            this.txtHmacSha384.Name = "txtHmacSha384";
            this.txtHmacSha384.ReadOnly = true;
            this.txtHmacSha384.Size = new System.Drawing.Size(866, 21);
            this.txtHmacSha384.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "RIPEMD160 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "SHA384:";
            // 
            // txtHmacSha512
            // 
            this.txtHmacSha512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHmacSha512.Location = new System.Drawing.Point(91, 343);
            this.txtHmacSha512.Name = "txtHmacSha512";
            this.txtHmacSha512.ReadOnly = true;
            this.txtHmacSha512.Size = new System.Drawing.Size(866, 21);
            this.txtHmacSha512.TabIndex = 34;
            // 
            // txtHmacSha1
            // 
            this.txtHmacSha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHmacSha1.Location = new System.Drawing.Point(91, 317);
            this.txtHmacSha1.Name = "txtHmacSha1";
            this.txtHmacSha1.ReadOnly = true;
            this.txtHmacSha1.Size = new System.Drawing.Size(866, 21);
            this.txtHmacSha1.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "SHA512:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "SHA1:";
            // 
            // txtHmacSha256
            // 
            this.txtHmacSha256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHmacSha256.Location = new System.Drawing.Point(91, 291);
            this.txtHmacSha256.Name = "txtHmacSha256";
            this.txtHmacSha256.ReadOnly = true;
            this.txtHmacSha256.Size = new System.Drawing.Size(866, 21);
            this.txtHmacSha256.TabIndex = 30;
            // 
            // txtHmacMD5
            // 
            this.txtHmacMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHmacMD5.Location = new System.Drawing.Point(91, 265);
            this.txtHmacMD5.Name = "txtHmacMD5";
            this.txtHmacMD5.ReadOnly = true;
            this.txtHmacMD5.Size = new System.Drawing.Size(866, 21);
            this.txtHmacMD5.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "SHA256:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "MD5:";
            // 
            // FileHashForm
            // 
            this.AcceptButton = this.btnHash;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 444);
            this.Controls.Add(this.txtHmacRIPEMD160);
            this.Controls.Add(this.txtHmacSha384);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHmacSha512);
            this.Controls.Add(this.txtHmacSha1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHmacSha256);
            this.Controls.Add(this.txtHmacMD5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRIPEMD160);
            this.Controls.Add(this.txtSha384);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sha384);
            this.Controls.Add(this.txtSha512);
            this.Controls.Add(this.txtSha1);
            this.Controls.Add(this.SHA512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSha256);
            this.Controls.Add(this.txtMd5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FileHashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple File Hash Checker";
            this.Load += new System.EventHandler(this.FileHashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMd5;
        private System.Windows.Forms.TextBox txtSha256;
        private System.Windows.Forms.TextBox txtSha512;
        private System.Windows.Forms.TextBox txtSha1;
        private System.Windows.Forms.Label SHA512;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRIPEMD160;
        private System.Windows.Forms.TextBox txtSha384;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Sha384;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHmacRIPEMD160;
        private System.Windows.Forms.TextBox txtHmacSha384;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHmacSha512;
        private System.Windows.Forms.TextBox txtHmacSha1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHmacSha256;
        private System.Windows.Forms.TextBox txtHmacMD5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}


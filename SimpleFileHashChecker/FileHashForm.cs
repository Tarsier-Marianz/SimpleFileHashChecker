using System;
using System.Windows.Forms;

namespace SimpleFileHashChecker {
    public partial class FileHashForm : Form {
        public FileHashForm() {
            InitializeComponent();
        }
        private void FileHashForm_Load(object sender, EventArgs e) {
            txtFile.Text = Application.ExecutablePath;
        }
        private void Buttons_Click(object sender, EventArgs e) {
            Button btn = sender as Button;
            if(btn != null) {
                string tag = btn.Tag.ToString();
                if(!string.IsNullOrEmpty(tag)) {
                    if(tag.Equals("BROWSE")) {
                        ofdFile.FileName = txtFile.Text;
                        if(ofdFile.ShowDialog() == DialogResult.OK) {
                            txtFile.Text = ofdFile.FileName;
                            ClearAllResults();
                        }
                    } else if(tag.Equals("HASH")) {
                        if(txtFile.Text.Trim().Length > 0) {
                            StartGetHash(txtFile.Text);
                        }
                    }else {

                    }
                }
            }
        }

        private void StartGetHash(string filename) {
            txtMd5.Text = FileChecksum.GetHashFromFile(filename, Algorithms.MD5);
            txtSha1.Text = FileChecksum.GetHashFromFile(filename, Algorithms.SHA1);
            txtSha256.Text = FileChecksum.GetHashFromFile(filename, Algorithms.SHA256);
            txtSha384.Text = FileChecksum.GetHashFromFile(filename, Algorithms.SHA384);
            txtSha512.Text = FileChecksum.GetHashFromFile(filename, Algorithms.SHA512);
            txtRIPEMD160.Text = FileChecksum.GetHashFromFile(filename, Algorithms.RIPEMD160);

            txtHmacMD5.Text = FileChecksum.GetHashFromFile(filename, Algorithms.HMACMD5);
            txtHmacSha1.Text = FileChecksum.GetHashFromFile(filename, Algorithms.HMACSHA1);
            txtHmacSha256.Text = FileChecksum.GetHashFromFile(filename, Algorithms.HMACSHA256);
            txtHmacSha384.Text = FileChecksum.GetHashFromFile(filename, Algorithms.HMACSHA384);
            txtHmacSha512.Text = FileChecksum.GetHashFromFile(filename, Algorithms.HMACSHA512);
            txtHmacRIPEMD160.Text = FileChecksum.GetHashFromFile(filename, Algorithms.HMACRIPEMD160);
        }
        private void ClearAllResults() {
            foreach(Control ctr in this.Controls) {
                if(ctr is TextBox) {
                    TextBox txt = ctr as TextBox;
                    if(txt.Name != "txtFile") {
                        txt.Clear();
                    }
                }
            }
        }
       
    }
}

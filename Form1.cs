using System.IO;
using System.Security.Cryptography;

namespace csharp_encryption
{
    public partial class Form1 : Form
    {
        private readonly CspParameters _cspp = new CspParameters();
        private RSACryptoServiceProvider _rsa;

        private const string EncrFolder = @"c:\CryptographyProgram\Encrypt\";
        private const string DecrFolder = @"c:\CryptographyProgram\Decrypt\";
        private const string SrcFolder = @"c:\CryptographyProgram\docs\";

        private const string PubKeyFile = @"c:\CryptographyProgram\encrypt\rsaPublicKey.txt";
        private const string KeyName = "Key01";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetPrivateKey_Click(object sender, EventArgs e)
        {

        }

        private void buttonImportPublicKey_Click(object sender, EventArgs e)
        {

        }

        private void buttonExportPublicKey_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateAsmKeys_Click(object sender, EventArgs e)
        {
            _cspp.KeyContainerName = KeyName;
            _rsa = new RSACryptoServiceProvider(_cspp)
            {
                PersistKeyInCsp = true
            };

            label1.Text = _rsa.PublicOnly
                ? $"Key: {_cspp.KeyContainerName} - Public Only"
                : $"Key: {_cspp.KeyContainerName} - Full Key Pair";
        }

        private void buttonDecryptFile_Click(object sender, EventArgs e)
        {

        }

        private void buttonEncryptFile_Click(object sender, EventArgs e)
        {
            if (_rsa is null)
            {
                MessageBox.Show("Key not set.");
            }
            else
            {
                _encryptOpenFileDialog.InitialDirectory = SrcFolder;
                if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = _encryptOpenFileDialog.FileName;
                    if (fName != null)
                    {
                        EncryptFile(new FileInfo(fName));
                    }
                }
            }
        }

        private void EncryptFile(FileInfo file)
        {
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            byte[] keyEncrypted = _rsa.Encrypt(aes.Key, false);

            int lKey = keyEncrypted.Length;
            byte[] LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            byte[] LenIV = BitConverter.GetBytes(lIV);

            string outFile = Path.Combine(EncrFolder, Path.ChangeExtension(file.Name, ".enc"));

            using (var outFs = new FileStream(outFile, FileMode.Create))
            {
                outFs.Write(LenK, 0, 4);
                outFs.Write(LenIV, 0, 4);
                outFs.Write(keyEncrypted, 0, lKey);
                outFs.Write(aes.IV, 0, lIV);

                using (var outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                {
                    int count = 0;
                    int offset = 0;

                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];
                    int bytesRead = 0;

                    using (var inFs = new FileStream(file.FullName, FileMode.Open))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamEncrypted.Write(data, 0, count);
                            bytesRead += blockSizeBytes;
                        } while (count > 0);
                    }
                    outStreamEncrypted.FlushFinalBlock();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _encryptOpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
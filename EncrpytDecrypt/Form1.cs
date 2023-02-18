using System.Windows.Forms;

namespace EncrpytDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Filebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new();
            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;

                fileDialog.InitialDirectory = "C:\\";
                fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                FilePathtxtbox.Text = fileDialog.FileName;
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
          
            int value;
            bool IsNumber = int.TryParse(Passwordtxtbox.Text.Trim(), out value);
            if (!IsNumber)
                return;
            if (Encryptbtn.Checked)
                EncryptFile(FilePathtxtbox.Text, FilePathtxtbox.Text + '1');
            else
                DecryptFile("", "");
        }
        private void Cancelbtn_Click(object sender, EventArgs e)
        {

        }

        private void DecryptFile(string inputFile, string outputFile)
        {

        }


        void EncryptFile(string inputFile, string outputFile)
        {
            using (var fin = new FileStream(inputFile, FileMode.Open))
            using (var fout = new FileStream(outputFile, FileMode.Create))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int bytesRead = fin.Read(buffer);
                    if (bytesRead == 0)
                        break;
                    EncryptBytes(buffer, bytesRead);
                    fout.Write(buffer, 0, bytesRead);
                }
            }
        }

        void EncryptBytes(byte[] buffer, int count)
        {

            for (int i = 0; i < count; i++)
                buffer[i] = (byte)(buffer[i] ^ int.Parse(Passwordtxtbox.Text));
        }

    }
}
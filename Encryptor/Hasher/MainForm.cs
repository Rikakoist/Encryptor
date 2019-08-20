using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //private void HashButton_Click(object sender, EventArgs e)
        //{
        //    string MD5Result = Encrypt.GetHash(StringInputTextBox.Text, 0);
        //    string SHA1Result = Encrypt.GetHash(StringInputTextBox.Text, 1);
        //    string SHA256Result = Encrypt.GetHash(StringInputTextBox.Text, 2);
        //    string SHA384Result = Encrypt.GetHash(StringInputTextBox.Text, 3);
        //    string SHA512Result = Encrypt.GetHash(StringInputTextBox.Text, 4);
        //    HashResultTextBox.Text = "MD5: " + (MD5Result ?? "NULL") + "\r\n"
        //        + "SHA1: " + (SHA1Result ?? "NULL") + "\r\n"
        //        + "SHA256: " + (SHA256Result ?? "NULL") + "\r\n"
        //        + "SHA384: " + (SHA384Result ?? "NULL") + "\r\n"
        //        + "SHA512: " + (SHA512Result ?? "NULL");
        //}

        private void AutoCalc(object sender, EventArgs e)
        {
            var MD5Result = Encrypt.GetHash(StringInputTextBox.Text, 0);
            var SHA1Result = Encrypt.GetHash(StringInputTextBox.Text, 1);
            var SHA256Result = Encrypt.GetHash(StringInputTextBox.Text, 2);
            var SHA384Result = Encrypt.GetHash(StringInputTextBox.Text, 3);
            var SHA512Result = Encrypt.GetHash(StringInputTextBox.Text, 4);
            HashResultTextBox.Text = "MD5(Uppercase32): " + (MD5Result ?? "NULL") + "\r\n"
                + "MD5(Lowercase32): " + (MD5Result.ToLower() ?? "NULL") + "\r\n"
                + "MD5(Uppercase16): " + (MD5Result.Substring(8, 16) ?? "NULL") + "\r\n"
                + "MD5(Lowercase16): " + (MD5Result.ToLower().Substring(8, 16) ?? "NULL") + "\r\n\r\n"
                + "SHA1: " + (SHA1Result ?? "NULL") + "\r\n"
                + "SHA256: " + (SHA256Result ?? "NULL") + "\r\n\r\n"
                + "SHA384: " + (SHA384Result ?? "NULL") + "\r\n\r\n"
                + "SHA512: " + (SHA512Result ?? "NULL");
        }

        private void FileHash(object sender, DragEventArgs e)
        {

        }
    }
}

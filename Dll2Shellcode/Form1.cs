using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Dll2Shellcode
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Dll Files(*.dll)|*.dll|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDll.Text = ofd.FileName;
            }
        }

        private void BtnBuild_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDll.Text.Length == 0 || !File.Exists(txtDll.Text))
                {
                    txtDll.Focus();
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Bin Files(*.bin)|*.bin|All Files(*.*)|*.*";
                sfd.FileName = Path.GetFileNameWithoutExtension(txtDll.Text);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    byte[] userData = new byte[] { };
                    if (txtArgument.Text.Length > 0)
                        userData = Encoding.Default.GetBytes(txtArgument.Text + "\0");

                    byte[] sc = null;
                    if (txtFunction.Text.Length > 0)
                        sc = sRDI.ConvertToShellcode(File.ReadAllBytes(txtDll.Text), txtFunction.Text, userData, 0);
                    else
                        sc = sRDI.ConvertToShellcode(File.ReadAllBytes(txtDll.Text), 0, userData, 0);

                    File.WriteAllBytes(sfd.FileName, sc);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
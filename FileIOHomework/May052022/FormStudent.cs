using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp
{
    public partial class FormStudent : Form
    {
        FileStream fs;
        public FormStudent()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter br = new BinaryWriter(fs);
                br.Write(Convert.ToInt32(txtRollNo.Text));
                br.Write(txtName.Text);
                br.Write(float.Parse(txtPerc.Text));
                br.Write(txtStream.Text);
                br.Write(txtCity.Text);
                br.Close();
                MessageBox.Show("Done");
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStream.Clear();
            txtRollNo.Clear();
            txtName.Clear();
            txtPerc.Clear();
            txtCity.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtRollNo.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtPerc.Text = br.ReadSingle().ToString();
                txtStream.Text = br.ReadString();
                txtCity.Text = br.ReadString();
                br.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}

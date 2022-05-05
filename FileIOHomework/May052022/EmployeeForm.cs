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

namespace FileIOHomework.May052022
{
    public partial class EmployeeForm : Form
    {
        FileStream fs;   
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder\SecondFile.txt";
                if(File.Exists(path))
                {
                    MessageBox.Show("File Already Exists!");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\SecondFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(byte.Parse(txtEmpID.Text));
                bw.Write(txtEmpName.Text);
                bw.Write(txtEmpDesg.Text);
                bw.Write(int.Parse(txtEmpSal.Text));
                bw.Write(txtEmpDep.Text);
                bw.Close();
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\SecondFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtEmpID.Text = br.ReadByte().ToString();
                txtEmpName.Text = br.ReadString();
                txtEmpDesg.Text = br.ReadString();
                txtEmpSal.Text = br.ReadInt32().ToString();
                txtEmpDep.Text = br.ReadString();
                br.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpID.Clear();
            txtEmpName.Clear();
            txtEmpDesg.Clear();
            txtEmpSal.Clear();
            txtEmpDep.Clear();
        }
    }
}

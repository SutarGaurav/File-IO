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
    
    public partial class Form3 : Form
    {
        FileStream fs;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\testFolder\FirstFile.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File already exist");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder Already Exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtDepID.Text);
                string nm = txtDepName.Text;
                string lctn = txtLocation.Text;
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);                
                bw.Write(nm);
                bw.Write(lctn);                
                MessageBox.Show("Done!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtDepID.Text = br.ReadInt32().ToString();
                txtDepName.Text = br.ReadString();
                txtLocation.Text = br.ReadString();
                br.Close();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
        
    }
}

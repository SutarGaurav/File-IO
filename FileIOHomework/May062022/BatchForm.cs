using System;
using System.Windows.Forms;
using System.IO;

namespace FileIOHomework.May062022
{
    public partial class BatchForm : Form
    {
        FileStream fs;
        public BatchForm()
        {
            InitializeComponent();
        }
        private void btnBinaryWriter_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\Batch.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(fs);
                writer.Write(byte.Parse(txtBatchId.Text));
                writer.Write(txtName.Text);
                writer.Write(txtStartDate.Text);
                writer.Write(txtEndDate.Text);
                writer.Write(txtLocation.Text);
                writer.Write(txtTrainerName.Text);
                writer.Close();
                MessageBox.Show("Done!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
        private void btnBinaryReader_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\Batch.txt", FileMode.Open, FileAccess.Read);
                BinaryReader binaryreader = new BinaryReader(fs);
                txtBatchId.Text = binaryreader.ReadByte().ToString();
                txtName.Text = binaryreader.ReadString();
                txtStartDate.Text = binaryreader.ReadString();
                txtEndDate.Text = binaryreader.ReadString();
                txtLocation.Text = binaryreader.ReadString();
                txtTrainerName.Text = binaryreader.ReadString();
                binaryreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBatchId.Clear();
            txtName.Clear();
            txtStartDate.Clear();
            txtEndDate.Clear();
            txtLocation.Clear();
            txtTrainerName.Clear();
        }
    }
}

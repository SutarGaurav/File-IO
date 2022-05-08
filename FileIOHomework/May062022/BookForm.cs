using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;
using System.IO;
namespace FileIOHomework.May062022
{
    public partial class BookForm : Form
    {
        FileStream fs;
        public BookForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtAuthorName.Clear();
            txtPrice.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = int.Parse(txtId.Text);
                book.Name = txtName.Text;
                book.AuthorName = txtAuthorName.Text;
                book.Price = int.Parse(txtPrice.Text);
                fs = new FileStream(@"D:\TestFolder\BookBinary", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, book);
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

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:\TestFolder\BookBinary", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                book = (Book)binary.Deserialize(fs);
                txtId.Text = book.Id.ToString();
                txtName.Text = book.Name;
                txtAuthorName.Text = book.AuthorName;
                txtPrice.Text = book.Price.ToString();
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

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = int.Parse(txtId.Text);
                book.Name = txtName.Text;
                book.AuthorName = txtAuthorName.Text;
                book.Price = int.Parse(txtPrice.Text);
                fs = new FileStream(@"D:\TestFolder\BookSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, book);
                MessageBox.Show("Done!");
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

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:\TestFolder\BookSOAP", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                book = (Book)soap.Deserialize(fs);
                txtId.Text = book.Id.ToString();
                txtName.Text = book.Name;
                txtAuthorName.Text = book.AuthorName;
                txtPrice.Text = book.Price.ToString();
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

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = int.Parse(txtId.Text);
                book.Name = txtName.Text;
                book.AuthorName = txtAuthorName.Text;
                book.Price = int.Parse(txtPrice.Text);
                fs = new FileStream(@"D:\TestFolder\BookXML", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                xml.Serialize(fs, book);
                MessageBox.Show("Done!");
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

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:\TestFolder\BookXML", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                book = (Book)xml.Deserialize(fs);
                txtId.Text = book.Id.ToString();
                txtName.Text = book.Name;
                txtAuthorName.Text = book.AuthorName;
                txtPrice.Text = book.Price.ToString();
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

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = int.Parse(txtId.Text);
                book.Name = txtName.Text;
                book.AuthorName = txtAuthorName.Text;
                book.Price = int.Parse(txtPrice.Text);
                fs = new FileStream(@"D:\TestFolder\BookJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, book);
                MessageBox.Show("Done!");
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

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:\TestFolder\BookJson", FileMode.Open, FileAccess.Read);
                book = JsonSerializer.Deserialize<Book>(fs);
                txtId.Text = book.Id.ToString();
                txtName.Text = book.Name;
                txtAuthorName.Text = book.AuthorName;
                txtPrice.Text = book.Price.ToString();
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
    }
}

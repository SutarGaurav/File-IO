using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Xml.Serialization;
using System.IO;


namespace FileIOHomework.May062022
{
    public partial class ProductForm : Form
    {
        FileStream fs;
        public ProductForm()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtCategory.Clear();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\ProductBinary", FileMode.Create, FileAccess.Write);
                ProductClass product1 = new ProductClass();
                product1.Id = int.Parse(txtId.Text);
                product1.Name = txtName.Text;
                product1.Price = int.Parse(txtPrice.Text);
                product1.Catergory = txtCategory.Text;
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, product1);
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
                ProductClass product1 = new ProductClass();
                fs = new FileStream(@"D:\TestFolder\ProductBinary", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                product1 = (ProductClass)binary.Deserialize(fs);
                txtId.Text = product1.Id.ToString();
                txtName.Text = product1.Name;
                txtPrice.Text = product1.Price.ToString();
                txtCategory.Text = product1.Catergory;                
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
                ProductClass product2 = new ProductClass();
                product2.Id = int.Parse(txtId.Text);
                product2.Name = txtName.Text;
                product2.Price = int.Parse(txtPrice.Text);
                product2.Catergory = txtCategory.Text;
                fs = new FileStream(@"D:\TestFolder\ProductSOAP", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, product2);                
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
                ProductClass product2 = new ProductClass();
                fs = new FileStream(@"D:\TestFolder\ProductSOAP", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                product2 = (ProductClass)soap.Deserialize(fs);
                txtId.Text = product2.Id.ToString();
                txtName.Text = product2.Name;
                txtPrice.Text = product2.Price.ToString();
                txtCategory.Text = product2.Catergory;
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
                ProductClass p3 = new ProductClass();
                p3.Id = int.Parse(txtId.Text);
                p3.Name = txtName.Text;
                p3.Price = int.Parse(txtPrice.Text);
                p3.Catergory = txtCategory.Text;
                fs = new FileStream(@"D:\TestFolder\ProductXML", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(ProductClass));
                xml.Serialize(fs, p3);
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
                ProductClass p3 = new ProductClass();
                fs = new FileStream(@"D:\TestFolder\ProductXML", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(ProductClass));
                p3 = (ProductClass)xml.Deserialize(fs);
                txtId.Text = p3.Id.ToString();
                txtName.Text = p3.Name;
                txtPrice.Text = p3.Price.ToString();
                txtCategory.Text = p3.Catergory;
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
                ProductClass p4 = new ProductClass();
                p4.Id = int.Parse(txtId.Text);
                p4.Name = txtName.Text;
                p4.Price = int.Parse(txtPrice.Text);
                p4.Catergory = txtCategory.Text;
                fs = new FileStream(@"D:\TestFolder\ProductJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, p4);
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
                ProductClass p4 = new ProductClass();
                fs = new FileStream(@"D:\TestFolder\ProductJson", FileMode.Open, FileAccess.Read);
                p4 = JsonSerializer.Deserialize<ProductClass>(fs);
                txtId.Text = p4.Id.ToString();
                txtName.Text = p4.Name;
                txtPrice.Text = p4.Price.ToString();
                txtCategory.Text = p4.Catergory;
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

using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using WindowsFormsApp.May062022;
using System.Xml.Serialization;


namespace FileIO.May062022
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
                bw.Write(uint.Parse(txtEmpID.Text));
                bw.Write(txtEmpName.Text);
                bw.Write(txtEmpDesg.Text);
                bw.Write(uint.Parse(txtEmpSal.Text));
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
                txtEmpID.Text = br.ReadUInt32().ToString();
                txtEmpName.Text = br.ReadString();
                txtEmpDesg.Text = br.ReadString();
                txtEmpSal.Text = br.ReadUInt32().ToString();
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

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtEmpID.Text);
                emp.Name = txtEmpName.Text;
                emp.Designation = txtEmpDesg.Text;
                emp.Salary = Convert.ToInt32(txtEmpSal.Text);
                emp.Department = txtEmpDep.Text;
                fs = new FileStream(@"D:\TestFolder\Employee", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, emp);
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
                Employee emp = new Employee();
                fs = new FileStream(@"D:\TestFolder\Employee", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                emp = (Employee)binary.Deserialize(fs);
                txtEmpID.Text = emp.Id.ToString();
                txtEmpName.Text = emp.Name;
                txtEmpDesg.Text = emp.Designation;
                txtEmpSal.Text = emp.Salary.ToString();
                txtEmpDep.Text = emp.Department;                
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

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtEmpID.Text);
                emp.Name = txtEmpName.Text;
                emp.Designation = txtEmpDesg.Text;
                emp.Salary = Convert.ToInt32(txtEmpSal.Text);
                emp.Department = txtEmpDep.Text;
                fs = new FileStream(@"D:\TestFolder\EmployeeXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                xml.Serialize(fs, emp);
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

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                fs = new FileStream(@"D:\TestFolder\EmployeeXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml =  new XmlSerializer(typeof(Employee));
                emp = (Employee)xml.Deserialize(fs);
                txtEmpID.Text = emp.Id.ToString();
                txtEmpName.Text = emp.Name;
                txtEmpDesg.Text = emp.Designation;
                txtEmpSal.Text = emp.Salary.ToString();
                txtEmpDep.Text = emp.Department;
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

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtEmpID.Text);
                emp.Name = txtEmpName.Text;
                emp.Designation = txtEmpDesg.Text;
                emp.Salary = Convert.ToInt32(txtEmpSal.Text);
                emp.Department = txtEmpDep.Text;
                fs = new FileStream(@"D:\TestFolder\EmployeeSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, emp);
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

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                fs = new FileStream(@"D:\TestFolder\EmployeeSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                emp = (Employee)soap.Deserialize(fs);
                txtEmpID.Text = emp.Id.ToString();
                txtEmpName.Text = emp.Name;
                txtEmpDesg.Text = emp.Designation;
                txtEmpSal.Text = emp.Salary.ToString();
                txtEmpDep.Text = emp.Department;
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
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtEmpID.Text);
                emp.Name = txtEmpName.Text;
                emp.Designation = txtEmpDesg.Text;
                emp.Salary = Convert.ToInt32(txtEmpSal.Text);
                emp.Department = txtEmpDep.Text;
                fs = new FileStream(@"D:\TestFolder\EmployeeJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, emp);
                MessageBox.Show("Done");

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
                Employee emp = new Employee();              //also This has a static class.
                fs = new FileStream(@"D:\TestFolder\EmployeeJson", FileMode.Open, FileAccess.Read);
                emp = JsonSerializer.Deserialize<Employee>(fs);               //change here. 
                txtEmpID.Text = emp.Id.ToString();
                txtEmpName.Text = emp.Name;
                txtEmpDesg.Text = emp.Designation;
                txtEmpSal.Text = emp.Salary.ToString();
                txtEmpDep.Text = emp.Department;
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

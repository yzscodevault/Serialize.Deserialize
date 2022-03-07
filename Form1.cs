using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//FileStream, read, write
using System.Text.RegularExpressions;//regex
using System.Runtime.Serialization.Formatters.Binary;//Binary (de)serialization
using System.Runtime.Serialization.Formatters.Soap;//XML (de)serialization
using System.Runtime.Serialization.Json;//JSON (de)serialization

namespace Assignment5._3
{
    public partial class Form1 : Form
    {
        Employee employee = new Employee();
        //add array to append/prepend
        string filePath = @"C:\\filesforProjects\\Assignment5.3.txt";
        string idVldit = @"^\d+$";//^ is first character, \d is for digits, + is >=1 times, * is uint times, $ is last character
        string nameVldit = @"^[a-zA-Z]+(\s+[a-z,A-Z])*?$";
        string addrVldit = @"^[\,\sa-zA-Z0-9.-]+$";
        public Form1()
        {
            InitializeComponent();
        }
        public bool ValidationandMsg()//validate user input and display error message if input is invalid
        {
            bool ifNotEmpty = (txbxAddress.Text != string.Empty) && (txbxID.Text != string.Empty) && (txbxName.Text != string.Empty);
            bool ifEidVl= Regex.IsMatch(txbxID.Text, idVldit);
            bool ifENameVl= Regex.IsMatch(txbxName.Text, nameVldit);
            bool ifEAddressVl= Regex.IsMatch(txbxAddress.Text, addrVldit);
            if (ifNotEmpty)
            {
                if (ifEAddressVl)
                {
                    if (ifENameVl)
                    {
                        if (ifEidVl)
                        {
                            employee.Eid = Convert.ToInt32(txbxID.Text);
                            employee.EName = txbxName.Text;
                            employee.Address = txbxAddress.Text;
                            return true;
                        }
                        else { txbxID.Clear(); MessageBox.Show("ID numbers only contain digits!", "ID number format error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
                    }
                    else { txbxName.Clear(); MessageBox.Show("Names only contain characters and space", "Name format error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
                }
                else { txbxAddress.Clear(); MessageBox.Show("Address only contain characters, digits, dot, hyphen, and space", "Address format error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            }
            else { MessageBox.Show("Not all blanks are filled", "Empty Fills Found", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
        }
        public void ClearFills()//clear fills after each serialization button pressed
        {
            txbxAddress.Clear();
            txbxID.Clear();
            txbxName.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {            
        }

        private void btnBiSirl_Click(object sender, EventArgs e)
        {
            if (ValidationandMsg())
            {
                FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, employee);
                fileStream.Close();
                txbxOutput.Text = "Binary serialization succeed!";
                ClearFills();
            }
        }

        private void btnBiDeSirl_Click(object sender, EventArgs e)
        {
            try { FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Employee employee = binaryFormatter.Deserialize(fileStream) as Employee;
            fileStream.Close();
            txbxOutput.Text = $"Binary Deserialization output:\r\nEmployee ID#: {employee.Eid}\r\nEmployee Name: {employee.EName}\r\nEmployee Address: {employee.Address}"; }
            catch { MessageBox.Show("Need to conduct Binary Serialization first", "Binary Deserialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnXMLSirl_Click(object sender, EventArgs e)
        {
            //Employee employee = new Employee();
            if (ValidationandMsg())
            {
                FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fileStream, employee);
                fileStream.Close();
                txbxOutput.Text = "XML serialization succeed!";
                ClearFills();
            }
        }

        private void btnXMLDeSirl_Click(object sender, EventArgs e)
        {
            try { Employee employee = new Employee();
            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter soapFormatter = new SoapFormatter();
            employee = (Employee)soapFormatter.Deserialize(fileStream);
            fileStream.Close();
            txbxOutput.Text=$"XML/SOAP Deserialization output:\r\nEmployee ID#: {employee.Eid}\r\nEmployee Name: {employee.EName}\r\nEmployee Address: {employee.Address}"; }
            catch { MessageBox.Show("Need to conduct XML Serialization first","XML Deserialization Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void btnJSONSirl_Click(object sender, EventArgs e)
        {
            if (ValidationandMsg())
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
                DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(employee.GetType());
                dataContractJsonSerializer.WriteObject(fileStream, employee);
                fileStream.Close();
                txbxOutput.Text = "JSON serialization succeed!";
                ClearFills();
            }
        }

        private void btnJSONDeSirl_Click(object sender, EventArgs e)
        {
            try { Employee employee = new Employee();
            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(employee.GetType());
            employee = dataContractJsonSerializer.ReadObject(fileStream) as Employee;
            fileStream.Close();
            txbxOutput.Text = $"JSON Deserialization output:\r\nEmployee ID#: {employee.Eid}\r\nEmployee Name: {employee.EName}\r\nEmployee Address: {employee.Address}"; }
            catch { MessageBox.Show("Need to conduct JSON Serialization first", "JSON Deserialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

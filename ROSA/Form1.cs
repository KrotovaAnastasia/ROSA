using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ROSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBoxEmployee.Visible = false;
            tableEmployee.Visible = false;
            tableEmployee.ReadOnly = true;
        }

        string Load = "C:\\Users\\anast\\Desktop\\тестовое задание\\ROSA\\ROSA\\Certificate.xml";
        public void AddCertificate() //Запись данных сотрудника в xml
        {
            
            XDocument doc = XDocument.Load(Load);
            XElement root = doc.Element("Certificates");
            root.Add(new XElement("UserCertificate",
                new XElement("UserName", textBoxNameUser.Text),
                new XElement("Certificate", listBoxNameCertificate.Text),
                new XElement("Quantity", numericUpDownCountCertificate.Text),
                new XElement("Reason", textBoxReason.Text),
                new XElement("Status", "Создан")));
            doc.Save(Load);
            FillTable();
        }

        public void FillTable() //заполнение таблицы
        {
            XDocument doc = XDocument.Load (Load);
            tableEmployee.Rows.Clear();
            var certificates = from r in doc.Descendants("UserCertificate")
                               select new
                               {
                                   UserName = r.Element("UserName").Value,
                                   Certificate = r.Element("Certificate").Value,
                                   Quantity = r.Element("Quantity").Value,
                                   Reason = r.Element("Reason").Value,
                                   Status = r.Element("Status").Value
                               };
            foreach (var cert in certificates)
            {
                if (radioButtonEmployee.Checked)
                    if (cert.UserName == textBoxNameUser.Text)
                        tableEmployee.Rows.Add(cert.UserName, cert.Certificate, cert.Quantity, cert.Reason, cert.Status);
                if (radioButtonAccountant.Checked)
                    tableEmployee.Rows.Add(cert.UserName, cert.Certificate, cert.Quantity, cert.Reason, cert.Status);
            }    
                
        }

        private void ButtonRequest_Click(object sender, EventArgs e) //Кнопка отправки запроса
        {
            AddCertificate();
            //Employee employee = new Employee();
            //employee.SendRequest(textBoxNameUser.Text);
        }


        private void ButtonOpenTable_Click(object sender, EventArgs e)
        {
            if (textBoxNameUser.Text != null)
                FillTable();
        }

        private void ListBoxNameCertificate_SelectedIndexChanged(object sender, EventArgs e) // Активация поля "Другое"
        {
            if (listBoxNameCertificate.SelectedItems != null)
            {
                if (listBoxNameCertificate.SelectedItem.ToString() == "Другое")
                {
                    textBoxNameCertificate.Enabled = true;  
                    textBoxNameCertificate.Focus();         
                }
                else
                {
                    textBoxNameCertificate.Enabled = false; 
                    textBoxNameCertificate.Text = "Другое";
                }
            }
        }

        private void RadioButtonEmployee_Click(object sender, EventArgs e)
        {
            groupBoxEmployee.Visible = true;
            tableEmployee.ReadOnly = true;
            tableEmployee.Visible = true;
        }

        private void RadioButtonAccountant_Click(object sender, EventArgs e)
        {
            groupBoxEmployee.Visible = false;
            tableEmployee.ReadOnly = false;
            tableEmployee.Visible = true;
            FillTable();
        }
    }
}


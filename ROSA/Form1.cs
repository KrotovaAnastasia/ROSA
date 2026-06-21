using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace ROSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBoxEmployee.Visible = false;
            tableCertificate.Visible = false;
            tableCertificate.ReadOnly = true;
            tableCertificate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tableCertificate.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        readonly string fileXml = "Certificate.xml"; //Файл для хранения запросов

        public void FillTable() //Заполнение таблицы
        {
            int flag = 0; //Флаг чтобы опредлеить есть ли в таблице хотя бы одна запись
            XDocument doc = XDocument.Load(fileXml);
            tableCertificate.Rows.Clear(); 
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
                //Заполннеие таблицы нужного работника
                if (radioButtonEmployee.Checked && cert.UserName == textBoxNameUser.Text.Trim())
                {
                    tableCertificate.Rows.Add(cert.UserName, cert.Certificate, cert.Quantity, cert.Reason, cert.Status);
                    flag = 1;
                }
                if (radioButtonAccountant.Checked) //Заполнение таблицы бухгатера
                {
                    tableCertificate.Rows.Add(cert.UserName, cert.Certificate, cert.Quantity, cert.Reason, cert.Status);
                    flag = 1;
                }                        
            }
            if (flag == 0) MessageBox.Show("Нет действующих запросов");
        }

        public void CreatApplication() //Создание заявки для справки 
        {
            //Проверка на корректное запление всех полей 
            if (!string.IsNullOrWhiteSpace(textBoxNameUser.Text.Trim())
                && Regex.IsMatch(textBoxNameUser.Text, @"^[а-яА-ЯёЁ ]")
                && !string.IsNullOrWhiteSpace(textBoxReason.Text)
                && Regex.IsMatch(textBoxReason.Text, @"[^0-9]")
                && listBoxNameCertificate.SelectedItem != null
                && !string.IsNullOrWhiteSpace(textBoxNameCertificate.Text)
                && Regex.IsMatch(textBoxNameCertificate.Text, @"[^0-9]"))
            {
                string certificat;
                XDocument doc = XDocument.Load(fileXml);
                XElement root = doc.Element("UserCertificates");
                //Проверка какая справка нужна
                if (listBoxNameCertificate.SelectedItem.ToString() == "Другое")
                    certificat = textBoxNameCertificate.Text;
                else certificat = listBoxNameCertificate.SelectedItem.ToString();
                //Запись данных в xml
                DataRecord(root, textBoxNameUser.Text.Trim(), certificat,
                    numericUpDownCountCertificate.Text, textBoxReason.Text, "Создан");
                doc.Save(fileXml);
                FillTable(); //Заполнние таблицы
                ClearEmployee(); //Очистка полей Работника
            }
            else MessageBox.Show("Заполнены не все поля или заполнены некорректно");
        }

        public void UpdateData() //Обновление данных после изменения статуса стправки бухгалтером 
        {
            XElement root = new XElement("UserCertificates");
            foreach (DataGridViewRow row in tableCertificate.Rows)
            {
                if (row.IsNewRow) continue;
                //Если стутус "Закрыт", то поле не сохраняется
                if (String.Compare(row.Cells["Status"].Value.ToString(), "Закрыт") != 0)
                    //Запись данных в xml
                    DataRecord(root, row.Cells["UserName"].Value.ToString(), 
                        row.Cells["Certificate"].Value.ToString(),
                        row.Cells["Quantity"].Value.ToString(),
                        row.Cells["Reason"].Value.ToString(),
                        row.Cells["Status"].Value.ToString());                
            }
            XDocument doc = new XDocument(root);
            doc.Save(fileXml);
            FillTable(); //Заполнние таблицы
        }

        //Запись данных в xml
        public XElement DataRecord(XElement root, string name, 
            string сertificate,string quantity, string reason, string status)
        {
            root.Add(new XElement("UserCertificate",
                    new XElement("UserName", name),
                    new XElement("Certificate", сertificate),
                    new XElement("Quantity", quantity),
                    new XElement("Reason", reason),
                    new XElement("Status", status)));
            return root;
        }

        public void ClearEmployee() //Очиста полей Работника
        {
            listBoxNameCertificate.SelectedIndex = 0;
            textBoxNameCertificate.Text = "Другое";
            numericUpDownCountCertificate.Value = 1;
            textBoxReason.Clear();
        }

        //Открытие полей для бухгатера после авторизации
        public void OpenAccountant()
        {
            radioButtonAccountant.Checked = true;
            groupBoxEmployee.Visible = false;
            tableCertificate.ReadOnly = false;
            tableCertificate.Visible = true;
            buttonUpdateDate.Visible = true;
            textBoxNameUser.Clear();
            ClearEmployee();
            FillTable(); 
        }

        //Методы связанные с работой форм

        //Кнопка для создания запроса на подготовку справки Бухгалтеру
        private void ButtonRequest_Click(object sender, EventArgs e) 
        {
            CreatApplication();
        }

        //Згурзить таблицу запросов для пользователя
        private void ButtonOpenTable_Click(object sender, EventArgs e)  
        {
            if (!string.IsNullOrWhiteSpace(textBoxNameUser.Text))
                FillTable();
            else MessageBox.Show("Заполните имя пользователя");
        }

        // Активация текстового поля "Другое"
        private void ListBoxNameCertificate_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (listBoxNameCertificate.SelectedItems != null) //Выбран ли пункт в поле справки
            {
                if (listBoxNameCertificate.SelectedItem.ToString() == "Другое") //Выбрана справка "Другое"
                {
                    textBoxNameCertificate.Enabled = true;
                    textBoxNameCertificate.Text = "";
                    textBoxNameCertificate.Focus();         
                }
                else
                {
                    textBoxNameCertificate.Enabled = false; 
                    textBoxNameCertificate.Text = "Другое";
                }
            }
        }

        //Открытие полей для работника при нажатии на соответсвующу радиокнопку
        private void RadioButtonEmployee_Click(object sender, EventArgs e) 
        {
            groupBoxEmployee.Visible = true;
            tableCertificate.ReadOnly = true;
            tableCertificate.Visible = true;
            buttonUpdateDate.Visible = false;
            tableCertificate.Rows.Clear();
        }

        //Открытие формы для авторизации бухгалтера при нажатии на соответсвующу радиокнопку
        private void RadioButtonAccountant_Click(object sender, EventArgs e) 
        {
            radioButtonEmployee.Checked = true;
            AuthorizationForm form = new AuthorizationForm(this);
            form.ShowDialog();
        }

        //Запуск обновления данных по запросу через бухгалетра после обновления стутуса
        private void ButtonUpdateDate_Click(object sender, EventArgs e) 
        {
            UpdateData();
        }

    }
}


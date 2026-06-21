using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ROSA
{
    public partial class AuthorizationForm : Form
    {
        readonly Form1 mainform; //Ссылка на главную форму
        readonly string fileXml = "Users.xml"; //Файл для хранения данных бухгалтера

        public AuthorizationForm(Form1 form1)
        {
            InitializeComponent();
            mainform = form1;
        }

        //Активация кнопки "Войти"
        private void ButtonAuthorization_Click(object sender, EventArgs e)
        {
            bool resultAuthorization = false; //Перемнная, чтобы знать получилось ли авторизоваться
            //Проверка, что поля для авторизации заполнены
            if (!string.IsNullOrWhiteSpace(textBoxUserAuthorization.Text.Trim()) 
                && !string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                resultAuthorization = Authorization(textBoxUserAuthorization.Text.Trim(), textBoxPassword.Text);
            }
            //Проверка прошла ли авторизация
            if (resultAuthorization == true)
            {
                this.Close();
                mainform.OpenAccountant();
            }
            else MessageBox.Show("Проверьте правильность вводимых данных");
        } 

        //Авторизация
        public bool Authorization(string userName, string password)
        {
            string hashedPassword = HashPassword(password); //Кодировка пароля
            XDocument doc = XDocument.Load(fileXml);
            //Поиск подходящего пользователя в документе
            var userElement = doc.Descendants("User")
                    .FirstOrDefault(u => string.Equals(
                        (string)u.Element("Name"), userName, StringComparison.OrdinalIgnoreCase) &&
                        (string)u.Element("Password") == hashedPassword
                    );
            //Проверка найден ли пользователь
            if (userElement != null)
                return true;
            else return false;

        }

        //Кодировка пароля 
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}

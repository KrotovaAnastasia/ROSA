using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ROSA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            MadeFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void MadeFile()
        {
            //Создание файла для хранения данных о запросах
            string fileCertificate = "Certificate.xml";
            try
            {
                if (!File.Exists(fileCertificate)) //Проверка на создание файла, если его нет
                {
                    string defaultXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                                        "\n<UserCertificates>" +
                                        "\n  <UserCertificate>\n     <UserName>Ильин Илья Ильич</UserName>" +
                                        "\n    <Certificate>Место работы</Certificate>\n    <Quantity>1</Quantity>" +
                                        "\n    <Reason>Для налоговой</Reason>\n    <Status>Готов</Status>" +
                                        "\n  </UserCertificate>\n</UserCertificates>";

                    File.WriteAllText(fileCertificate, defaultXml);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при работе с файлом данных");
            }

            //Создание файла пользователей
            string fileUser = "Users.xml";
            try
            {
                if (!File.Exists(fileUser)) //Проверка на создание файла, если его нет
                {
                    string defaultXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                                        "\n<Users>" +
                                        "\n  <User>\n     <Name>Петров Петр Петрович</Name>" +
                                        "\n  <Profession>Бухгалтер</Profession>" +
                                        "\n  <Password>1880fffb1269b405da6b0fb9d1b155e94c2879fdc77e37a399ba1cca23d0876a</Password>" +
                                        "\n  </User>\n</Users>";

                    File.WriteAllText(fileUser, defaultXml);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при работе с файлом данных");
            }
        }
    }
}
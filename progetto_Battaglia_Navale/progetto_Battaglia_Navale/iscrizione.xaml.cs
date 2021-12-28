using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace progetto_Battaglia_Navale
{
    /// <summary>
    /// Logica di interazione per iscrizione.xaml
    /// </summary>
    public partial class iscrizione : Window
    {
        Utente utente = new Utente();
        private string fileName = "utenti.txt";
        public iscrizione()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/progetto_Battaglia_Navale;component/battaglia-navale.png")));
        }

        private void btnIscrizione_Click(object sender, RoutedEventArgs e)
        {
            utente = new Utente();
            utente.Nome = txtNome.Text;
            utente.NomeUtente = txtNomeUtente.Text;
            utente.Cognome = txtCognome.Text;
            utente.Email = txtEmail.Text;
            utente.Password = txtPassword.Text;

            if (txtNome.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtCognome.Text != ""&& txtNomeUtente.Text != "")
            { 
                Scrittura();
                //implememtare classe con CSV per scrivere e leggere da file

                //try
                //{
                //    SmtpClient mySmtpClient = new SmtpClient("my.smtp.exampleserver.net");

                //    // set smtp-client with basicAuthentication
                //    mySmtpClient.UseDefaultCredentials = false;
                //    System.Net.NetworkCredential basicAuthenticationInfo = new System.Net.NetworkCredential("username", "password");
                //    mySmtpClient.Credentials = basicAuthenticationInfo;

                //    // add from,to mailaddresses
                //    MailAddress from = new MailAddress("battagliaNavale@gmail.com", "TestFromName");
                //    MailAddress to = new MailAddress(txtEmail.Text, "TestToName");
                //    MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

                //    // add ReplyTo
                //    MailAddress replyTo = new MailAddress("battagliaNavale@gmail.com");
                //    myMail.ReplyToList.Add(replyTo);

                //    // set subject and encoding
                //    myMail.Subject = "Your registration is confirmed." + "\n" + "Name: " + txtNome + "\n" + "Surname: " + txtNome;
                //    myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                //    // set body-message and encoding
                //    myMail.Body = "<b>Test Mail</b><br>using <b>HTML</b>.";
                //    myMail.BodyEncoding = System.Text.Encoding.UTF8;
                //    // text or html
                //    myMail.IsBodyHtml = true;

                //    mySmtpClient.Send(myMail);
                //}
                //catch (SmtpException ex)
                //{
                //    throw new ApplicationException
                //      ("SmtpException has occured: " + ex.Message);
                //}
                //catch (Exception ex)
                //{
                //    throw ex;
                //}

            }
            else
                MessageBox.Show("Errore nella registrazione.\nAssicurarsi di aver inserito tutti i campi e riprovare.", "Error");

            MainWindow finestra2 = new MainWindow();
            finestra2.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow finestra2 = new MainWindow();
            finestra2.Show();
            this.Close();
        }
        private void Scrittura()
        {
            string cont=utente.ReadUtenti(fileName);
            if(cont != "")
            File.WriteAllText(fileName, cont + "\n" + utente.ToCSV());
            else
                File.WriteAllText(fileName, utente.ToCSV());
            
            MessageBox.Show("Registrazione effettuata con successo", "Completed!");

        }
    }
}

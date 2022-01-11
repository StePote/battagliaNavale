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
                if (utente.controlloDuplicati(txtEmail.Text, txtNomeUtente.Text) == true)
                    MessageBox.Show("Nome utente e password già presenti", "Error");
                else
                Scrittura();
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

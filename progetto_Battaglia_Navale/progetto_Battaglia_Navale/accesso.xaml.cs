using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Logica di interazione per accesso.xaml
    /// </summary>
    public partial class accesso : Window
    {
        string nomeUtente;
        string psw;
        public accesso()
        {
            InitializeComponent();
            nomeUtente = "";
            psw="";
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/progetto_Battaglia_Navale;component/battaglia-navale.png")));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lettura())
            {
                MainWindow finestra2 = new MainWindow(txtNomeUtente.Text);
                MainWindow finestra = new MainWindow();
                finestra.Show();
                this.Close();
            }
            else
                MessageBox.Show("Nome utente o password errati.", "Error");

        }

        public bool lettura()
        {
            bool controllo=false;
            string passw = password.Password;
            foreach (string line in System.IO.File.ReadLines(@"utenti.txt"))
            {
                if (line != "")
                {
                    string[] str = line.Split(';');
                    nomeUtente = str[0];
                    psw = str[4];
                    if(nomeUtente== txtNomeUtente.Text && psw == passw)
                    {
                        controllo = true;
                    }
                }
            }
            return controllo;
        }

        private void BtnIndietro_Click(object sender, RoutedEventArgs e)
        {
                MainWindow finestra2 = new MainWindow();
                finestra2.Show();
                this.Close();
        }
    }
}

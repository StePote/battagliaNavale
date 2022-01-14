using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace progetto_Battaglia_Navale
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Invia ti;
        Ricevi tr;
        string nomeUtente = "";
        public MainWindow()
        {
            //btnInizia.IsEnabled = false;
            InitializeComponent();
            ti = new Invia();
            tr = new Ricevi();
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/progetto_Battaglia_Navale;component/battaglia-navale.png")));
        }
        public MainWindow(string _nomeUtente)
        {
            nomeUtente = _nomeUtente;
            if (nomeUtente != "")
                MessageBox.Show("Bentornato " + nomeUtente + " !");
            ti.setNomeUtente(nomeUtente);
            tr.setNomeUtente(nomeUtente);
        }
        private void btnInizia_Click(object sender, RoutedEventArgs e)
        {
            if (txtIp.Text != "")
            {
                if (!ti.inviaInvito(txtIp.Text))
                {
                    paginaDiGioco finestra = new paginaDiGioco();
                    finestra.Show();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Inserisci ip avversario","Errore di comunicazione");
        }

        private void btnIscrizione_Click(object sender, RoutedEventArgs e)
        {
            iscrizione finestra = new iscrizione();
            finestra.Show();
            this.Close();
        }

        private void btnAccedi_Click(object sender, RoutedEventArgs e)
        {
            accesso finestra = new accesso();
            finestra.Show();
            this.Close();
        }

        private void btnRiceviInvito_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Attendere avversario...", "Connecting");
            tr.riceviInvito();
        }

        private void btnProva_Click(object sender, RoutedEventArgs e)
        {
            campoBattaglia finestra = new campoBattaglia("");
            finestra.Show();
            this.Close();
        }
    }
}

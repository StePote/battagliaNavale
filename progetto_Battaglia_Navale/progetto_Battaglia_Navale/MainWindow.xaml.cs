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
        ThreadInvia ti;
        ThreadRicevi tr;
        public MainWindow()
        {
            btnInizia.IsEnabled = false;
            InitializeComponent();
            ti = new ThreadInvia();
            tr = new ThreadRicevi();
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/progetto_Battaglia_Navale;component/battaglia-navale.png")));
            
            Thread tRicevi= new Thread(new ThreadStart(tr.ricevi));
            tRicevi.Start();
        }
        private void btnInizia_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Attendere avversario...", "Connecting");
            Thread tInvito = new Thread(new ThreadStart(ti.inviaInvito));
            tInvito.Start();
        }
        private void btnIscrizione_Click(object sender, RoutedEventArgs e)
        {
            iscrizione finestra = new iscrizione();
            finestra.Show();
            this.Close();
        }
    }
}

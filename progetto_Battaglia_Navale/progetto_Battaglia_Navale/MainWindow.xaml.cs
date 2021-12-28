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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace progetto_Battaglia_Navale
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/progetto_Battaglia_Navale;component/battaglia-navale.png")));
        }
        private void btnInizia_Click(object sender, RoutedEventArgs e)
        {
            paginaDiGioco finestra = new paginaDiGioco();
            finestra.Show();
            this.Close();
        }

        private void btnIscrizione_Click(object sender, RoutedEventArgs e)
        {
            iscrizione finestra = new iscrizione();
            finestra.Show();
            this.Close();
        }
    }
}

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
    /// Logica di interazione per paginaDiGioco.xaml
    /// </summary>
    public partial class paginaDiGioco : Window
    {
        public paginaDiGioco()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/progetto_Battaglia_Navale;component/battaglia-navale.png")));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow finestra2 = new MainWindow();
            finestra2.Show();
            this.Close();
        }
    }
}

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
        Button a1 = new Button();
        Button a2 = new Button();
        Button a3 = new Button();
        Button a4 = new Button();
        Button a5 = new Button();
        Button a6 = new Button();
        Button a7 = new Button();
        Button a8 = new Button();
        Button a9 = new Button();
        Button a10 = new Button();

        Button b1 = new Button();
        Button b2 = new Button();
        Button b3 = new Button();
        Button b4 = new Button();
        Button b5 = new Button();
        Button b6 = new Button();
        Button b7 = new Button();
        Button b8 = new Button();
        Button b9 = new Button();
        Button b10 = new Button();

        Button c1 = new Button();
        Button c2 = new Button();
        Button c3 = new Button();
        Button c4 = new Button();
        Button c5 = new Button();
        Button c6 = new Button();
        Button c7 = new Button();
        Button c8 = new Button();
        Button c9 = new Button();
        Button c10 = new Button();

        Button d1 = new Button();
        Button d2 = new Button();
        Button d3 = new Button();
        Button d4 = new Button();
        Button d5 = new Button();
        Button d6 = new Button();
        Button d7 = new Button();
        Button d8 = new Button();
        Button d9 = new Button();
        Button d10 = new Button();

        Button e1 = new Button();
        Button e2 = new Button();
        Button e3 = new Button();
        Button e4 = new Button();
        Button e5 = new Button();
        Button e6 = new Button();
        Button e7 = new Button();
        Button e8 = new Button();
        Button e9 = new Button();
        Button e10 = new Button();

        Button f1 = new Button();
        Button f2 = new Button();
        Button f3 = new Button();
        Button f4 = new Button();
        Button f5 = new Button();
        Button f6 = new Button();
        Button f7 = new Button();
        Button f8 = new Button();
        Button f9 = new Button();
        Button f10 = new Button();

        Button g1 = new Button();
        Button g2 = new Button();
        Button g3 = new Button();
        Button g4 = new Button();
        Button g5 = new Button();
        Button g6 = new Button();
        Button g7 = new Button();
        Button g8 = new Button();
        Button g9 = new Button();
        Button g10 = new Button();

        Button h1 = new Button();
        Button h2 = new Button();
        Button h3 = new Button();
        Button h4 = new Button();
        Button h5 = new Button();
        Button h6 = new Button();
        Button h7 = new Button();
        Button h8 = new Button();
        Button h9 = new Button();
        Button h10 = new Button();

        Button i1 = new Button();
        Button i2 = new Button();
        Button i3 = new Button();
        Button i4 = new Button();
        Button i5 = new Button();
        Button i6 = new Button();
        Button i7 = new Button();
        Button i8 = new Button();
        Button i9 = new Button();
        Button i10 = new Button();

        Button j1 = new Button();
        Button j2 = new Button();
        Button j3 = new Button();
        Button j4 = new Button();
        Button j5 = new Button();
        Button j6 = new Button();
        Button j7 = new Button();
        Button j8 = new Button();
        Button j9 = new Button();
        Button j10 = new Button();
        string NaveScelta;
        string[] VettCacciatorpediniere;
        string[] VettSottomarino1;
        string[] VettSottomarino2;
        string[] VettCorazzate;
        string[] VettPortaerei;
        int countSott;
        string bottoneScelto;
        bool c;
        public paginaDiGioco()
        {
            InitializeComponent();
            campoNavi();
            lblCac.Content = 1;
            lblCor.Content = 1;
            lblPor.Content = 1;
            lblSot.Content = 2;
            NaveScelta = "";
            ButtonsNotEnabled();
            VettCacciatorpediniere = new string[2];
            VettSottomarino1 = new string[3];
            VettSottomarino2 = new string[3];
            VettCorazzate = new string[4];
            VettPortaerei = new string[5];
            countSott = 0;
            btnConferma.IsEnabled = false;
            bottoneScelto = "";
            c = false;
            //this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/progetto_Battaglia_Navale;component/battaglia-navale.png")));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow finestra2 = new MainWindow();
            finestra2.Show();
            this.Close();
        }

        private void campoNavi()
        {
            grid.Width = 500;
            grid.Height = 400;
            grid.HorizontalAlignment = HorizontalAlignment.Left;
            grid.VerticalAlignment = VerticalAlignment.Top;
            grid.ShowGridLines = true;

            ColumnDefinition col1 = new ColumnDefinition();
            ColumnDefinition col2 = new ColumnDefinition();
            ColumnDefinition col3 = new ColumnDefinition();
            ColumnDefinition col4 = new ColumnDefinition();
            ColumnDefinition col5 = new ColumnDefinition();
            ColumnDefinition col6 = new ColumnDefinition();
            ColumnDefinition col7 = new ColumnDefinition();
            ColumnDefinition col8 = new ColumnDefinition();
            ColumnDefinition col9 = new ColumnDefinition();
            ColumnDefinition col10 = new ColumnDefinition();
            ColumnDefinition col11 = new ColumnDefinition();
            grid.ColumnDefinitions.Add(col1);
            grid.ColumnDefinitions.Add(col2);
            grid.ColumnDefinitions.Add(col3);
            grid.ColumnDefinitions.Add(col4);
            grid.ColumnDefinitions.Add(col5);
            grid.ColumnDefinitions.Add(col6);
            grid.ColumnDefinitions.Add(col7);
            grid.ColumnDefinitions.Add(col8);
            grid.ColumnDefinitions.Add(col9);
            grid.ColumnDefinitions.Add(col10);
            grid.ColumnDefinitions.Add(col11);

            RowDefinition r1 = new RowDefinition();
            RowDefinition r2 = new RowDefinition();
            RowDefinition r3 = new RowDefinition();
            RowDefinition r4 = new RowDefinition();
            RowDefinition r5 = new RowDefinition();
            RowDefinition r6 = new RowDefinition();
            RowDefinition r7 = new RowDefinition();
            RowDefinition r8 = new RowDefinition();
            RowDefinition r9 = new RowDefinition();
            RowDefinition r10 = new RowDefinition();
            RowDefinition r11 = new RowDefinition();
            grid.RowDefinitions.Add(r1);
            grid.RowDefinitions.Add(r2);
            grid.RowDefinitions.Add(r3);
            grid.RowDefinitions.Add(r4);
            grid.RowDefinitions.Add(r5);
            grid.RowDefinitions.Add(r6);
            grid.RowDefinitions.Add(r7);
            grid.RowDefinitions.Add(r8);
            grid.RowDefinitions.Add(r9);
            grid.RowDefinitions.Add(r10);
            grid.RowDefinitions.Add(r11);

            setCelleNumerieLettere();
            setButton();
        }

        public void setCelleNumerieLettere()
        {
            TextBlock txt1 = new TextBlock();
            txt1.Text = "1";
            txt1.FontSize = 12;
            txt1.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt1, 1);
            Grid.SetColumn(txt1, 0);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "2";
            txt2.FontSize = 12;
            txt2.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt2, 2);
            Grid.SetColumn(txt2, 0);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "3";
            txt3.FontSize = 12;
            txt3.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt3, 3);
            Grid.SetColumn(txt3, 0);

            TextBlock txt4 = new TextBlock();
            txt4.Text = "4";
            txt4.FontSize = 12;
            txt4.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt4, 4);
            Grid.SetColumn(txt4, 0);

            TextBlock txt5 = new TextBlock();
            txt5.Text = "5";
            txt5.FontSize = 12;
            txt5.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt5, 5);
            Grid.SetColumn(txt5, 0);

            TextBlock txt6 = new TextBlock();
            txt6.Text = "6";
            txt6.FontSize = 12;
            txt6.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt6, 6);
            Grid.SetColumn(txt6, 0);

            TextBlock txt7 = new TextBlock();
            txt7.Text = "7";
            txt7.FontSize = 12;
            txt7.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt7, 7);
            Grid.SetColumn(txt7, 0);

            TextBlock txt8 = new TextBlock();
            txt8.Text = "8";
            txt8.FontSize = 12;
            txt8.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt8, 8);
            Grid.SetColumn(txt8, 0);

            TextBlock txt9 = new TextBlock();
            txt9.Text = "9";
            txt9.FontSize = 12;
            txt9.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt9, 9);
            Grid.SetColumn(txt9, 0);

            TextBlock txt10 = new TextBlock();
            txt10.Text = "10";
            txt10.FontSize = 12;
            txt10.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt10, 10);
            Grid.SetColumn(txt10, 0);



            TextBlock txt11 = new TextBlock();
            txt11.Text = "A";
            txt11.FontSize = 12;
            txt11.FontWeight = FontWeights.Bold;
            txt11.Width = 10;
            Grid.SetRow(txt11, 0);
            Grid.SetColumn(txt11, 1);

            TextBlock txt12 = new TextBlock();
            txt12.Text = "B";
            txt12.FontSize = 12;
            txt12.FontWeight = FontWeights.Bold;
            txt12.Width = 10;
            Grid.SetRow(txt12, 0);
            Grid.SetColumn(txt12, 2);

            TextBlock txt13 = new TextBlock();
            txt13.Text = "C";
            txt13.FontSize = 12;
            txt13.FontWeight = FontWeights.Bold;
            txt13.Width = 10;
            Grid.SetRow(txt13, 0);
            Grid.SetColumn(txt13, 3);

            TextBlock txt14 = new TextBlock();
            txt14.Text = "D";
            txt14.FontSize = 12;
            txt14.FontWeight = FontWeights.Bold;
            txt14.Width = 10;
            Grid.SetRow(txt14, 0);
            Grid.SetColumn(txt14, 4);

            TextBlock txt15 = new TextBlock();
            txt15.Text = "E";
            txt15.FontSize = 12;
            txt15.FontWeight = FontWeights.Bold;
            txt15.Width = 10;
            Grid.SetRow(txt15, 0);
            Grid.SetColumn(txt15, 5);

            TextBlock txt16 = new TextBlock();
            txt16.Text = "F";
            txt16.FontSize = 12;
            txt16.FontWeight = FontWeights.Bold;
            txt16.Width = 10;
            Grid.SetRow(txt16, 0);
            Grid.SetColumn(txt16, 6);

            TextBlock txt17 = new TextBlock();
            txt17.Text = "G";
            txt17.FontSize = 12;
            txt17.FontWeight = FontWeights.Bold;
            txt17.Width = 10;
            Grid.SetRow(txt17, 0);
            Grid.SetColumn(txt17, 7);

            TextBlock txt18 = new TextBlock();
            txt18.Text = "H";
            txt18.FontSize = 12;
            txt18.FontWeight = FontWeights.Bold;
            txt18.Width = 10;
            Grid.SetRow(txt18, 0);
            Grid.SetColumn(txt18, 8);

            TextBlock txt19 = new TextBlock();
            txt19.Text = "I";
            txt19.FontSize = 12;
            txt19.FontWeight = FontWeights.Bold;
            txt19.Width = 10;
            Grid.SetRow(txt19, 0);
            Grid.SetColumn(txt19, 9);

            TextBlock txt20 = new TextBlock();
            txt20.Text = "J";
            txt20.FontSize = 12;
            txt20.FontWeight = FontWeights.Bold;
            txt20.Width = 10;
            Grid.SetRow(txt20, 0);
            Grid.SetColumn(txt20, 10);




            grid.Children.Add(txt1);
            grid.Children.Add(txt2);
            grid.Children.Add(txt3);
            grid.Children.Add(txt4);
            grid.Children.Add(txt5);
            grid.Children.Add(txt6);
            grid.Children.Add(txt7);
            grid.Children.Add(txt8);
            grid.Children.Add(txt9);
            grid.Children.Add(txt10);

            grid.Children.Add(txt11);
            grid.Children.Add(txt12);
            grid.Children.Add(txt13);
            grid.Children.Add(txt14);
            grid.Children.Add(txt15);
            grid.Children.Add(txt16);
            grid.Children.Add(txt17);
            grid.Children.Add(txt18);
            grid.Children.Add(txt19);
            grid.Children.Add(txt20);
        }

        public void setButton()
        {


            a1.Content = "A1";
            a1.FontSize = 12;
            Grid.SetRow(a1, 1);
            Grid.SetColumn(a1, 1);

            a2.Content = "A2";
            a2.FontSize = 12;
            Grid.SetRow(a2, 2);
            Grid.SetColumn(a2, 1);

            a3.Content = "A3";
            a3.FontSize = 12;
            Grid.SetRow(a3, 3);
            Grid.SetColumn(a3, 1);

            a4.Content = "A4";
            a4.FontSize = 12;
            Grid.SetRow(a4, 4);
            Grid.SetColumn(a4, 1);


            a5.Content = "A5";
            a5.FontSize = 12;
            Grid.SetRow(a5, 5);
            Grid.SetColumn(a5, 1);

            a6.Content = "A6";
            a6.FontSize = 12;
            Grid.SetRow(a6, 6);
            Grid.SetColumn(a6, 1);

            a7.Content = "A7";
            a7.FontSize = 12;
            Grid.SetRow(a7, 7);
            Grid.SetColumn(a7, 1);

            a8.Content = "A8";
            a8.FontSize = 12;
            Grid.SetRow(a8, 8);
            Grid.SetColumn(a8, 1);

            a9.Content = "A9";
            a9.FontSize = 12;
            Grid.SetRow(a9, 9);
            Grid.SetColumn(a9, 1);

            a10.Content = "A10";
            a10.FontSize = 12;
            Grid.SetRow(a10, 10);
            Grid.SetColumn(a10, 1);

            grid.Children.Add(a1);
            grid.Children.Add(a2);
            grid.Children.Add(a3);
            grid.Children.Add(a4);
            grid.Children.Add(a5);
            grid.Children.Add(a6);
            grid.Children.Add(a7);
            grid.Children.Add(a8);
            grid.Children.Add(a9);
            grid.Children.Add(a10);





            b1.Content = "B1";
            b1.FontSize = 12;
            Grid.SetRow(b1, 1);
            Grid.SetColumn(b1, 2);

            b2.Content = "B2";
            b2.FontSize = 12;
            Grid.SetRow(b2, 2);
            Grid.SetColumn(b2, 2);

            b3.Content = "B3";
            b3.FontSize = 12;
            Grid.SetRow(b3, 3);
            Grid.SetColumn(b3, 2);

            b4.Content = "B4";
            b4.FontSize = 12;
            Grid.SetRow(b4, 4);
            Grid.SetColumn(b4, 2);

            b5.Content = "B5";
            b5.FontSize = 12;
            Grid.SetRow(b5, 5);
            Grid.SetColumn(b5, 2);

            b6.Content = "B6";
            b6.FontSize = 12;
            Grid.SetRow(b6, 6);
            Grid.SetColumn(b6, 2);

            b7.Content = "B7";
            b7.FontSize = 12;
            Grid.SetRow(b7, 7);
            Grid.SetColumn(b7, 2);

            b8.Content = "B8";
            b8.FontSize = 12;
            Grid.SetRow(b8, 8);
            Grid.SetColumn(b8, 2);

            b9.Content = "B9";
            b9.FontSize = 12;
            Grid.SetRow(b9, 9);
            Grid.SetColumn(b9, 2);

            b10.Content = "B10";
            b10.FontSize = 12;
            Grid.SetRow(b10, 10);
            Grid.SetColumn(b10, 2);

            grid.Children.Add(b1);
            grid.Children.Add(b2);
            grid.Children.Add(b3);
            grid.Children.Add(b4);
            grid.Children.Add(b5);
            grid.Children.Add(b6);
            grid.Children.Add(b7);
            grid.Children.Add(b8);
            grid.Children.Add(b9);
            grid.Children.Add(b10);


            c1.Content = "C1";
            c1.FontSize = 12;
            Grid.SetRow(c1, 1);
            Grid.SetColumn(c1, 3);

            c2.Content = "C2";
            c2.FontSize = 12;
            Grid.SetRow(c2, 2);
            Grid.SetColumn(c2, 3);

            c3.Content = "C3";
            c3.FontSize = 12;
            Grid.SetRow(c3, 3);
            Grid.SetColumn(c3, 3);

            c4.Content = "C4";
            c4.FontSize = 12;
            Grid.SetRow(c4, 4);
            Grid.SetColumn(c4, 3);

            c5.Content = "C5";
            c5.FontSize = 12;
            Grid.SetRow(c5, 5);
            Grid.SetColumn(c5, 3);

            c6.Content = "C6";
            c6.FontSize = 12;
            Grid.SetRow(c6, 6);
            Grid.SetColumn(c6, 3);

            c7.Content = "C7";
            c7.FontSize = 12;
            Grid.SetRow(c7, 7);
            Grid.SetColumn(c7, 3);

            c8.Content = "C8";
            c8.FontSize = 12;
            Grid.SetRow(c8, 8);
            Grid.SetColumn(c8, 3);

            c9.Content = "C9";
            c9.FontSize = 12;
            Grid.SetRow(c9, 9);
            Grid.SetColumn(c9, 3);

            c10.Content = "C10";
            c10.FontSize = 12;
            Grid.SetRow(c10, 10);
            Grid.SetColumn(c10, 3);

            grid.Children.Add(c1);
            grid.Children.Add(c2);
            grid.Children.Add(c3);
            grid.Children.Add(c4);
            grid.Children.Add(c5);
            grid.Children.Add(c6);
            grid.Children.Add(c7);
            grid.Children.Add(c8);
            grid.Children.Add(c9);
            grid.Children.Add(c10);



            d1.Content = "D1";
            d1.FontSize = 12;
            Grid.SetRow(d1, 1);
            Grid.SetColumn(d1, 4);

            d2.Content = "D2";
            d2.FontSize = 12;
            Grid.SetRow(d2, 2);
            Grid.SetColumn(d2, 4);

            d3.Content = "D3";
            d3.FontSize = 12;
            Grid.SetRow(d3, 3);
            Grid.SetColumn(d3, 4);

            d4.Content = "D4";
            d4.FontSize = 12;
            Grid.SetRow(d4, 4);
            Grid.SetColumn(d4, 4);

            d5.Content = "D5";
            d5.FontSize = 12;
            Grid.SetRow(d5, 5);
            Grid.SetColumn(d5, 4);

            d6.Content = "D6";
            d6.FontSize = 12;
            Grid.SetRow(d6, 6);
            Grid.SetColumn(d6, 4);

            d7.Content = "D7";
            d7.FontSize = 12;
            Grid.SetRow(d7, 7);
            Grid.SetColumn(d7, 4);

            d8.Content = "D8";
            d8.FontSize = 12;
            Grid.SetRow(d8, 8);
            Grid.SetColumn(d8, 4);

            d9.Content = "D9";
            d9.FontSize = 12;
            Grid.SetRow(d9, 9);
            Grid.SetColumn(d9, 4);

            d10.Content = "D10";
            d10.FontSize = 12;
            Grid.SetRow(d10, 10);
            Grid.SetColumn(d10, 4);

            grid.Children.Add(d1);
            grid.Children.Add(d2);
            grid.Children.Add(d3);
            grid.Children.Add(d4);
            grid.Children.Add(d5);
            grid.Children.Add(d6);
            grid.Children.Add(d7);
            grid.Children.Add(d8);
            grid.Children.Add(d9);
            grid.Children.Add(d10);


            e1.Content = "E1";
            e1.FontSize = 12;
            Grid.SetRow(e1, 1);
            Grid.SetColumn(e1, 5);

            e2.Content = "E2";
            e2.FontSize = 12;
            Grid.SetRow(e2, 2);
            Grid.SetColumn(e2, 5);

            e3.Content = "E3";
            e3.FontSize = 12;
            Grid.SetRow(e3, 3);
            Grid.SetColumn(e3, 5);

            e4.Content = "E4";
            e4.FontSize = 12;
            Grid.SetRow(e4, 4);
            Grid.SetColumn(e4, 5);

            e5.Content = "E5";
            e5.FontSize = 12;
            Grid.SetRow(e5, 5);
            Grid.SetColumn(e5, 5);

            e6.Content = "E6";
            e6.FontSize = 12;
            Grid.SetRow(e6, 6);
            Grid.SetColumn(e6, 5);

            e7.Content = "E7";
            e7.FontSize = 12;
            Grid.SetRow(e7, 7);
            Grid.SetColumn(e7, 5);

            e8.Content = "E8";
            e8.FontSize = 12;
            Grid.SetRow(e8, 8);
            Grid.SetColumn(e8, 5);

            e9.Content = "E9";
            e9.FontSize = 12;
            Grid.SetRow(e9, 9);
            Grid.SetColumn(e9, 5);

            e10.Content = "E10";
            e10.FontSize = 12;
            Grid.SetRow(e10, 10);
            Grid.SetColumn(e10, 5);

            grid.Children.Add(e1);
            grid.Children.Add(e2);
            grid.Children.Add(e3);
            grid.Children.Add(e4);
            grid.Children.Add(e5);
            grid.Children.Add(e6);
            grid.Children.Add(e7);
            grid.Children.Add(e8);
            grid.Children.Add(e9);
            grid.Children.Add(e10);


            f1.Content = "F1";
            f1.FontSize = 12;
            Grid.SetRow(f1, 1);
            Grid.SetColumn(f1, 6);

            f2.Content = "F2";
            f2.FontSize = 12;
            Grid.SetRow(f2, 2);
            Grid.SetColumn(f2, 6);

            f3.Content = "F3";
            f3.FontSize = 12;
            Grid.SetRow(f3, 3);
            Grid.SetColumn(f3, 6);

            f4.Content = "F4";
            f4.FontSize = 12;
            Grid.SetRow(f4, 4);
            Grid.SetColumn(f4, 6);

            f5.Content = "F5";
            f5.FontSize = 12;
            Grid.SetRow(f5, 5);
            Grid.SetColumn(f5, 6);

            f6.Content = "F6";
            f6.FontSize = 12;
            Grid.SetRow(f6, 6);
            Grid.SetColumn(f6, 6);

            f7.Content = "F7";
            f7.FontSize = 12;
            Grid.SetRow(f7, 7);
            Grid.SetColumn(f7, 6);

            f8.Content = "F8";
            f8.FontSize = 12;
            Grid.SetRow(f8, 8);
            Grid.SetColumn(f8, 6);

            f9.Content = "F9";
            f9.FontSize = 12;
            Grid.SetRow(f9, 9);
            Grid.SetColumn(f9, 6);

            f10.Content = "F10";
            f10.FontSize = 12;
            Grid.SetRow(f10, 10);
            Grid.SetColumn(f10, 6);

            grid.Children.Add(f1);
            grid.Children.Add(f2);
            grid.Children.Add(f3);
            grid.Children.Add(f4);
            grid.Children.Add(f5);
            grid.Children.Add(f6);
            grid.Children.Add(f7);
            grid.Children.Add(f8);
            grid.Children.Add(f9);
            grid.Children.Add(f10);


            g1.Content = "G1";
            g1.FontSize = 12;
            Grid.SetRow(g1, 1);
            Grid.SetColumn(g1, 7);

            g2.Content = "G2";
            g2.FontSize = 12;
            Grid.SetRow(g2, 2);
            Grid.SetColumn(g2, 7);

            g3.Content = "G3";
            g3.FontSize = 12;
            Grid.SetRow(g3, 3);
            Grid.SetColumn(g3, 7);

            g4.Content = "G4";
            g4.FontSize = 12;
            Grid.SetRow(g4, 4);
            Grid.SetColumn(g4, 7);

            g5.Content = "G5";
            g5.FontSize = 12;
            Grid.SetRow(g5, 5);
            Grid.SetColumn(g5, 7);

            g6.Content = "G6";
            g6.FontSize = 12;
            Grid.SetRow(g6, 6);
            Grid.SetColumn(g6, 7);

            g7.Content = "G7";
            g7.FontSize = 12;
            Grid.SetRow(g7, 7);
            Grid.SetColumn(g7, 7);

            g8.Content = "G8";
            g8.FontSize = 12;
            Grid.SetRow(g8, 8);
            Grid.SetColumn(g8, 7);

            g9.Content = "G9";
            g9.FontSize = 12;
            Grid.SetRow(g9, 9);
            Grid.SetColumn(g9, 7);

            g10.Content = "G10";
            g10.FontSize = 12;
            Grid.SetRow(g10, 10);
            Grid.SetColumn(g10, 7);

            grid.Children.Add(g1);
            grid.Children.Add(g2);
            grid.Children.Add(g3);
            grid.Children.Add(g4);
            grid.Children.Add(g5);
            grid.Children.Add(g6);
            grid.Children.Add(g7);
            grid.Children.Add(g8);
            grid.Children.Add(g9);
            grid.Children.Add(g10);


            h1.Content = "H1";
            h1.FontSize = 12;
            Grid.SetRow(h1, 1);
            Grid.SetColumn(h1, 8);

            h2.Content = "H2";
            h2.FontSize = 12;
            Grid.SetRow(h2, 2);
            Grid.SetColumn(h2, 8);

            h3.Content = "H3";
            h3.FontSize = 12;
            Grid.SetRow(h3, 3);
            Grid.SetColumn(h3, 8);

            h4.Content = "H4";
            h4.FontSize = 12;
            Grid.SetRow(h4, 4);
            Grid.SetColumn(h4, 8);

            h5.Content = "H5";
            h5.FontSize = 12;
            Grid.SetRow(h5, 5);
            Grid.SetColumn(h5, 8);

            h6.Content = "H6";
            h6.FontSize = 12;
            Grid.SetRow(h6, 6);
            Grid.SetColumn(h6, 8);

            h7.Content = "H7";
            h7.FontSize = 12;
            Grid.SetRow(h7, 7);
            Grid.SetColumn(h7, 8);

            h8.Content = "H8";
            h8.FontSize = 12;
            Grid.SetRow(h8, 8);
            Grid.SetColumn(h8, 8);

            h9.Content = "H9";
            h9.FontSize = 12;
            Grid.SetRow(h9, 9);
            Grid.SetColumn(h9, 8);

            h10.Content = "H10";
            h10.FontSize = 12;
            Grid.SetRow(h10, 10);
            Grid.SetColumn(h10, 8);

            grid.Children.Add(h1);
            grid.Children.Add(h2);
            grid.Children.Add(h3);
            grid.Children.Add(h4);
            grid.Children.Add(h5);
            grid.Children.Add(h6);
            grid.Children.Add(h7);
            grid.Children.Add(h8);
            grid.Children.Add(h9);
            grid.Children.Add(h10);


            i1.Content = "I1";
            i1.FontSize = 12;
            Grid.SetRow(i1, 1);
            Grid.SetColumn(i1, 9);

            i2.Content = "I2";
            i2.FontSize = 12;
            Grid.SetRow(i2, 2);
            Grid.SetColumn(i2, 9);

            i3.Content = "I3";
            i3.FontSize = 12;
            Grid.SetRow(i3, 3);
            Grid.SetColumn(i3, 9);

            i4.Content = "I4";
            i4.FontSize = 12;
            Grid.SetRow(i4, 4);
            Grid.SetColumn(i4, 9);

            i5.Content = "I5";
            i5.FontSize = 12;
            Grid.SetRow(i5, 5);
            Grid.SetColumn(i5, 9);

            i6.Content = "I6";
            i6.FontSize = 12;
            Grid.SetRow(i6, 6);
            Grid.SetColumn(i6, 9);

            i7.Content = "I7";
            i7.FontSize = 12;
            Grid.SetRow(i7, 7);
            Grid.SetColumn(i7, 9);

            i8.Content = "I8";
            i8.FontSize = 12;
            Grid.SetRow(i8, 8);
            Grid.SetColumn(i8, 9);

            i9.Content = "I9";
            i9.FontSize = 12;
            Grid.SetRow(i9, 9);
            Grid.SetColumn(i9, 9);

            i10.Content = "I10";
            i10.FontSize = 12;
            Grid.SetRow(i10, 10);
            Grid.SetColumn(i10, 9);

            grid.Children.Add(i1);
            grid.Children.Add(i2);
            grid.Children.Add(i3);
            grid.Children.Add(i4);
            grid.Children.Add(i5);
            grid.Children.Add(i6);
            grid.Children.Add(i7);
            grid.Children.Add(i8);
            grid.Children.Add(i9);
            grid.Children.Add(i10);



            j1.Content = "J1";
            j1.FontSize = 12;
            Grid.SetRow(j1, 1);
            Grid.SetColumn(j1, 10);

            j2.Content = "J2";
            i2.FontSize = 12;
            Grid.SetRow(j2, 2);
            Grid.SetColumn(j2, 10);

            j3.Content = "J3";
            j3.FontSize = 12;
            Grid.SetRow(j3, 3);
            Grid.SetColumn(j3, 10);

            j4.Content = "J4";
            j4.FontSize = 12;
            Grid.SetRow(j4, 4);
            Grid.SetColumn(j4, 10);

            j5.Content = "J5";
            j5.FontSize = 12;
            Grid.SetRow(j5, 5);
            Grid.SetColumn(j5, 10);

            j6.Content = "J6";
            j6.FontSize = 12;
            Grid.SetRow(j6, 6);
            Grid.SetColumn(j6, 10);

            j7.Content = "J7";
            j7.FontSize = 12;
            Grid.SetRow(j7, 7);
            Grid.SetColumn(j7, 10);

            j8.Content = "J8";
            j8.FontSize = 12;
            Grid.SetRow(j8, 8);
            Grid.SetColumn(j8, 10);

            j9.Content = "J9";
            j9.FontSize = 12;
            Grid.SetRow(j9, 9);
            Grid.SetColumn(j9, 10);

            j10.Content = "J10";
            j10.FontSize = 12;
            Grid.SetRow(j10, 10);
            Grid.SetColumn(j10, 10);

            grid.Children.Add(j1);
            grid.Children.Add(j2);
            grid.Children.Add(j3);
            grid.Children.Add(j4);
            grid.Children.Add(j5);
            grid.Children.Add(j6);
            grid.Children.Add(j7);
            grid.Children.Add(j8);
            grid.Children.Add(j9);
            grid.Children.Add(j10);
        }

        public void ButtonsNotEnabled()
        {
            a1.IsEnabled = false;
            a2.IsEnabled = false;
            a3.IsEnabled = false;
            a4.IsEnabled = false;
            a5.IsEnabled = false;
            a6.IsEnabled = false;
            a7.IsEnabled = false;
            a8.IsEnabled = false;
            a9.IsEnabled = false;
            a10.IsEnabled = false;

            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            b4.IsEnabled = false;
            b5.IsEnabled = false;
            b6.IsEnabled = false;
            b7.IsEnabled = false;
            b8.IsEnabled = false;
            b9.IsEnabled = false;
            b10.IsEnabled = false;

            c1.IsEnabled = false;
            c2.IsEnabled = false;
            c3.IsEnabled = false;
            c4.IsEnabled = false;
            c5.IsEnabled = false;
            c6.IsEnabled = false;
            c7.IsEnabled = false;
            c8.IsEnabled = false;
            c9.IsEnabled = false;
            c10.IsEnabled = false;

            d1.IsEnabled = false;
            d2.IsEnabled = false;
            d3.IsEnabled = false;
            d4.IsEnabled = false;
            d5.IsEnabled = false;
            d6.IsEnabled = false;
            d7.IsEnabled = false;
            d8.IsEnabled = false;
            d9.IsEnabled = false;
            d10.IsEnabled = false;

            e1.IsEnabled = false;
            e2.IsEnabled = false;
            e3.IsEnabled = false;
            e4.IsEnabled = false;
            e5.IsEnabled = false;
            e6.IsEnabled = false;
            e7.IsEnabled = false;
            e8.IsEnabled = false;
            e9.IsEnabled = false;
            e10.IsEnabled = false;

            f1.IsEnabled = false;
            f2.IsEnabled = false;
            f3.IsEnabled = false;
            f4.IsEnabled = false;
            f5.IsEnabled = false;
            f6.IsEnabled = false;
            f7.IsEnabled = false;
            f8.IsEnabled = false;
            f9.IsEnabled = false;
            f10.IsEnabled = false;

            g1.IsEnabled = false;
            g2.IsEnabled = false;
            g3.IsEnabled = false;
            g4.IsEnabled = false;
            g5.IsEnabled = false;
            g6.IsEnabled = false;
            g7.IsEnabled = false;
            g8.IsEnabled = false;
            g9.IsEnabled = false;
            g10.IsEnabled = false;

            h1.IsEnabled = false;
            h2.IsEnabled = false;
            h3.IsEnabled = false;
            h4.IsEnabled = false;
            h5.IsEnabled = false;
            h6.IsEnabled = false;
            h7.IsEnabled = false;
            h8.IsEnabled = false;
            h9.IsEnabled = false;
            h10.IsEnabled = false;

            i1.IsEnabled = false;
            i2.IsEnabled = false;
            i3.IsEnabled = false;
            i4.IsEnabled = false;
            i5.IsEnabled = false;
            i6.IsEnabled = false;
            i7.IsEnabled = false;
            i8.IsEnabled = false;
            i9.IsEnabled = false;
            i10.IsEnabled = false;

            j1.IsEnabled = false;
            j2.IsEnabled = false;
            j3.IsEnabled = false;
            j4.IsEnabled = false;
            j5.IsEnabled = false;
            j6.IsEnabled = false;
            j7.IsEnabled = false;
            j8.IsEnabled = false;
            j9.IsEnabled = false;
            j10.IsEnabled = false;
        }

        public void ButtonsEnabled()
        {
            a1.IsEnabled = true;
            a2.IsEnabled = true;
            a3.IsEnabled = true;
            a4.IsEnabled = true;
            a5.IsEnabled = true;
            a6.IsEnabled = true;
            a7.IsEnabled = true;
            a8.IsEnabled = true;
            a9.IsEnabled = true;
            a10.IsEnabled = true;

            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;
            b7.IsEnabled = true;
            b8.IsEnabled = true;
            b9.IsEnabled = true;
            b10.IsEnabled = true;

            c1.IsEnabled = true;
            c2.IsEnabled = true;
            c3.IsEnabled = true;
            c4.IsEnabled = true;
            c5.IsEnabled = true;
            c6.IsEnabled = true;
            c7.IsEnabled = true;
            c8.IsEnabled = true;
            c9.IsEnabled = true;
            c10.IsEnabled = true;

            d1.IsEnabled = true;
            d2.IsEnabled = true;
            d3.IsEnabled = true;
            d4.IsEnabled = true;
            d5.IsEnabled = true;
            d6.IsEnabled = true;
            d7.IsEnabled = true;
            d8.IsEnabled = true;
            d9.IsEnabled = true;
            d10.IsEnabled = true;

            e1.IsEnabled = true;
            e2.IsEnabled = true;
            e3.IsEnabled = true;
            e4.IsEnabled = true;
            e5.IsEnabled = true;
            e6.IsEnabled = true;
            e7.IsEnabled = true;
            e8.IsEnabled = true;
            e9.IsEnabled = true;
            e10.IsEnabled = true;

            f1.IsEnabled = true;
            f2.IsEnabled = true;
            f3.IsEnabled = true;
            f4.IsEnabled = true;
            f5.IsEnabled = true;
            f6.IsEnabled = true;
            f7.IsEnabled = true;
            f8.IsEnabled = true;
            f9.IsEnabled = true;
            f10.IsEnabled = true;

            g1.IsEnabled = true;
            g2.IsEnabled = true;
            g3.IsEnabled = true;
            g4.IsEnabled = true;
            g5.IsEnabled = true;
            g6.IsEnabled = true;
            g7.IsEnabled = true;
            g8.IsEnabled = true;
            g9.IsEnabled = true;
            g10.IsEnabled = true;

            h1.IsEnabled = true;
            h2.IsEnabled = true;
            h3.IsEnabled = true;
            h4.IsEnabled = true;
            h5.IsEnabled = true;
            h6.IsEnabled = true;
            h7.IsEnabled = true;
            h8.IsEnabled = true;
            h9.IsEnabled = true;
            h10.IsEnabled = true;

            i1.IsEnabled = true;
            i2.IsEnabled = true;
            i3.IsEnabled = true;
            i4.IsEnabled = true;
            i5.IsEnabled = true;
            i6.IsEnabled = true;
            i7.IsEnabled = true;
            i8.IsEnabled = true;
            i9.IsEnabled = true;
            i10.IsEnabled = true;

            j1.IsEnabled = true;
            j2.IsEnabled = true;
            j3.IsEnabled = true;
            j4.IsEnabled = true;
            j5.IsEnabled = true;
            j6.IsEnabled = true;
            j7.IsEnabled = true;
            j8.IsEnabled = true;
            j9.IsEnabled = true;
            j10.IsEnabled = true;
        }



        //FARE CONTROLLI SE BOTTONI CHE SI TROVANO NELLA DIREZIONE DEL 2 BOTTONE SELEZIONATO SONO GIA' STATI SELEZIONATI
        

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P")
                        {
                            b1.IsEnabled = true;
                            b1.Click += B1_Click;
                            controllo = true;
                        }
                        if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P")
                        {
                            b3.IsEnabled = true;
                            b3.Click += B3_Click;
                            controllo = true;
                        }
                        if (a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P")
                        {
                            a2.IsEnabled = true;
                            a2.Click += A2_Click;
                            controllo = true;
                        }
                        if (c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P")
                        {
                            c2.IsEnabled = true;
                            c2.Click += C2_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b2.Content = "CA";
                            VettCacciatorpediniere[0] = "B2";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        b2.Content = "CA";
                        VettCacciatorpediniere[1] = "B2";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P")
                            {
                                b3.IsEnabled = true;
                                b3.Click += B3_Click;
                                controllo = true;
                            }
                            if (c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P" && d2.Content.ToString() != "CA" && d2.Content.ToString() != "CO" && d2.Content.ToString() != "S1" && d2.Content.ToString() != "S2" && d2.Content.ToString() != "P")
                            {
                                c2.IsEnabled = true;
                                c2.Click += C2_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b2.Content = "S1";
                                VettSottomarino1[0] = "B2";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a2")
                            {
                                VettSottomarino1[1] = "B2";
                                VettSottomarino1[2] = "C2";
                                b2.Content = "S1";
                                c2.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b3")
                            {
                                VettSottomarino1[1] = "B2";
                                VettSottomarino1[2] = "B1";
                                b2.Content = "S1";
                                b1.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }else if (bottoneScelto == "c2")
                            {
                                VettSottomarino1[1] = "B2";
                                VettSottomarino1[2] = "A2";
                                b2.Content = "S1";
                                a2.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P")
                            {
                                b3.IsEnabled = true;
                                b3.Click += B3_Click;
                                controllo = true;
                            }
                            if (c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P" && d2.Content.ToString() != "CA" && d2.Content.ToString() != "CO" && d2.Content.ToString() != "S1" && d2.Content.ToString() != "S2" && d2.Content.ToString() != "P")
                            {
                                c2.IsEnabled = true;
                                c2.Click += C2_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a2.Content = "S2";
                                VettSottomarino2[0] = "A2";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a2")
                            {
                                VettSottomarino2[1] = "B2";
                                VettSottomarino2[2] = "C2";
                                b2.Content = "S2";
                                c2.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b3")
                            {
                                VettSottomarino2[1] = "B2";
                                VettSottomarino2[2] = "B1";
                                b2.Content = "S2";
                                b1.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c2")
                            {
                                VettSottomarino2[1] = "B2";
                                VettSottomarino2[2] = "A2";
                                b2.Content = "S2";
                                a2.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P")
                        {
                            b3.IsEnabled = true;
                            b3.Click += B3_Click;
                            controllo = true;
                        }
                        if (c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P" && d2.Content.ToString() != "CA" && d2.Content.ToString() != "CO" && d2.Content.ToString() != "S1" && d2.Content.ToString() != "S2" && d2.Content.ToString() != "P" && e2.Content.ToString() != "CA" && e2.Content.ToString() != "CO" && e2.Content.ToString() != "S1" && e2.Content.ToString() != "S2" && e2.Content.ToString() != "P")
                        {
                            c2.IsEnabled = true;
                            c2.Click += C2_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b2.Content = "CO";
                            VettCorazzate[0] = "B2";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a2")
                        {
                            VettCorazzate[1] = "B2";
                            VettCorazzate[2] = "C2";
                            VettCorazzate[3] = "D2";
                            b2.Content = "CO";
                            c2.Content = "CO";
                            d2.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        if (bottoneScelto == "b1")
                        {
                            VettCorazzate[1] = "B2";
                            VettCorazzate[2] = "B3";
                            VettCorazzate[3] = "B4";
                            b2.Content = "CO";
                            b3.Content = "CO";
                            b4.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P")
                        {
                            b3.IsEnabled = true;
                            b3.Click += B3_Click;
                            controllo = true;
                        }
                        if (c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P" && d2.Content.ToString() != "CA" && d2.Content.ToString() != "CO" && d2.Content.ToString() != "S1" && d2.Content.ToString() != "S2" && d2.Content.ToString() != "P" && e2.Content.ToString() != "CA" && e2.Content.ToString() != "CO" && e2.Content.ToString() != "S1" && e2.Content.ToString() != "S2" && e2.Content.ToString() != "P" && f2.Content.ToString() != "CA" && f2.Content.ToString() != "CO" && f2.Content.ToString() != "S1" && f2.Content.ToString() != "S2" && f2.Content.ToString() != "P")
                        {
                            c2.IsEnabled = true;
                            c2.Click += C2_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b2.Content = "P";
                            VettPortaerei[0] = "B2";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a2")
                        {
                            VettPortaerei[1] = "B2";
                            VettPortaerei[2] = "C2";
                            VettPortaerei[3] = "D2";
                            VettPortaerei[4] = "E2";
                            b2.Content = "P";
                            c2.Content = "P";
                            e2.Content = "P";
                            d2.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        if (bottoneScelto == "b1")
                        {
                            VettPortaerei[1] = "B2";
                            VettPortaerei[2] = "B3";
                            VettPortaerei[3] = "B4";
                            VettPortaerei[4] = "B5";
                            b2.Content = "P";
                            b3.Content = "P";
                            b4.Content = "P";
                            b5.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                    }

                }
                bottoneScelto = "b2";
                c = true;
            }
            else
                c = false;
        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if(b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P")
                        {
                            b2.IsEnabled = true;
                            b2.Click += B2_Click;
                            controllo = true;
                        }
                        if (d2.Content.ToString() != "CA" && d2.Content.ToString() != "CO" && d2.Content.ToString() != "S1" && d2.Content.ToString() != "S2" && d2.Content.ToString() != "P")
                        {
                            d2.IsEnabled = true;
                            d2.Click += D2_Click;
                            controllo = true;
                        }
                        if (c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P")
                        {
                            c3.IsEnabled = true;
                            c3.Click += C3_Click;
                            controllo = true;
                        }
                        if (c1.Content.ToString() != "CA" && c1.Content.ToString() != "CO" && c1.Content.ToString() != "S1" && c1.Content.ToString() != "S2" && c1.Content.ToString() != "P")
                        {
                            c1.IsEnabled = true;
                            c1.Click += C1_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            c2.Content = "CA";
                            VettCacciatorpediniere[0] = "C2";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        c2.Content = "CA";
                        VettCacciatorpediniere[1] = "C2";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            bool controllo = false;
                            ButtonsNotEnabled();
                            if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P")
                            {
                                b2.IsEnabled = true;
                                b2.Click += B2_Click;
                                controllo = true;
                            }
                            if (d2.Content.ToString() != "CA" && d2.Content.ToString() != "CO" && d2.Content.ToString() != "S1" && d2.Content.ToString() != "S2" && d2.Content.ToString() != "P" && e2.Content.ToString() != "CA" && e2.Content.ToString() != "CO" && e2.Content.ToString() != "S1" && e2.Content.ToString() != "S2" && e2.Content.ToString() != "P")
                            {
                                d2.IsEnabled = true;
                                d2.Click += D2_Click;
                                controllo = true;
                            }
                            if (c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P" && c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P")
                            {
                                c3.IsEnabled = true;
                                c3.Click += C3_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                c2.Content = "S1";
                                VettSottomarino1[0] = "C2";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "b2")
                            {
                                VettSottomarino1[1] = "C2";
                                VettSottomarino1[2] = "D2";
                                d2.Content = "S1";
                                c2.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "d2")
                            {
                                VettSottomarino1[1] = "C2";
                                VettSottomarino1[2] = "B2";
                                b2.Content = "S1";
                                c2.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            bool controllo = false;
                            ButtonsNotEnabled();
                            if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P")
                            {
                                b2.IsEnabled = true;
                                b2.Click += B2_Click;
                                controllo = true;
                            }
                            if (d2.Content.ToString() != "CA" && d2.Content.ToString() != "CO" && d2.Content.ToString() != "S1" && d2.Content.ToString() != "S2" && d2.Content.ToString() != "P" && e2.Content.ToString() != "CA" && e2.Content.ToString() != "CO" && e2.Content.ToString() != "S1" && e2.Content.ToString() != "S2" && e2.Content.ToString() != "P")
                            {
                                d2.IsEnabled = true;
                                d2.Click += D2_Click;
                                controllo = true;
                            }
                            if (c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P" && c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P")
                            {
                                c3.IsEnabled = true;
                                c3.Click += C3_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                c2.Content = "S2";
                                VettSottomarino2[0] = "C2";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "b2")
                            {
                                VettSottomarino2[1] = "C2";
                                VettSottomarino2[2] = "D2";
                                d2.Content = "S2";
                                c2.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "d2")
                            {
                                VettSottomarino2[1] = "C2";
                                VettSottomarino2[2] = "B2";
                                b2.Content = "S2";
                                c2.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (d2.Content.ToString() != "CA" && d2.Content.ToString() != "CO" && d2.Content.ToString() != "S1" && d2.Content.ToString() != "S2" && d2.Content.ToString() != "P" && e2.Content.ToString() != "CA" && e2.Content.ToString() != "CO" && e2.Content.ToString() != "S1" && e2.Content.ToString() != "S2" && e2.Content.ToString() != "P" && f2.Content.ToString() != "CA" && f2.Content.ToString() != "CO" && f2.Content.ToString() != "S1" && f2.Content.ToString() != "S2" && f2.Content.ToString() != "P")
                        {
                            d2.IsEnabled = true;
                            d2.Click += D2_Click;
                            controllo = true;
                        }
                        if (c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P" && c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P" && c5.Content.ToString() != "CA" && c5.Content.ToString() != "CO" && c5.Content.ToString() != "S1" && c5.Content.ToString() != "S2" && c5.Content.ToString() != "P")
                        {
                            c3.IsEnabled = true;
                            c3.Click += C3_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            c2.Content = "CO";
                            VettCorazzate[0] = "C2";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "b2")
                        {
                            VettCorazzate[1] = "C2";
                            VettCorazzate[2] = "D2";
                            VettCorazzate[3] = "E2";
                            e2.Content = "CO";
                            c2.Content = "CO";
                            d2.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "d2")
                        {
                            VettCorazzate[1] = "C2";
                            VettCorazzate[2] = "B2";
                            VettCorazzate[3] = "A2";
                            b2.Content = "CO";
                            c2.Content = "CO";
                            a2.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (d2.Content.ToString() != "CA" && d2.Content.ToString() != "CO" && d2.Content.ToString() != "S1" && d2.Content.ToString() != "S2" && d2.Content.ToString() != "P" && e2.Content.ToString() != "CA" && e2.Content.ToString() != "CO" && e2.Content.ToString() != "S1" && e2.Content.ToString() != "S2" && e2.Content.ToString() != "P" && f2.Content.ToString() != "CA" && f2.Content.ToString() != "CO" && f2.Content.ToString() != "S1" && f2.Content.ToString() != "S2" && f2.Content.ToString() != "P" && g2.Content.ToString() != "CA" && g2.Content.ToString() != "CO" && g2.Content.ToString() != "S1" && g2.Content.ToString() != "S2" && g2.Content.ToString() != "P")
                        {
                            d2.IsEnabled = true;
                            d2.Click += D2_Click;
                            controllo = true;
                        }
                        if (c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P" && c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P" && c5.Content.ToString() != "CA" && c5.Content.ToString() != "CO" && c5.Content.ToString() != "S1" && c5.Content.ToString() != "S2" && c5.Content.ToString() != "P" && c6.Content.ToString() != "CA" && c6.Content.ToString() != "CO" && c6.Content.ToString() != "S1" && c6.Content.ToString() != "S2" && c6.Content.ToString() != "P")
                        {
                            c3.IsEnabled = true;
                            c3.Click += C3_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            c2.Content = "P";
                            VettPortaerei[0] = "C2";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        VettPortaerei[1] = "C2";
                        VettPortaerei[2] = "D2";
                        VettPortaerei[3] = "E2";
                        VettPortaerei[4] = "F2";
                        f2.Content = "P";
                        c2.Content = "P";
                        d2.Content = "P";
                        e2.Content = "P";
                        btnConferma.IsEnabled = true;
                    }
                }
                bottoneScelto = "c2";
                c = true;
            }
            else
                c = false;
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P")
                        {
                            b3.IsEnabled = true;
                            b3.Click += B3_Click;
                            controllo = true;
                        }
                        if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P")
                        {
                            b5.IsEnabled = true;
                            b5.Click += B5_Click;
                            controllo = true;
                        }
                        if (a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P")
                        {
                            a4.IsEnabled = true;
                            a4.Click += A4_Click;
                            controllo = true;
                        }
                        if (c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P")
                        {
                            c4.IsEnabled = true;
                            c4.Click += C4_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b4.Content = "CA";
                            VettCacciatorpediniere[0] = "B4";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        b4.Content = "CA";
                        VettCacciatorpediniere[1] = "B4";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P")
                            {
                                b3.IsEnabled = true;
                                b3.Click += B3_Click;
                                controllo = true;
                            }
                            if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P")
                            {
                                b5.IsEnabled = true;
                                b5.Click += B5_Click;
                                controllo = true;
                            }
                            if (c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P" && d4.Content.ToString() != "CA" && d4.Content.ToString() != "CO" && d4.Content.ToString() != "S1" && d4.Content.ToString() != "S2" && d4.Content.ToString() != "P")
                            {
                                c4.IsEnabled = true;
                                c4.Click += C4_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b4.Content = "S1";
                                VettSottomarino1[0] = "B4";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a4")
                            {
                                VettSottomarino1[1] = "B4";
                                VettSottomarino1[2] = "C4";
                                b4.Content = "S1";
                                c4.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b5")
                            {
                                VettSottomarino1[1] = "B4";
                                VettSottomarino1[2] = "B3";
                                b4.Content = "S1";
                                b3.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c4")
                            {
                                VettSottomarino1[1] = "B4";
                                VettSottomarino1[2] = "A4";
                                b4.Content = "S1";
                                a4.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P")
                            {
                                b3.IsEnabled = true;
                                b3.Click += B3_Click;
                                controllo = true;
                            }
                            if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P")
                            {
                                b5.IsEnabled = true;
                                b5.Click += B5_Click;
                                controllo = true;
                            }
                            if (c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P" && d4.Content.ToString() != "CA" && d4.Content.ToString() != "CO" && d4.Content.ToString() != "S1" && d4.Content.ToString() != "S2" && d4.Content.ToString() != "P")
                            {
                                c4.IsEnabled = true;
                                c4.Click += C4_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b4.Content = "S2";
                                VettSottomarino2[0] = "B4";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a4")
                            {
                                VettSottomarino2[1] = "B4";
                                VettSottomarino2[2] = "C4";
                                b4.Content = "S2";
                                c4.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b5")
                            {
                                VettSottomarino2[1] = "B4";
                                VettSottomarino2[2] = "B3";
                                b4.Content = "S2";
                                b3.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c4")
                            {
                                VettSottomarino2[1] = "B4";
                                VettSottomarino2[2] = "A4";
                                b4.Content = "S2";
                                a4.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P")
                        {
                            b3.IsEnabled = true;
                            b3.Click += B3_Click;
                            controllo = true;
                        }
                        if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P")
                        {
                            b5.IsEnabled = true;
                            b5.Click += B5_Click;
                            controllo = true;
                        }
                        if (c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P" && d4.Content.ToString() != "CA" && d4.Content.ToString() != "CO" && d4.Content.ToString() != "S1" && d4.Content.ToString() != "S2" && d4.Content.ToString() != "P" && e4.Content.ToString() != "CA" && e4.Content.ToString() != "CO" && e4.Content.ToString() != "S1" && e4.Content.ToString() != "S2" && e4.Content.ToString() != "P")
                        {
                            c4.IsEnabled = true;
                            c4.Click += C4_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b4.Content = "CO";
                            VettCorazzate[0] = "B4";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a4")
                        {
                            VettCorazzate[1] = "B4";
                            VettCorazzate[2] = "C4";
                            VettCorazzate[3] = "D4";
                            b4.Content = "CO";
                            c4.Content = "CO";
                            d4.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b5")
                        {
                            VettCorazzate[1] = "B4";
                            VettCorazzate[2] = "B3";
                            VettCorazzate[3] = "B2";
                            b4.Content = "CO";
                            b3.Content = "CO";
                            b2.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b3")
                        {
                            VettCorazzate[1] = "B4";
                            VettCorazzate[2] = "B5";
                            VettCorazzate[3] = "B6";
                            b4.Content = "CO";
                            b5.Content = "CO";
                            b6.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P")
                        {
                            b5.IsEnabled = true;
                            b5.Click += B5_Click;
                            controllo = true;
                        }
                        if (c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P" && d4.Content.ToString() != "CA" && d4.Content.ToString() != "CO" && d4.Content.ToString() != "S1" && d4.Content.ToString() != "S2" && d4.Content.ToString() != "P" && e4.Content.ToString() != "CA" && e4.Content.ToString() != "CO" && e4.Content.ToString() != "S1" && e4.Content.ToString() != "S2" && e4.Content.ToString() != "P" && f4.Content.ToString() != "CA" && f4.Content.ToString() != "CO" && f4.Content.ToString() != "S1" && f4.Content.ToString() != "S2" && f4.Content.ToString() != "P")
                        {
                            c4.IsEnabled = true;
                            c4.Click += C4_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b4.Content = "P";
                            VettPortaerei[0] = "B4";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a4")
                        {
                            VettPortaerei[1] = "B4";
                            VettPortaerei[2] = "C4";
                            VettPortaerei[3] = "D4";
                            VettPortaerei[4] = "E4";
                            b4.Content = "P";
                            c4.Content = "P";
                            d4.Content = "P";
                            e4.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b5")
                        {
                            VettPortaerei[1] = "B4";
                            VettPortaerei[2] = "B3";
                            VettPortaerei[3] = "B2";
                            VettPortaerei[4] = "B1";
                            b4.Content = "P";
                            b3.Content = "P";
                            b2.Content = "P";
                            b1.Content = "P";
                            btnConferma.IsEnabled = true;
                        }else if (bottoneScelto == "b3")
                        {
                            VettPortaerei[1] = "B4";
                            VettPortaerei[2] = "B5";
                            VettPortaerei[3] = "B6";
                            VettPortaerei[4] = "B7";
                            b5.Content = "P";
                            b6.Content = "P";
                            b7.Content = "P";
                            b4.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                    }

                }
                bottoneScelto = "b4";
                c = true;
            }
            else
                c = false;
        }

        private void C4_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P")
                        {
                            b2.IsEnabled = true;
                            b2.Click += B2_Click;
                            controllo = true;
                        }
                        if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P")
                        {
                            b4.IsEnabled = true;
                            b4.Click += B4_Click;
                            controllo = true;
                        }
                        if (a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P")
                        {
                            a3.IsEnabled = true;
                            a3.Click += A3_Click;
                            controllo = true;
                        }
                        if (c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P")
                        {
                            c3.IsEnabled = true;
                            c3.Click += C3_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b3.Content = "CA";
                            VettCacciatorpediniere[0] = "B3";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        b3.Content = "CA";
                        VettCacciatorpediniere[1] = "B3";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P")
                            {
                                b4.IsEnabled = true;
                                b4.Click += B4_Click;
                                controllo = true;
                            }
                            if (c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P" && d3.Content.ToString() != "CA" && d3.Content.ToString() != "CO" && d3.Content.ToString() != "S1" && d3.Content.ToString() != "S2" && d3.Content.ToString() != "P")
                            {
                                c3.IsEnabled = true;
                                c3.Click += C3_Click;
                                controllo = true;
                            }
                            if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P")
                            {
                                b2.IsEnabled = true;
                                b2.Click += B1_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b3.Content = "S1";
                                VettSottomarino1[0] = "B3";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a3")
                            {
                                VettSottomarino1[1] = "B3";
                                VettSottomarino1[2] = "C3";
                                b3.Content = "S1";
                                c3.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b4")
                            {
                                VettSottomarino1[1] = "B3";
                                VettSottomarino1[2] = "B2";
                                b2.Content = "S1";
                                b3.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c3")
                            {
                                VettSottomarino1[1] = "B3";
                                VettSottomarino1[2] = "A3";
                                b3.Content = "S1";
                                a3.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P")
                            {
                                b4.IsEnabled = true;
                                b4.Click += B4_Click;
                                controllo = true;
                            }
                            if (c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P" && d3.Content.ToString() != "CA" && d3.Content.ToString() != "CO" && d3.Content.ToString() != "S1" && d3.Content.ToString() != "S2" && d3.Content.ToString() != "P")
                            {
                                c3.IsEnabled = true;
                                c3.Click += C3_Click;
                                controllo = true;
                            }
                            if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P")
                            {
                                b2.IsEnabled = true;
                                b2.Click += B1_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b3.Content = "S2";
                                VettSottomarino2[0] = "B3";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a3")
                            {
                                VettSottomarino2[1] = "B3";
                                VettSottomarino2[2] = "C3";
                                b3.Content = "S2";
                                c3.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b4")
                            {
                                VettSottomarino2[1] = "B3";
                                VettSottomarino2[2] = "B2";
                                b2.Content = "S2";
                                b3.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c3")
                            {
                                VettSottomarino2[1] = "B3";
                                VettSottomarino2[2] = "A3";
                                b3.Content = "S2";
                                a3.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P")
                        {
                            b4.IsEnabled = true;
                            b4.Click += B4_Click;
                            controllo = true;
                        }
                        if (c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P" && d3.Content.ToString() != "CA" && d3.Content.ToString() != "CO" && d3.Content.ToString() != "S1" && d3.Content.ToString() != "S2" && d3.Content.ToString() != "P" && e3.Content.ToString() != "CA" && e3.Content.ToString() != "CO" && e3.Content.ToString() != "S1" && e3.Content.ToString() != "S2" && e3.Content.ToString() != "P")
                        {
                            c3.IsEnabled = true;
                            c3.Click += C3_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b3.Content = "CO";
                            VettCorazzate[0] = "B3";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a3")
                        {
                            VettCorazzate[1] = "B3";
                            VettCorazzate[2] = "C3";
                            VettCorazzate[3] = "D3";
                            b3.Content = "CO";
                            c3.Content = "CO";
                            d3.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        if (bottoneScelto == "b2")
                        {
                            VettCorazzate[1] = "B3";
                            VettCorazzate[2] = "B4";
                            VettCorazzate[3] = "B5";
                            b3.Content = "CO";
                            b4.Content = "CO";
                            b5.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        if (bottoneScelto == "b4")
                        {
                            VettCorazzate[1] = "B3";
                            VettCorazzate[2] = "B2";
                            VettCorazzate[3] = "B1";
                            b3.Content = "CO";
                            b2.Content = "CO";
                            b1.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P")
                        {
                            b4.IsEnabled = true;
                            b4.Click += B4_Click;
                            controllo = true;
                        }
                        if (c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P" && d3.Content.ToString() != "CA" && d3.Content.ToString() != "CO" && d3.Content.ToString() != "S1" && d3.Content.ToString() != "S2" && d3.Content.ToString() != "P" && e3.Content.ToString() != "CA" && e3.Content.ToString() != "CO" && e3.Content.ToString() != "S1" && e3.Content.ToString() != "S2" && e3.Content.ToString() != "P" && f3.Content.ToString() != "CA" && f3.Content.ToString() != "CO" && f3.Content.ToString() != "S1" && f3.Content.ToString() != "S2" && f3.Content.ToString() != "P")
                        {
                            c3.IsEnabled = true;
                            c3.Click += C3_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b3.Content = "P";
                            VettPortaerei[0] = "B3";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a3")
                        {
                            VettPortaerei[1] = "B3";
                            VettPortaerei[2] = "C3";
                            VettPortaerei[3] = "D3";
                            VettPortaerei[4] = "E3";
                            b3.Content = "P";
                            c3.Content = "P";
                            e3.Content = "P";
                            d3.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        if (bottoneScelto == "b2")
                        {
                            VettPortaerei[1] = "B3";
                            VettPortaerei[2] = "B4";
                            VettPortaerei[3] = "B5";
                            VettPortaerei[4] = "B6";
                            b6.Content = "P";
                            b3.Content = "P";
                            b4.Content = "P";
                            b5.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                    }

                }
                bottoneScelto = "b3";
                c = true;
            }
            else
                c = false;
        }

        private void C3_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P")
                        {
                            b1.IsEnabled = true;
                            b1.Click += B1_Click;
                            controllo = true;
                        }
                        if (a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P")
                        {
                            a2.IsEnabled = true;
                            a2.Click += A2_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a1.Content = "CA";
                            VettCacciatorpediniere[0] = "A1";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        a1.Content = "CA";
                        VettCacciatorpediniere[1] = "A1";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            bool controllo = false;
                            ButtonsNotEnabled();
                            if (b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P" && c1.Content.ToString() != "CA" && c1.Content.ToString() != "CO" && c1.Content.ToString() != "S1" && c1.Content.ToString() != "S2" && c1.Content.ToString() != "P")
                            {
                                b1.IsEnabled = true;
                                b1.Click += B1_Click;
                                controllo = true;
                            }
                            if (a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P" && a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P")
                            {
                                a2.IsEnabled = true;
                                a2.Click += A2_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a1.Content = "S1";
                                VettSottomarino1[0] = "A1";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Impossibile scegliere questa casella: non ci sono abbastanza caselle per inserire una nave in questa direzione", "Error");
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            bool controllo = false;
                            ButtonsNotEnabled();
                            if (b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P" && c1.Content.ToString() != "CA" && c1.Content.ToString() != "CO" && c1.Content.ToString() != "S1" && c1.Content.ToString() != "S2" && c1.Content.ToString() != "P")
                            {
                                b1.IsEnabled = true;
                                b1.Click += B1_Click;
                                controllo = true;
                            }
                            if (a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P" && a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P")
                            {
                                a2.IsEnabled = true;
                                a2.Click += A2_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a1.Content = "S2";
                                VettSottomarino2[0] = "A1";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Impossibile scegliere questa casella: non ci sono abbastanza caselle per inserire una nave in questa direzione", "Error");
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P" && c1.Content.ToString() != "CA" && c1.Content.ToString() != "CO" && c1.Content.ToString() != "S1" && c1.Content.ToString() != "S2" && c1.Content.ToString() != "P" && d1.Content.ToString() != "CA" && d1.Content.ToString() != "CO" && d1.Content.ToString() != "S1" && d1.Content.ToString() != "S2" && d1.Content.ToString() != "P")
                        {
                            b1.IsEnabled = true;
                            b1.Click += B1_Click;
                            controllo = true;
                        }
                        if (a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P" && a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P")
                        {
                            a2.IsEnabled = true;
                            a2.Click += A2_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a1.Content = "CO";
                            VettCorazzate[0] = "A1";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Impossibile scegliere questa casella: non ci sono abbastanza caselle per inserire una nave in questa direzione", "Error");
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P" && c1.Content.ToString() != "CA" && c1.Content.ToString() != "CO" && c1.Content.ToString() != "S1" && c1.Content.ToString() != "S2" && c1.Content.ToString() != "P" && d1.Content.ToString() != "CA" && d1.Content.ToString() != "CO" && d1.Content.ToString() != "S1" && d1.Content.ToString() != "S2" && d1.Content.ToString() != "P" && e1.Content.ToString() != "CA" && e1.Content.ToString() != "CO" && e1.Content.ToString() != "S1" && e1.Content.ToString() != "S2" && e1.Content.ToString() != "P")
                        {
                            b1.IsEnabled = true;
                            b1.Click += B1_Click;
                            controllo = true;
                        }
                        if (a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P" && a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P")
                        {
                            a2.IsEnabled = true;
                            a2.Click += A2_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a1.Content = "P";
                            VettPortaerei[0] = "A1";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Impossibile scegliere questa casella: non ci sono abbastanza caselle per inserire una nave in questa direzione", "Error");
                    }
                }
                bottoneScelto = "a1";
                c = true;
            }
            else
                c = false;
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P")
                        {
                            b2.IsEnabled = true;
                            b2.Click += B2_Click;
                            controllo = true;
                        }
                        if (a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P")
                        {
                            a3.IsEnabled = true;
                            a3.Click += A3_Click;
                            controllo = true;
                        }
                        if (a1.Content.ToString() != "CA" && a1.Content.ToString() != "CO" && a1.Content.ToString() != "S1" && a1.Content.ToString() != "S2" && a1.Content.ToString() != "P")
                        {
                            a1.IsEnabled = true;
                            a1.Click += A1_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a2.Content = "CA";
                            VettCacciatorpediniere[0] = "A2";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        a2.Content = "CA";
                        VettCacciatorpediniere[1] = "A2";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P")
                            {
                                b2.IsEnabled = true;
                                b2.Click += B2_Click;
                                controllo = true;
                            }
                            if (a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P")
                            {
                                a3.IsEnabled = true;
                                a3.Click += A3_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a2.Content = "S1";
                                VettSottomarino1[0] = "A2";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a1")
                            {
                                VettSottomarino1[1] = "A2";
                                VettSottomarino1[2] = "A3";
                                a2.Content = "S1";
                                a3.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a3")
                            {
                                VettSottomarino1[1] = "A2";
                                VettSottomarino1[2] = "A1";
                                a2.Content = "S1";
                                a1.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P")
                            {
                                b2.IsEnabled = true;
                                b2.Click += B2_Click;
                                controllo = true;
                            }
                            if (a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P")
                            {
                                a3.IsEnabled = true;
                                a3.Click += A3_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a2.Content = "S2";
                                VettSottomarino2[0] = "A2";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a1")
                            {
                                VettSottomarino2[1] = "A2";
                                VettSottomarino2[2] = "A3";
                                a2.Content = "S2";
                                a3.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a3")
                            {
                                VettSottomarino2[1] = "A2";
                                VettSottomarino2[2] = "A1";
                                a2.Content = "S2";
                                a1.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P" && d2.Content.ToString() != "CA" && d2.Content.ToString() != "CO" && d2.Content.ToString() != "S1" && d2.Content.ToString() != "S2" && d2.Content.ToString() != "P")
                        {
                            b2.IsEnabled = true;
                            b2.Click += B2_Click;
                            controllo = true;
                        }
                        if (a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P")
                        {
                            a3.IsEnabled = true;
                            a3.Click += A3_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a2.Content = "CO";
                            VettCorazzate[0] = "A2";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        VettCorazzate[1] = "A2";
                        VettCorazzate[2] = "A3";
                        VettCorazzate[3] = "A4";
                        a2.Content = "CO";
                        a3.Content = "CO";
                        a4.Content = "CO";
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P" && d2.Content.ToString() != "CA" && d2.Content.ToString() != "CO" && d2.Content.ToString() != "S1" && d2.Content.ToString() != "S2" && d2.Content.ToString() != "P" && e2.Content.ToString() != "CA" && e2.Content.ToString() != "CO" && e2.Content.ToString() != "S1" && e2.Content.ToString() != "S2" && e2.Content.ToString() != "P")
                        {
                            b2.IsEnabled = true;
                            b2.Click += B2_Click;
                            controllo = true;
                        }
                        if (a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P")
                        {
                            a3.IsEnabled = true;
                            a3.Click += A3_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a2.Content = "P";
                            VettPortaerei[0] = "A2";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        VettPortaerei[1] = "A2";
                        VettPortaerei[2] = "A3";
                        VettPortaerei[3] = "A4";
                        VettPortaerei[4] = "A5";
                        a2.Content = "P";
                        a3.Content = "P";
                        a4.Content = "P";
                        a5.Content = "P";
                        btnConferma.IsEnabled = true;
                    }

                }
                bottoneScelto = "a2";
                c = true;
            }
            else
                c = false;
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P")
                        {
                            b3.IsEnabled = true;
                            b3.Click += B3_Click;
                            controllo = true;
                        }
                        if (a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P")
                        {
                            a2.IsEnabled = true;
                            a2.Click += A2_Click;
                            controllo = true;
                        }
                        if (a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P")
                        {
                            a4.IsEnabled = true;
                            a4.Click += A4_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a3.Content = "CA";
                            VettCacciatorpediniere[0] = "A2";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        a3.Content = "CA";
                        VettCacciatorpediniere[1] = "A3";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P")
                            {
                                b3.IsEnabled = true;
                                b3.Click += B3_Click;
                                controllo = true;
                            }
                            if (a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P")
                            {
                                a4.IsEnabled = true;
                                a4.Click += A4_Click;
                                controllo = true;
                            }
                            if (a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P" && a1.Content.ToString() != "CA" && a1.Content.ToString() != "CO" && a1.Content.ToString() != "S1" && a1.Content.ToString() != "S2" && a1.Content.ToString() != "P")
                            {
                                a2.IsEnabled = true;
                                a2.Click += A2_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a3.Content = "S1";
                                VettSottomarino1[0] = "A3";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a2")
                            {
                                VettSottomarino1[1] = "A3";
                                VettSottomarino1[2] = "A4";
                                a4.Content = "S1";
                                a3.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a4")
                            {
                                VettSottomarino1[1] = "A3";
                                VettSottomarino1[2] = "A2";
                                a2.Content = "S1";
                                a3.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P")
                            {
                                b3.IsEnabled = true;
                                b3.Click += B3_Click;
                                controllo = true;
                            }
                            if (a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P")
                            {
                                a4.IsEnabled = true;
                                a4.Click += A4_Click;
                                controllo = true;
                            }
                            if (a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P" && a1.Content.ToString() != "CA" && a1.Content.ToString() != "CO" && a1.Content.ToString() != "S1" && a1.Content.ToString() != "S2" && a1.Content.ToString() != "P")
                            {
                                a2.IsEnabled = true;
                                a2.Click += A2_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a3.Content = "S2";
                                VettSottomarino2[0] = "A3";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a2")
                            {
                                VettSottomarino2[1] = "A3";
                                VettSottomarino2[2] = "A4";
                                a2.Content = "S2";
                                a3.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a4")
                            {
                                VettSottomarino2[1] = "A3";
                                VettSottomarino2[2] = "A2";
                                a2.Content = "S2";
                                a1.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P" && d3.Content.ToString() != "CA" && d3.Content.ToString() != "CO" && d3.Content.ToString() != "S1" && d3.Content.ToString() != "S2" && d3.Content.ToString() != "P")
                        {
                            b3.IsEnabled = true;
                            b3.Click += B3_Click;
                            controllo = true;
                        }
                        if (a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P")
                        {
                            a4.IsEnabled = true;
                            a4.Click += A4_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a3.Content = "CO";
                            VettCorazzate[0] = "A3";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a2")
                        {
                            VettCorazzate[1] = "A3";
                            VettCorazzate[2] = "A4";
                            VettCorazzate[2] = "A5";
                            a3.Content = "CO";
                            a4.Content = "CO";
                            a5.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "a4")
                        {
                            VettSottomarino1[1] = "A3";
                            VettSottomarino1[2] = "A2";
                            VettSottomarino1[2] = "A1";
                            a1.Content = "CO";
                            a2.Content = "CO";
                            a3.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P" && d3.Content.ToString() != "CA" && d3.Content.ToString() != "CO" && d3.Content.ToString() != "S1" && d3.Content.ToString() != "S2" && d3.Content.ToString() != "P" && e3.Content.ToString() != "CA" && e3.Content.ToString() != "CO" && e3.Content.ToString() != "S1" && e3.Content.ToString() != "S2" && e3.Content.ToString() != "P")
                        {
                            b3.IsEnabled = true;
                            b3.Click += B3_Click;
                            controllo = true;
                        }
                        if (a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P")
                        {
                            a4.IsEnabled = true;
                            a4.Click += A4_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a3.Content = "P";
                            VettPortaerei[0] = "A3";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        VettPortaerei[1] = "A3";
                        VettPortaerei[2] = "A4";
                        VettPortaerei[3] = "A5";
                        VettPortaerei[4] = "A6";
                        a3.Content = "P";
                        a4.Content = "P";
                        a5.Content = "P";
                        a6.Content = "P";
                        btnConferma.IsEnabled = true;
                    }

                }
                bottoneScelto = "a3";
                c = true;
            }
            else
                c = false;
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P")
                        {
                            b4.IsEnabled = true;
                            b4.Click += B4_Click;
                            controllo = true;
                        }
                        if (a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P")
                        {
                            a3.IsEnabled = true;
                            a3.Click += A3_Click;
                            controllo = true;
                        }
                        if (a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P")
                        {
                            a5.IsEnabled = true;
                            a5.Click += A5_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a4.Content = "CA";
                            VettCacciatorpediniere[0] = "A4";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        a4.Content = "CA";
                        VettCacciatorpediniere[1] = "A4";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P")
                            {
                                b4.IsEnabled = true;
                                b4.Click += B4_Click;
                                controllo = true;
                            }
                            if (a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P")
                            {
                                a5.IsEnabled = true;
                                a5.Click += A5_Click;
                                controllo = true;
                            }
                            if (a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P" && a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P")
                            {
                                a3.IsEnabled = true;
                                a3.Click += A3_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a4.Content = "S1";
                                VettSottomarino1[0] = "A4";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a3")
                            {
                                VettSottomarino1[1] = "A4";
                                VettSottomarino1[2] = "A5";
                                a4.Content = "S1";
                                a5.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a5")
                            {
                                VettSottomarino1[1] = "A4";
                                VettSottomarino1[2] = "A3";
                                a4.Content = "S1";
                                a3.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P")
                            {
                                b4.IsEnabled = true;
                                b4.Click += B4_Click;
                                controllo = true;
                            }
                            if (a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P")
                            {
                                a5.IsEnabled = true;
                                a5.Click += A5_Click;
                                controllo = true;
                            }
                            if (a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P" && a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P")
                            {
                                a3.IsEnabled = true;
                                a3.Click += A3_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a4.Content = "S2";
                                VettSottomarino2[0] = "A4";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a3")
                            {
                                VettSottomarino2[1] = "A4";
                                VettSottomarino2[2] = "A5";
                                a4.Content = "S2";
                                a5.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a5")
                            {
                                VettSottomarino2[1] = "A4";
                                VettSottomarino2[2] = "A3";
                                a4.Content = "S2";
                                a3.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P" && d4.Content.ToString() != "CA" && d4.Content.ToString() != "CO" && d4.Content.ToString() != "S1" && d4.Content.ToString() != "S2" && d4.Content.ToString() != "P")
                        {
                            b4.IsEnabled = true;
                            b4.Click += B4_Click;
                            controllo = true;
                        }
                        if (a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P")
                        {
                            a5.IsEnabled = true;
                            a5.Click += A5_Click;
                            controllo = true;
                        }
                        if (a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P" && a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P" && a1.Content.ToString() != "CA" && a1.Content.ToString() != "CO" && a1.Content.ToString() != "S1" && a1.Content.ToString() != "S2" && a1.Content.ToString() != "P")
                        {
                            a3.IsEnabled = true;
                            a3.Click += A3_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a4.Content = "CO";
                            VettCorazzate[0] = "A4";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a3")
                        {
                            VettCorazzate[1] = "A4";
                            VettCorazzate[2] = "A5";
                            VettCorazzate[3] = "A6";
                            a4.Content = "CO";
                            a5.Content = "CO";
                            a6.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "a5")
                        {
                            VettCorazzate[1] = "A4";
                            VettCorazzate[2] = "A3";
                            VettCorazzate[3] = "A2";
                            a4.Content = "CO";
                            a2.Content = "CO";
                            a3.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P" && d4.Content.ToString() != "CA" && d4.Content.ToString() != "CO" && d4.Content.ToString() != "S1" && d4.Content.ToString() != "S2" && d4.Content.ToString() != "P" && e4.Content.ToString() != "CA" && e4.Content.ToString() != "CO" && e4.Content.ToString() != "S1" && e4.Content.ToString() != "S2" && e4.Content.ToString() != "P")
                        {
                            b4.IsEnabled = true;
                            b4.Click += B4_Click;
                            controllo = true;
                        }
                        if (a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P")
                        {
                            a5.IsEnabled = true;
                            a5.Click += A5_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a4.Content = "P";
                            VettPortaerei[0] = "A4";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a3")
                        {
                            VettPortaerei[1] = "A4";
                            VettPortaerei[2] = "A5";
                            VettPortaerei[3] = "A6";
                            VettPortaerei[4] = "A7";
                            a4.Content = "P";
                            a5.Content = "P";
                            a6.Content = "P";
                            a7.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "a5")
                        {
                            VettPortaerei[1] = "A4";
                            VettPortaerei[2] = "A3";
                            VettPortaerei[3] = "A2";
                            VettPortaerei[4] = "A1";
                            a4.Content = "P";
                            a3.Content = "P";
                            a2.Content = "P";
                            a1.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                    }

                }
                bottoneScelto = "a4";
                c = true;
            }
            else
                c = false;
        }

        private void A5_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P")
                        {
                            a4.IsEnabled = true;
                            a4.Click += A4_Click;
                            controllo = true;
                        }
                        if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P")
                        {
                            b5.IsEnabled = true;
                            b5.Click += B5_Click;
                            controllo = true;
                        }
                        if (a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P")
                        {
                            a6.IsEnabled = true;
                            a6.Click += A6_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a5.Content = "CA";
                            VettCacciatorpediniere[0] = "A5";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        a5.Content = "CA";
                        VettCacciatorpediniere[1] = "A5";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && c5.Content.ToString() != "CA" && c5.Content.ToString() != "CO" && c5.Content.ToString() != "S1" && c5.Content.ToString() != "S2" && c5.Content.ToString() != "P")
                            {
                                b5.IsEnabled = true;
                                b5.Click += B5_Click;
                                controllo = true;
                            }
                            if (a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P")
                            {
                                a6.IsEnabled = true;
                                a6.Click += A6_Click;
                                controllo = true;
                            }
                            if (a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P")
                            {
                                a4.IsEnabled = true;
                                a4.Click += A4_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a5.Content = "S1";
                                VettSottomarino1[0] = "A5";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a4")
                            {
                                VettSottomarino1[1] = "A5";
                                VettSottomarino1[2] = "A6";
                                a5.Content = "S1";
                                a6.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a6")
                            {
                                VettSottomarino1[1] = "A5";
                                VettSottomarino1[2] = "A4";
                                a5.Content = "S1";
                                a4.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && c5.Content.ToString() != "CA" && c5.Content.ToString() != "CO" && c5.Content.ToString() != "S1" && c5.Content.ToString() != "S2" && c5.Content.ToString() != "P")
                            {
                                b5.IsEnabled = true;
                                b5.Click += B5_Click;
                                controllo = true;
                            }
                            if (a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P")
                            {
                                a6.IsEnabled = true;
                                a6.Click += A6_Click;
                                controllo = true;
                            }
                            if (a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P")
                            {
                                a4.IsEnabled = true;
                                a4.Click += A4_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a5.Content = "S2";
                                VettSottomarino2[0] = "A5";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a4")
                            {
                                VettSottomarino2[1] = "A5";
                                VettSottomarino2[2] = "A6";
                                a5.Content = "S2";
                                a6.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a6")
                            {
                                VettSottomarino2[1] = "A5";
                                VettSottomarino2[2] = "A4";
                                a5.Content = "S2";
                                a4.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && c5.Content.ToString() != "CA" && c5.Content.ToString() != "CO" && c5.Content.ToString() != "S1" && c5.Content.ToString() != "S2" && c5.Content.ToString() != "P" && d5.Content.ToString() != "CA" && d5.Content.ToString() != "CO" && d5.Content.ToString() != "S1" && d5.Content.ToString() != "S2" && d5.Content.ToString() != "P")
                        {
                            b5.IsEnabled = true;
                            b5.Click += B5_Click;
                            controllo = true;
                        }
                        if (a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P")
                        {
                            a6.IsEnabled = true;
                            a6.Click += A6_Click;
                            controllo = true;
                        }
                        if (a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P" && a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P")
                        {
                            a4.IsEnabled = true;
                            a4.Click += A4_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a5.Content = "CO";
                            VettCorazzate[0] = "A5";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a4")
                        {
                            VettCorazzate[1] = "A5";
                            VettCorazzate[2] = "A6";
                            VettCorazzate[3] = "A7";
                            a5.Content = "CO";
                            a6.Content = "CO";
                            a7.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "a6")
                        {
                            VettSottomarino1[1] = "A5";
                            VettSottomarino1[2] = "A4";
                            VettSottomarino1[3] = "A3";
                            a5.Content = "CO";
                            a4.Content = "CO";
                            a3.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && c5.Content.ToString() != "CA" && c5.Content.ToString() != "CO" && c5.Content.ToString() != "S1" && c5.Content.ToString() != "S2" && c5.Content.ToString() != "P" && d5.Content.ToString() != "CA" && d5.Content.ToString() != "CO" && d5.Content.ToString() != "S1" && d5.Content.ToString() != "S2" && d5.Content.ToString() != "P" && e5.Content.ToString() != "CA" && e5.Content.ToString() != "CO" && e5.Content.ToString() != "S1" && e5.Content.ToString() != "S2" && e5.Content.ToString() != "P")
                        {
                            b5.IsEnabled = true;
                            b5.Click += B5_Click;
                            controllo = true;
                        }
                        if (a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P" && a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a9.Content.ToString() != "S2" && a9.Content.ToString() != "P")
                        {
                            a6.IsEnabled = true;
                            a6.Click += A6_Click;
                            controllo = true;
                        }
                        if (a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P" && a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P" && a1.Content.ToString() != "CA" && a1.Content.ToString() != "CO" && a1.Content.ToString() != "S1" && a1.Content.ToString() != "S2" && a1.Content.ToString() != "P")
                        {
                            a4.IsEnabled = true;
                            a4.Click += A4_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a5.Content = "P";
                            VettPortaerei[0] = "A5";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a4")
                        {
                            VettPortaerei[1] = "A5";
                            VettPortaerei[2] = "A6";
                            VettPortaerei[3] = "A7";
                            VettPortaerei[4] = "A8";
                            a5.Content = "P";
                            a6.Content = "P";
                            a7.Content = "P";
                            a8.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "a6")
                        {
                            VettPortaerei[1] = "A5";
                            VettPortaerei[2] = "A4";
                            VettPortaerei[3] = "A3";
                            VettPortaerei[4] = "A2";
                            a4.Content = "P";
                            a3.Content = "P";
                            a2.Content = "P";
                            a5.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                    }

                }
                bottoneScelto = "a5";
                c = true;
            }
            else
                c = false;
        }

        private void A6_Click(object sender, RoutedEventArgs e)

        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P")
                        {
                            a5.IsEnabled = true;
                            a5.Click += A5_Click;
                            controllo = true;
                        }
                        if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P")
                        {
                            b6.IsEnabled = true;
                            b6.Click += B6_Click;
                            controllo = true;
                        }
                        if (a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P")
                        {
                            a7.IsEnabled = true;
                            a7.Click += A7_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a6.Content = "CA";
                            VettCacciatorpediniere[0] = "A6";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        a6.Content = "CA";
                        VettCacciatorpediniere[1] = "A6";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && c6.Content.ToString() != "CA" && c6.Content.ToString() != "CO" && c6.Content.ToString() != "S1" && c6.Content.ToString() != "S2" && c6.Content.ToString() != "P")
                            {
                                b6.IsEnabled = true;
                                b6.Click += B6_Click;
                                controllo = true;
                            }
                            if (a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P")
                            {
                                a7.IsEnabled = true;
                                a7.Click += A7_Click;
                                controllo = true;
                            }
                            if (a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P")
                            {
                                a5.IsEnabled = true;
                                a5.Click += A5_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a6.Content = "S1";
                                VettSottomarino1[0] = "A6";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a5")
                            {
                                VettSottomarino1[1] = "A6";
                                VettSottomarino1[2] = "A7";
                                a7.Content = "S1";
                                a6.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a7")
                            {
                                VettSottomarino1[1] = "A6";
                                VettSottomarino1[2] = "A5";
                                a5.Content = "S1";
                                a6.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && c6.Content.ToString() != "CA" && c6.Content.ToString() != "CO" && c6.Content.ToString() != "S1" && c6.Content.ToString() != "S2" && c6.Content.ToString() != "P")
                            {
                                b5.IsEnabled = true;
                                b5.Click += B5_Click;
                                controllo = true;
                            }
                            if (a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P")
                            {
                                a6.IsEnabled = true;
                                a6.Click += A6_Click;
                                controllo = true;
                            }
                            if (a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P")
                            {
                                a5.IsEnabled = true;
                                a5.Click += A5_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a6.Content = "S2";
                                VettSottomarino2[0] = "A6";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a5")
                            {
                                VettSottomarino2[1] = "A6";
                                VettSottomarino2[2] = "A7";
                                a7.Content = "S2";
                                a6.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a7")
                            {
                                VettSottomarino2[1] = "A6";
                                VettSottomarino2[2] = "A5";
                                a5.Content = "S2";
                                a6.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && c6.Content.ToString() != "CA" && c6.Content.ToString() != "CO" && c6.Content.ToString() != "S1" && c6.Content.ToString() != "S2" && c6.Content.ToString() != "P" && d6.Content.ToString() != "CA" && d6.Content.ToString() != "CO" && d6.Content.ToString() != "S1" && d6.Content.ToString() != "S2" && d6.Content.ToString() != "P")
                        {
                            b6.IsEnabled = true;
                            b6.Click += B6_Click;
                            controllo = true;
                        }
                        if (a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P" && a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a9.Content.ToString() != "P")
                        {
                            a7.IsEnabled = true;
                            a7.Click += A7_Click;
                            controllo = true;
                        }
                        if (a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P")
                        {
                            a5.IsEnabled = true;
                            a5.Click += A5_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a6.Content = "CO";
                            VettCorazzate[0] = "A6";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a5")
                        {
                            VettCorazzate[1] = "A6";
                            VettCorazzate[2] = "A7";
                            VettCorazzate[3] = "A8";
                            a8.Content = "CO";
                            a6.Content = "CO";
                            a7.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "a7")
                        {
                            VettSottomarino1[1] = "A6";
                            VettSottomarino1[2] = "A5";
                            VettSottomarino1[3] = "A4";
                            a5.Content = "CO";
                            a4.Content = "CO";
                            a6.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && c6.Content.ToString() != "CA" && c6.Content.ToString() != "CO" && c6.Content.ToString() != "S1" && c6.Content.ToString() != "S2" && c6.Content.ToString() != "P" && d6.Content.ToString() != "CA" && d6.Content.ToString() != "CO" && d6.Content.ToString() != "S1" && d6.Content.ToString() != "S2" && d6.Content.ToString() != "P" && e6.Content.ToString() != "CA" && e6.Content.ToString() != "CO" && e6.Content.ToString() != "S1" && e6.Content.ToString() != "S2" && e6.Content.ToString() != "P")
                        {
                            b6.IsEnabled = true;
                            b6.Click += B6_Click;
                            controllo = true;
                        }
                        if (a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P" && a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a9.Content.ToString() != "P" && a10.Content.ToString() != "CA" && a10.Content.ToString() != "CO" && a10.Content.ToString() != "S1" && a10.Content.ToString() != "S2" && a9.Content.ToString() != "P")
                        {
                            a7.IsEnabled = true;
                            a7.Click += A7_Click;
                            controllo = true;
                        }
                        if (a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P" && a2.Content.ToString() != "CA" && a2.Content.ToString() != "CO" && a2.Content.ToString() != "S1" && a2.Content.ToString() != "S2" && a2.Content.ToString() != "P")
                        {
                            a5.IsEnabled = true;
                            a5.Click += A5_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a6.Content = "P";
                            VettPortaerei[0] = "A6";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a5")
                        {
                            VettPortaerei[1] = "A6";
                            VettPortaerei[2] = "A7";
                            VettPortaerei[3] = "A8";
                            VettPortaerei[4] = "A9";
                            a9.Content = "P";
                            a6.Content = "P";
                            a7.Content = "P";
                            a8.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "a7")
                        {
                            VettPortaerei[1] = "A6";
                            VettPortaerei[2] = "A5";
                            VettPortaerei[3] = "A4";
                            VettPortaerei[4] = "A3";
                            a4.Content = "P";
                            a3.Content = "P";
                            a6.Content = "P";
                            a5.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                    }

                }
                bottoneScelto = "a6";
                c = true;
            }
            else
                c = false;
        }

        private void A7_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P")
                        {
                            a6.IsEnabled = true;
                            a6.Click += A6_Click;
                            controllo = true;
                        }
                        if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P")
                        {
                            b7.IsEnabled = true;
                            b7.Click += B7_Click;
                            controllo = true;
                        }
                        if (a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P")
                        {
                            a8.IsEnabled = true;
                            a8.Click += A8_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a7.Content = "CA";
                            VettCacciatorpediniere[0] = "A7";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        a7.Content = "CA";
                        VettCacciatorpediniere[1] = "A7";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && c7.Content.ToString() != "CA" && c7.Content.ToString() != "CO" && c7.Content.ToString() != "S1" && c7.Content.ToString() != "S2" && c7.Content.ToString() != "P")
                            {
                                b7.IsEnabled = true;
                                b7.Click += B7_Click;
                                controllo = true;
                            }
                            if (a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P" && a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a9.Content.ToString() != "S2" && a9.Content.ToString() != "P")
                            {
                                a8.IsEnabled = true;
                                a8.Click += A8_Click;
                                controllo = true;
                            }
                            if (a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P")
                            {
                                a6.IsEnabled = true;
                                a6.Click += A6_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a7.Content = "S1";
                                VettSottomarino1[0] = "A7";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a6")
                            {
                                VettSottomarino1[1] = "A7";
                                VettSottomarino1[2] = "A8";
                                a7.Content = "S1";
                                a8.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a8")
                            {
                                VettSottomarino1[1] = "A7";
                                VettSottomarino1[2] = "A6";
                                a7.Content = "S1";
                                a6.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && c7.Content.ToString() != "CA" && c7.Content.ToString() != "CO" && c7.Content.ToString() != "S1" && c7.Content.ToString() != "S2" && c7.Content.ToString() != "P")
                            {
                                b7.IsEnabled = true;
                                b7.Click += B7_Click;
                                controllo = true;
                            }
                            if (a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P" && a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a9.Content.ToString() != "S2" && a9.Content.ToString() != "P")
                            {
                                a8.IsEnabled = true;
                                a8.Click += A8_Click;
                                controllo = true;
                            }
                            if (a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P")
                            {
                                a6.IsEnabled = true;
                                a6.Click += A6_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a7.Content = "S2";
                                VettSottomarino2[0] = "A7";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a6")
                            {
                                VettSottomarino2[1] = "A7";
                                VettSottomarino2[2] = "A8";
                                a7.Content = "S2";
                                a8.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a8")
                            {
                                VettSottomarino2[1] = "A7";
                                VettSottomarino2[2] = "A6";
                                a7.Content = "S2";
                                a6.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && c7.Content.ToString() != "CA" && c7.Content.ToString() != "CO" && c7.Content.ToString() != "S1" && c7.Content.ToString() != "S2" && c7.Content.ToString() != "P" && d7.Content.ToString() != "CA" && d7.Content.ToString() != "CO" && d7.Content.ToString() != "S1" && d7.Content.ToString() != "S2" && d7.Content.ToString() != "P")
                        {
                            b7.IsEnabled = true;
                            b7.Click += B7_Click;
                            controllo = true;
                        }
                        if (a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P" && a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a9.Content.ToString() != "P" && a10.Content.ToString() != "CA" && a10.Content.ToString() != "CO" && a10.Content.ToString() != "S1" && a10.Content.ToString() != "S2" && a10.Content.ToString() != "P")
                        {
                            a8.IsEnabled = true;
                            a8.Click += A8_Click;
                            controllo = true;
                        }
                        if (a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P")
                        {
                            a6.IsEnabled = true;
                            a6.Click += A6_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a7.Content = "CO";
                            VettCorazzate[0] = "A7";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a6")
                        {
                            VettCorazzate[1] = "A7";
                            VettCorazzate[2] = "A8";
                            VettCorazzate[3] = "A9";
                            a8.Content = "CO";
                            a9.Content = "CO";
                            a7.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "a8")
                        {
                            VettCorazzate[1] = "A7";
                            VettCorazzate[2] = "A6";
                            VettCorazzate[3] = "A5";
                            a5.Content = "CO";
                            a7.Content = "CO";
                            a6.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && c7.Content.ToString() != "CA" && c7.Content.ToString() != "CO" && c7.Content.ToString() != "S1" && c7.Content.ToString() != "S2" && c7.Content.ToString() != "P" && d7.Content.ToString() != "CA" && d7.Content.ToString() != "CO" && d7.Content.ToString() != "S1" && d7.Content.ToString() != "S2" && d7.Content.ToString() != "P" && e7.Content.ToString() != "CA" && e7.Content.ToString() != "CO" && e7.Content.ToString() != "S1" && e7.Content.ToString() != "S2" && e7.Content.ToString() != "P")
                        {
                            b7.IsEnabled = true;
                            b7.Click += B7_Click;
                            controllo = true;
                        }
                        if (a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P" && a3.Content.ToString() != "CA" && a3.Content.ToString() != "CO" && a3.Content.ToString() != "S1" && a3.Content.ToString() != "S2" && a3.Content.ToString() != "P")
                        {
                            a6.IsEnabled = true;
                            a6.Click += A6_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a7.Content = "P";
                            VettPortaerei[0] = "A7";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        VettPortaerei[1] = "A7";
                        VettPortaerei[2] = "A6";
                        VettPortaerei[3] = "A5";
                        VettPortaerei[4] = "A4";
                        a5.Content = "P";
                        a6.Content = "P";
                        a4.Content = "P";
                        a7.Content = "P";
                        btnConferma.IsEnabled = true;
                    }

                }
                bottoneScelto = "a7";
                c = true;
            }
            else
                c = false;
        }

        private void A8_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P")
                        {
                            a7.IsEnabled = true;
                            a7.Click += A7_Click;
                            controllo = true;
                        }
                        if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P")
                        {
                            b8.IsEnabled = true;
                            b8.Click += B8_Click;
                            controllo = true;
                        }
                        if (a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a9.Content.ToString() != "S2" && a9.Content.ToString() != "P")
                        {
                            a9.IsEnabled = true;
                            a9.Click += A9_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a8.Content = "CA";
                            VettCacciatorpediniere[0] = "A8";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        a8.Content = "CA";
                        VettCacciatorpediniere[1] = "A8";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && c8.Content.ToString() != "CA" && c8.Content.ToString() != "CO" && c8.Content.ToString() != "S1" && c8.Content.ToString() != "S2" && c8.Content.ToString() != "P")
                            {
                                b8.IsEnabled = true;
                                b8.Click += B8_Click;
                                controllo = true;
                            }
                            if (a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a9.Content.ToString() != "S2" && a9.Content.ToString() != "P" && a10.Content.ToString() != "CA" && a10.Content.ToString() != "CO" && a10.Content.ToString() != "S1" && a10.Content.ToString() != "S2" && a10.Content.ToString() != "P")
                            {
                                a9.IsEnabled = true;
                                a9.Click += A9_Click;
                                controllo = true;
                            }
                            if (a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P")
                            {
                                a7.IsEnabled = true;
                                a7.Click += A7_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a8.Content = "S1";
                                VettSottomarino1[0] = "A8";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a7")
                            {
                                VettSottomarino1[1] = "A8";
                                VettSottomarino1[2] = "A9";
                                a9.Content = "S1";
                                a8.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a9")
                            {
                                VettSottomarino1[1] = "A8";
                                VettSottomarino1[2] = "A7";
                                a7.Content = "S1";
                                a8.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && c8.Content.ToString() != "CA" && c8.Content.ToString() != "CO" && c8.Content.ToString() != "S1" && c8.Content.ToString() != "S2" && c8.Content.ToString() != "P")
                            {
                                b8.IsEnabled = true;
                                b8.Click += B8_Click;
                                controllo = true;
                            }
                            if (a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a9.Content.ToString() != "S2" && a9.Content.ToString() != "P" && a10.Content.ToString() != "CA" && a10.Content.ToString() != "CO" && a10.Content.ToString() != "S1" && a10.Content.ToString() != "S2" && a10.Content.ToString() != "P")
                            {
                                a9.IsEnabled = true;
                                a9.Click += A9_Click;
                                controllo = true;
                            }
                            if (a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P")
                            {
                                a7.IsEnabled = true;
                                a7.Click += A7_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a8.Content = "S1";
                                VettSottomarino1[0] = "A8";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a7")
                            {
                                VettSottomarino2[1] = "A8";
                                VettSottomarino2[2] = "A9";
                                a9.Content = "S2";
                                a8.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a9")
                            {
                                VettSottomarino2[1] = "A8";
                                VettSottomarino2[2] = "A7";
                                a7.Content = "S2";
                                a8.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && c8.Content.ToString() != "CA" && c8.Content.ToString() != "CO" && c8.Content.ToString() != "S1" && c8.Content.ToString() != "S2" && c8.Content.ToString() != "P" && d8.Content.ToString() != "CA" && d8.Content.ToString() != "CO" && d8.Content.ToString() != "S1" && d8.Content.ToString() != "S2" && d8.Content.ToString() != "P")
                        {
                            b8.IsEnabled = true;
                            b8.Click += B8_Click;
                            controllo = true;
                        }
                        if (a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P")
                        {
                            a7.IsEnabled = true;
                            a7.Click += A7_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a8.Content = "CO";
                            VettCorazzate[0] = "A8";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a7")
                        {
                            VettCorazzate[1] = "A8";
                            VettCorazzate[2] = "A9";
                            VettCorazzate[3] = "A10";
                            a8.Content = "CO";
                            a9.Content = "CO";
                            a10.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "a9")
                        {
                            VettCorazzate[1] = "A8";
                            VettCorazzate[2] = "A7";
                            VettCorazzate[3] = "A6";
                            a8.Content = "CO";
                            a7.Content = "CO";
                            a6.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && c8.Content.ToString() != "CA" && c8.Content.ToString() != "CO" && c8.Content.ToString() != "S1" && c8.Content.ToString() != "S2" && c8.Content.ToString() != "P" && d8.Content.ToString() != "CA" && d8.Content.ToString() != "CO" && d8.Content.ToString() != "S1" && d8.Content.ToString() != "S2" && d8.Content.ToString() != "P" && e8.Content.ToString() != "CA" && e8.Content.ToString() != "CO" && e8.Content.ToString() != "S1" && e8.Content.ToString() != "S2" && e8.Content.ToString() != "P")
                        {
                            b8.IsEnabled = true;
                            b8.Click += B8_Click;
                            controllo = true;
                        }
                        if (a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P" && a4.Content.ToString() != "CA" && a4.Content.ToString() != "CO" && a4.Content.ToString() != "S1" && a4.Content.ToString() != "S2" && a4.Content.ToString() != "P")
                        {
                            a7.IsEnabled = true;
                            a7.Click += A7_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a8.Content = "P";
                            VettPortaerei[0] = "A8";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        VettPortaerei[1] = "A8";
                        VettPortaerei[2] = "A7";
                        VettPortaerei[3] = "A6";
                        VettPortaerei[4] = "A5";
                        a5.Content = "P";
                        a6.Content = "P";
                        a8.Content = "P";
                        a7.Content = "P";
                        btnConferma.IsEnabled = true;
                    }

                }
                bottoneScelto = "a8";
                c = true;
            }
            else
                c = false;
        }

        private void A9_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P")
                        {
                            a8.IsEnabled = true;
                            a8.Click += A8_Click;
                            controllo = true;
                        }
                        if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P")
                        {
                            b9.IsEnabled = true;
                            b9.Click += B9_Click;
                            controllo = true;
                        }
                        if (a10.Content.ToString() != "CA" && a10.Content.ToString() != "CO" && a10.Content.ToString() != "S1" && a10.Content.ToString() != "S2" && a10.Content.ToString() != "P")
                        {
                            a10.IsEnabled = true;
                            a10.Click += A10_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a9.Content = "CA";
                            VettCacciatorpediniere[0] = "A9";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        a9.Content = "CA";
                        VettCacciatorpediniere[1] = "A9";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && c9.Content.ToString() != "CA" && c9.Content.ToString() != "CO" && c9.Content.ToString() != "S1" && c9.Content.ToString() != "S2" && c9.Content.ToString() != "P")
                            {
                                b9.IsEnabled = true;
                                b9.Click += B9_Click;
                                controllo = true;
                            }
                            if (a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P")
                            {
                                a8.IsEnabled = true;
                                a8.Click += A8_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a9.Content = "S1";
                                VettSottomarino1[0] = "A9";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a8")
                            {
                                VettSottomarino1[1] = "A9";
                                VettSottomarino1[2] = "A10";
                                a9.Content = "S1";
                                a10.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a10")
                            {
                                VettSottomarino1[1] = "A9";
                                VettSottomarino1[2] = "A8";
                                a9.Content = "S1";
                                a8.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && c9.Content.ToString() != "CA" && c9.Content.ToString() != "CO" && c9.Content.ToString() != "S1" && c9.Content.ToString() != "S2" && c9.Content.ToString() != "P")
                            {
                                b9.IsEnabled = true;
                                b9.Click += B9_Click;
                                controllo = true;
                            }
                            if (a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P")
                            {
                                a8.IsEnabled = true;
                                a8.Click += A8_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a9.Content = "S1";
                                VettSottomarino1[0] = "A9";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a9")
                            {
                                VettSottomarino2[1] = "A9";
                                VettSottomarino2[2] = "A10";
                                a9.Content = "S2";
                                a10.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "a10")
                            {
                                VettSottomarino2[1] = "A9";
                                VettSottomarino2[2] = "A8";
                                a9.Content = "S2";
                                a8.Content = "s2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && c9.Content.ToString() != "CA" && c9.Content.ToString() != "CO" && c9.Content.ToString() != "S1" && c9.Content.ToString() != "S2" && c9.Content.ToString() != "P" && d9.Content.ToString() != "CA" && d9.Content.ToString() != "CO" && d9.Content.ToString() != "S1" && d9.Content.ToString() != "S2" && d9.Content.ToString() != "P")
                        {
                            b9.IsEnabled = true;
                            b9.Click += B9_Click;
                            controllo = true;
                        }
                        if (a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P")
                        {
                            a8.IsEnabled = true;
                            a8.Click += A8_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a9.Content = "CO";
                            VettCorazzate[0] = "A9";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        VettCorazzate[1] = "A9";
                        VettCorazzate[2] = "A8";
                        VettCorazzate[3] = "A7";
                        a8.Content = "CO";
                        a7.Content = "CO";
                        a9.Content = "CO";
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && c9.Content.ToString() != "CA" && c9.Content.ToString() != "CO" && c9.Content.ToString() != "S1" && c9.Content.ToString() != "S2" && c9.Content.ToString() != "P" && d9.Content.ToString() != "CA" && d9.Content.ToString() != "CO" && d9.Content.ToString() != "S1" && d9.Content.ToString() != "S2" && d9.Content.ToString() != "P" && e9.Content.ToString() != "CA" && e9.Content.ToString() != "CO" && e9.Content.ToString() != "S1" && e9.Content.ToString() != "S2" && e9.Content.ToString() != "P")
                        {
                            b9.IsEnabled = true;
                            b9.Click += B9_Click;
                            controllo = true;
                        }
                        if (a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P" && a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P")
                        {
                            a8.IsEnabled = true;
                            a8.Click += A8_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a9.Content = "P";
                            VettPortaerei[0] = "A9";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        VettPortaerei[1] = "A9";
                        VettPortaerei[2] = "A8";
                        VettPortaerei[3] = "A7";
                        VettPortaerei[4] = "A6";
                        a9.Content = "P";
                        a6.Content = "P";
                        a8.Content = "P";
                        a7.Content = "P";
                        btnConferma.IsEnabled = true;
                    }

                }
                bottoneScelto = "a9";
                c = true;
            }
            else
                c = false;
        }

        private void A10_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a9.Content.ToString() != "S2" && a9.Content.ToString() != "P")
                        {
                            a9.IsEnabled = true;
                            a9.Click += A9_Click;
                            controllo = true;
                        }
                        if (b10.Content.ToString() != "CA" && b10.Content.ToString() != "CO" && b10.Content.ToString() != "S1" && b10.Content.ToString() != "S2" && b10.Content.ToString() != "P")
                        {
                            b10.IsEnabled = true;
                            b10.Click += B10_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a10.Content = "CA";
                            VettCacciatorpediniere[0] = "A10";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        a10.Content = "CA";
                        VettCacciatorpediniere[1] = "A10";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b10.Content.ToString() != "CA" && b10.Content.ToString() != "CO" && b10.Content.ToString() != "S1" && b10.Content.ToString() != "S2" && b10.Content.ToString() != "P" && c10.Content.ToString() != "CA" && c10.Content.ToString() != "CO" && c10.Content.ToString() != "S1" && c10.Content.ToString() != "S2" && c10.Content.ToString() != "P")
                            {
                                b10.IsEnabled = true;
                                b10.Click += B10_Click;
                                controllo = true;
                            }
                            if (a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a9.Content.ToString() != "S2" && a9.Content.ToString() != "P" && a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P")
                            {
                                a9.IsEnabled = true;
                                a9.Click += A9_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a10.Content = "S1";
                                VettSottomarino1[0] = "A10";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b10.Content.ToString() != "CA" && b10.Content.ToString() != "CO" && b10.Content.ToString() != "S1" && b10.Content.ToString() != "S2" && b10.Content.ToString() != "P" && c10.Content.ToString() != "CA" && c10.Content.ToString() != "CO" && c10.Content.ToString() != "S1" && c10.Content.ToString() != "S2" && c10.Content.ToString() != "P")
                            {
                                b10.IsEnabled = true;
                                b10.Click += B10_Click;
                                controllo = true;
                            }
                            if (a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a9.Content.ToString() != "S2" && a9.Content.ToString() != "P" && a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P")
                            {
                                a9.IsEnabled = true;
                                a9.Click += A9_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                a10.Content = "S1";
                                VettSottomarino2[0] = "A10";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b10.Content.ToString() != "CA" && b10.Content.ToString() != "CO" && b10.Content.ToString() != "S1" && b10.Content.ToString() != "S2" && b10.Content.ToString() != "P" && c10.Content.ToString() != "CA" && c10.Content.ToString() != "CO" && c10.Content.ToString() != "S1" && c10.Content.ToString() != "S2" && c10.Content.ToString() != "P" && d10.Content.ToString() != "CA" && d10.Content.ToString() != "CO" && d10.Content.ToString() != "S1" && d10.Content.ToString() != "S2" && d10.Content.ToString() != "P")
                        {
                            b10.IsEnabled = true;
                            b10.Click += B10_Click;
                            controllo = true;
                        }
                        if (a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a9.Content.ToString() != "S2" && a9.Content.ToString() != "P" && a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P")
                        {
                            a9.IsEnabled = true;
                            a9.Click += A9_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a10.Content = "CO";
                            VettCorazzate[0] = "A10";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b10.Content.ToString() != "CA" && b10.Content.ToString() != "CO" && b10.Content.ToString() != "S1" && b10.Content.ToString() != "S2" && b10.Content.ToString() != "P" && c10.Content.ToString() != "CA" && c10.Content.ToString() != "CO" && c10.Content.ToString() != "S1" && c10.Content.ToString() != "S2" && c10.Content.ToString() != "P" && d10.Content.ToString() != "CA" && d10.Content.ToString() != "CO" && d10.Content.ToString() != "S1" && d10.Content.ToString() != "S2" && d10.Content.ToString() != "P" && e10.Content.ToString() != "CA" && e10.Content.ToString() != "CO" && e10.Content.ToString() != "S1" && e10.Content.ToString() != "S2" && e10.Content.ToString() != "P")
                        {
                            b10.IsEnabled = true;
                            b10.Click += B10_Click;
                            controllo = true;
                        }
                        if (a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a9.Content.ToString() != "S2" && a9.Content.ToString() != "P" && a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P" && a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P" && a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P")
                        {
                            a9.IsEnabled = true;
                            a9.Click += A9_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            a10.Content = "P";
                            VettPortaerei[0] = "A10";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                    }

                }
                bottoneScelto = "a10";
                c = true;
            }
            else
                c = false;
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P")
                        {
                            b2.IsEnabled = true;
                            b2.Click += B2_Click;
                            controllo = true;
                        }
                        if (a1.Content.ToString() != "CA" && a1.Content.ToString() != "CO" && a1.Content.ToString() != "S1" && a1.Content.ToString() != "S2" && a1.Content.ToString() != "P")
                        {
                            a1.IsEnabled = true;
                            a1.Click += A1_Click;
                            controllo = true;
                        }
                        if (c1.Content.ToString() != "CA" && c1.Content.ToString() != "CO" && c1.Content.ToString() != "S1" && c1.Content.ToString() != "S2" && c1.Content.ToString() != "P")
                        {
                            c1.IsEnabled = true;
                            c1.Click += C1_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b1.Content = "CA";
                            VettCacciatorpediniere[0] = "B1";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        b1.Content = "CA";
                        VettCacciatorpediniere[1] = "B1";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            bool controllo = false;
                            ButtonsNotEnabled();
                            if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P")
                            {
                                b2.IsEnabled = true;
                                b2.Click += B2_Click;
                                controllo = true;
                            }
                            if (c1.Content.ToString() != "CA" && c1.Content.ToString() != "CO" && c1.Content.ToString() != "S1" && c1.Content.ToString() != "S2" && c1.Content.ToString() != "P" && d1.Content.ToString() != "CA" && d1.Content.ToString() != "CO" && d1.Content.ToString() != "S1" && d1.Content.ToString() != "S2" && d1.Content.ToString() != "P")
                            {
                                c1.IsEnabled = true;
                                c1.Click += C1_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b1.Content = "S1";
                                VettSottomarino1[0] = "B1";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a1")
                            {
                                VettSottomarino1[1] = "B1";
                                VettSottomarino1[2] = "C1";
                                b1.Content = "S1";
                                c1.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }else if (bottoneScelto == "c1")
                            {
                                VettSottomarino1[1] = "B1";
                                VettSottomarino1[2] = "A1";
                                b1.Content = "S1";
                                a1.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            bool controllo = false;
                            ButtonsNotEnabled();
                            if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P")
                            {
                                b2.IsEnabled = true;
                                b2.Click += B2_Click;
                                controllo = true;
                            }
                            if (c1.Content.ToString() != "CA" && c1.Content.ToString() != "CO" && c1.Content.ToString() != "S1" && c1.Content.ToString() != "S2" && c1.Content.ToString() != "P" && d1.Content.ToString() != "CA" && d1.Content.ToString() != "CO" && d1.Content.ToString() != "S1" && d1.Content.ToString() != "S2" && d1.Content.ToString() != "P")
                            {
                                c1.IsEnabled = true;
                                c1.Click += C1_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b1.Content = "S2";
                                VettSottomarino2[0] = "B1";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a1")
                            {
                                VettSottomarino2[1] = "B1";
                                VettSottomarino2[2] = "C1";
                                b1.Content = "S2";
                                c1.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c1")
                            {
                                VettSottomarino2[1] = "B1";
                                VettSottomarino2[2] = "A1";
                                b1.Content = "S2";
                                a1.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P")
                        {
                            b2.IsEnabled = true;
                            b2.Click += B2_Click;
                            controllo = true;
                        }
                        if (c1.Content.ToString() != "CA" && c1.Content.ToString() != "CO" && c1.Content.ToString() != "S1" && c1.Content.ToString() != "S2" && c1.Content.ToString() != "P" && d1.Content.ToString() != "CA" && d1.Content.ToString() != "CO" && d1.Content.ToString() != "S1" && d1.Content.ToString() != "S2" && d1.Content.ToString() != "P" && e1.Content.ToString() != "CA" && e1.Content.ToString() != "CO" && e1.Content.ToString() != "S1" && e1.Content.ToString() != "S2" && e1.Content.ToString() != "P")
                        {
                            c1.IsEnabled = true;
                            c1.Click += C1_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b1.Content = "CO";
                            VettCorazzate[0] = "B1";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        VettCorazzate[1] = "B1";
                        VettCorazzate[2] = "C1";
                        VettCorazzate[3] = "D1";
                        b1.Content = "CO";
                        c1.Content = "CO";
                        d1.Content = "CO";
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P")
                        {
                            b2.IsEnabled = true;
                            b2.Click += B2_Click;
                            controllo = true;
                        }
                        if (c1.Content.ToString() != "CA" && c1.Content.ToString() != "CO" && c1.Content.ToString() != "S1" && c1.Content.ToString() != "S2" && c1.Content.ToString() != "P" && d1.Content.ToString() != "CA" && d1.Content.ToString() != "CO" && d1.Content.ToString() != "S1" && d1.Content.ToString() != "S2" && d1.Content.ToString() != "P" && e1.Content.ToString() != "CA" && e1.Content.ToString() != "CO" && e1.Content.ToString() != "S1" && e1.Content.ToString() != "S2" && e1.Content.ToString() != "P" && f1.Content.ToString() != "CA" && f1.Content.ToString() != "CO" && f1.Content.ToString() != "S1" && f1.Content.ToString() != "S2" && f1.Content.ToString() != "P")
                        {
                            c1.IsEnabled = true;
                            c1.Click += C1_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b1.Content = "P";
                            VettPortaerei[0] = "B1";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        VettPortaerei[1] = "B1";
                        VettPortaerei[2] = "C1";
                        VettPortaerei[3] = "D1";
                        VettPortaerei[4] = "E1";
                        b1.Content = "P";
                        c1.Content = "P";
                        d1.Content = "P";
                        e1.Content = "P";
                        btnConferma.IsEnabled = true;
                    }
                }
                bottoneScelto = "b1";
                c = true;
            }
            else
                c = false;
        }

        private void C1_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P")
                        {
                            b1.IsEnabled = true;
                            b1.Click += B1_Click;
                            controllo = true;
                        }
                        if (d1.Content.ToString() != "CA" && d1.Content.ToString() != "CO" && d1.Content.ToString() != "S1" && d1.Content.ToString() != "S2" && d1.Content.ToString() != "P")
                        {
                            d1.IsEnabled = true;
                            d1.Click += D1_Click;
                            controllo = true;
                        }
                        if (c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P")
                        {
                            c2.IsEnabled = true;
                            c2.Click += C2_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            c1.Content = "CA";
                            VettCacciatorpediniere[0] = "C1";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        c1.Content = "CA";
                        VettCacciatorpediniere[1] = "C1";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            bool controllo = false;
                            ButtonsNotEnabled();
                            if (b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P" && a1.Content.ToString() != "CA" && a1.Content.ToString() != "CO" && a1.Content.ToString() != "S1" && a1.Content.ToString() != "S2" && a1.Content.ToString() != "P")
                            {
                                b1.IsEnabled = true;
                                b1.Click += B1_Click;
                                controllo = true;
                            }
                            if (d1.Content.ToString() != "CA" && d1.Content.ToString() != "CO" && d1.Content.ToString() != "S1" && d1.Content.ToString() != "S2" && d1.Content.ToString() != "P" && e1.Content.ToString() != "CA" && e1.Content.ToString() != "CO" && e1.Content.ToString() != "S1" && e1.Content.ToString() != "S2" && e1.Content.ToString() != "P")
                            {
                                d1.IsEnabled = true;
                                d1.Click += D1_Click;
                                controllo = true;
                            }
                            if (c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P" && c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P")
                            {
                                c2.IsEnabled = true;
                                c2.Click += C2_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                c1.Content = "S1";
                                VettSottomarino1[0] = "C1";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "b1")
                            {
                                VettSottomarino1[1] = "C1";
                                VettSottomarino1[2] = "D1";
                                d1.Content = "S1";
                                c1.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "d1")
                            {
                                VettSottomarino1[1] = "C1";
                                VettSottomarino1[2] = "B1";
                                b1.Content = "S1";
                                c1.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            bool controllo = false;
                            ButtonsNotEnabled();
                            if (b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P" && a1.Content.ToString() != "CA" && a1.Content.ToString() != "CO" && a1.Content.ToString() != "S1" && a1.Content.ToString() != "S2" && a1.Content.ToString() != "P")
                            {
                                b1.IsEnabled = true;
                                b1.Click += B1_Click;
                                controllo = true;
                            }
                            if (d1.Content.ToString() != "CA" && d1.Content.ToString() != "CO" && d1.Content.ToString() != "S1" && d1.Content.ToString() != "S2" && d1.Content.ToString() != "P" && e1.Content.ToString() != "CA" && e1.Content.ToString() != "CO" && e1.Content.ToString() != "S1" && e1.Content.ToString() != "S2" && e1.Content.ToString() != "P")
                            {
                                d1.IsEnabled = true;
                                d1.Click += D1_Click;
                                controllo = true;
                            }
                            if (c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P" && c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P")
                            {
                                c2.IsEnabled = true;
                                c2.Click += C2_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                c1.Content = "S2";
                                VettSottomarino2[0] = "C1";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "b1")
                            {
                                VettSottomarino2[1] = "C1";
                                VettSottomarino2[2] = "D1";
                                d1.Content = "S2";
                                c1.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "d1")
                            {
                                VettSottomarino2[1] = "C1";
                                VettSottomarino2[2] = "B1";
                                b1.Content = "S2";
                                c1.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (d1.Content.ToString() != "CA" && d1.Content.ToString() != "CO" && d1.Content.ToString() != "S1" && d1.Content.ToString() != "S2" && d1.Content.ToString() != "P" && e1.Content.ToString() != "CA" && e1.Content.ToString() != "CO" && e1.Content.ToString() != "S1" && e1.Content.ToString() != "S2" && e1.Content.ToString() != "P" && f1.Content.ToString() != "CA" && f1.Content.ToString() != "CO" && f1.Content.ToString() != "S1" && f1.Content.ToString() != "S2" && f1.Content.ToString() != "P")
                        {
                            d1.IsEnabled = true;
                            d1.Click += D1_Click;
                            controllo = true;
                        }
                        if (c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P" && c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P" && c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P")
                        {
                            c2.IsEnabled = true;
                            c2.Click += C2_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            c1.Content = "CO";
                            VettCorazzate[0] = "C1";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "b1")
                        {
                            VettCorazzate[1] = "C1";
                            VettCorazzate[2] = "D1";
                            VettCorazzate[3] = "E1";
                            e1.Content = "CO";
                            c1.Content = "CO";
                            d1.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }else if (bottoneScelto == "d1")
                        {
                            VettCorazzate[1] = "C1";
                            VettCorazzate[2] = "B1";
                            VettCorazzate[3] = "A1";
                            b1.Content = "CO";
                            c1.Content = "CO";
                            a1.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (d1.Content.ToString() != "CA" && d1.Content.ToString() != "CO" && d1.Content.ToString() != "S1" && d1.Content.ToString() != "S2" && d1.Content.ToString() != "P" && e1.Content.ToString() != "CA" && e1.Content.ToString() != "CO" && e1.Content.ToString() != "S1" && e1.Content.ToString() != "S2" && e1.Content.ToString() != "P" && f1.Content.ToString() != "CA" && f1.Content.ToString() != "CO" && f1.Content.ToString() != "S1" && f1.Content.ToString() != "S2" && f1.Content.ToString() != "P" && g1.Content.ToString() != "CA" && g1.Content.ToString() != "CO" && g1.Content.ToString() != "S1" && g1.Content.ToString() != "S2" && g1.Content.ToString() != "P")
                        {
                            d1.IsEnabled = true;
                            d1.Click += D1_Click;
                            controllo = true;
                        }
                        if (c2.Content.ToString() != "CA" && c2.Content.ToString() != "CO" && c2.Content.ToString() != "S1" && c2.Content.ToString() != "S2" && c2.Content.ToString() != "P" && c3.Content.ToString() != "CA" && c3.Content.ToString() != "CO" && c3.Content.ToString() != "S1" && c3.Content.ToString() != "S2" && c3.Content.ToString() != "P" && c4.Content.ToString() != "CA" && c4.Content.ToString() != "CO" && c4.Content.ToString() != "S1" && c4.Content.ToString() != "S2" && c4.Content.ToString() != "P" && c5.Content.ToString() != "CA" && c5.Content.ToString() != "CO" && c5.Content.ToString() != "S1" && c5.Content.ToString() != "S2" && c5.Content.ToString() != "P")
                        {
                            c2.IsEnabled = true;
                            c2.Click += C2_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            c1.Content = "P";
                            VettPortaerei[0] = "C1";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        VettPortaerei[1] = "C1";
                        VettPortaerei[2] = "D1";
                        VettPortaerei[3] = "E1";
                        VettPortaerei[4] = "F1";
                        f1.Content = "P";
                        c1.Content = "P";
                        d1.Content = "P";
                        e1.Content = "P";
                        btnConferma.IsEnabled = true;
                    }
                }
                bottoneScelto = "c1";
                c = true;
            }
            else
                c = false;
        }

        private void D1_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void D2_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B10_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P")
                        {
                            b9.IsEnabled = true;
                            b9.Click += B9_Click;
                            controllo = true;
                        }
                        if (a10.Content.ToString() != "CA" && a10.Content.ToString() != "CO" && a10.Content.ToString() != "S1" && a10.Content.ToString() != "S2" && a9.Content.ToString() != "P")
                        {
                            a10.IsEnabled = true;
                            a10.Click += A10_Click;
                            controllo = true;
                        }
                        if (c10.Content.ToString() != "CA" && c10.Content.ToString() != "CO" && c10.Content.ToString() != "S1" && c10.Content.ToString() != "S2" && c9.Content.ToString() != "P")
                        {
                            c10.IsEnabled = true;
                            c10.Click += C10_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b10.Content = "CA";
                            VettCacciatorpediniere[0] = "B10";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        b10.Content = "CA";
                        VettCacciatorpediniere[1] = "B10";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P")
                            {
                                b9.IsEnabled = true;
                                b9.Click += B9_Click;
                                controllo = true;
                            }
                            if (c10.Content.ToString() != "CA" && c10.Content.ToString() != "CO" && c10.Content.ToString() != "S1" && c10.Content.ToString() != "S2" && c10.Content.ToString() != "P" && d10.Content.ToString() != "CA" && d10.Content.ToString() != "CO" && d10.Content.ToString() != "S1" && d10.Content.ToString() != "S2" && d10.Content.ToString() != "P")
                            {
                                c10.IsEnabled = true;
                                c10.Click += C10_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b10.Content = "S1";
                                VettSottomarino1[0] = "B10";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a10")
                            {
                                VettSottomarino1[1] = "B10";
                                VettSottomarino1[2] = "C10";
                                b10.Content = "S1";
                                c10.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c10")
                            {
                                VettSottomarino1[1] = "B10";
                                VettSottomarino1[2] = "A10";
                                b10.Content = "S1";
                                a10.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P")
                            {
                                b9.IsEnabled = true;
                                b9.Click += B9_Click;
                                controllo = true;
                            }
                            if (c10.Content.ToString() != "CA" && c10.Content.ToString() != "CO" && c10.Content.ToString() != "S1" && c10.Content.ToString() != "S2" && c10.Content.ToString() != "P" && d10.Content.ToString() != "CA" && d10.Content.ToString() != "CO" && d10.Content.ToString() != "S1" && d10.Content.ToString() != "S2" && d10.Content.ToString() != "P")
                            {
                                c10.IsEnabled = true;
                                c10.Click += C10_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b10.Content = "S2";
                                VettSottomarino2[0] = "B10";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a10")
                            {
                                VettSottomarino2[1] = "B10";
                                VettSottomarino2[2] = "C10";
                                b10.Content = "S2";
                                c10.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c10")
                            {
                                VettSottomarino2[1] = "B10";
                                VettSottomarino2[2] = "A10";
                                b10.Content = "S2";
                                a10.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P")
                        {
                            b9.IsEnabled = true;
                            b9.Click += B9_Click;
                            controllo = true;
                        }
                        if (c10.Content.ToString() != "CA" && c10.Content.ToString() != "CO" && c10.Content.ToString() != "S1" && c10.Content.ToString() != "S2" && c10.Content.ToString() != "P" && d10.Content.ToString() != "CA" && d10.Content.ToString() != "CO" && d10.Content.ToString() != "S1" && d10.Content.ToString() != "S2" && d10.Content.ToString() != "P" && e10.Content.ToString() != "CA" && e10.Content.ToString() != "CO" && e10.Content.ToString() != "S1" && e10.Content.ToString() != "S2" && e10.Content.ToString() != "P")
                        {
                            c10.IsEnabled = true;
                            c10.Click += C10_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b10.Content = "CO";
                            VettCorazzate[0] = "B10";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a10")
                        {
                            VettCorazzate[1] = "B10";
                            VettCorazzate[2] = "C10";
                            VettCorazzate[3] = "D10";
                            b10.Content = "CO";
                            c10.Content = "CO";
                            d10.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P")
                        {
                            b9.IsEnabled = true;
                            b9.Click += B9_Click;
                            controllo = true;
                        }
                        if (c10.Content.ToString() != "CA" && c10.Content.ToString() != "CO" && c10.Content.ToString() != "S1" && c10.Content.ToString() != "S2" && c10.Content.ToString() != "P" && d10.Content.ToString() != "CA" && d10.Content.ToString() != "CO" && d10.Content.ToString() != "S1" && d10.Content.ToString() != "S2" && d10.Content.ToString() != "P" && e10.Content.ToString() != "CA" && e10.Content.ToString() != "CO" && e10.Content.ToString() != "S1" && e10.Content.ToString() != "S2" && e10.Content.ToString() != "P" && f10.Content.ToString() != "CA" && f10.Content.ToString() != "CO" && f10.Content.ToString() != "S1" && f10.Content.ToString() != "S2" && f10.Content.ToString() != "P")
                        {
                            c10.IsEnabled = true;
                            c10.Click += C10_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b10.Content = "P";
                            VettPortaerei[0] = "B10";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a10")
                        {
                            VettPortaerei[1] = "B10";
                            VettPortaerei[2] = "C10";
                            VettPortaerei[3] = "D10";
                            VettPortaerei[4] = "E10";
                            b10.Content = "P";
                            c10.Content = "P";
                            d10.Content = "P";
                            e10.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                    }

                }
                bottoneScelto = "b10";
                c = true;
            }
            else
                c = false;
        }

        private void C10_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P")
                        {
                            b8.IsEnabled = true;
                            b8.Click += B8_Click;
                            controllo = true;
                        }
                        if (b10.Content.ToString() != "CA" && b10.Content.ToString() != "CO" && b10.Content.ToString() != "S1" && b10.Content.ToString() != "S2" && b10.Content.ToString() != "P")
                        {
                            b10.IsEnabled = true;
                            b10.Click += B10_Click;
                            controllo = true;
                        }
                        if (a9.Content.ToString() != "CA" && a9.Content.ToString() != "CO" && a9.Content.ToString() != "S1" && a9.Content.ToString() != "S2" && a9.Content.ToString() != "P")
                        {
                            a9.IsEnabled = true;
                            a9.Click += A9_Click;
                            controllo = true;
                        }
                        if (c9.Content.ToString() != "CA" && c9.Content.ToString() != "CO" && c9.Content.ToString() != "S1" && c9.Content.ToString() != "S2" && c9.Content.ToString() != "P")
                        {
                            c9.IsEnabled = true;
                            c9.Click += C9_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b9.Content = "CA";
                            VettCacciatorpediniere[0] = "B9";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        b9.Content = "CA";
                        VettCacciatorpediniere[1] = "B9";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P")
                            {
                                b8.IsEnabled = true;
                                b8.Click += B8_Click;
                                controllo = true;
                            }
                            if (c9.Content.ToString() != "CA" && c9.Content.ToString() != "CO" && c9.Content.ToString() != "S1" && c9.Content.ToString() != "S2" && c9.Content.ToString() != "P" && d9.Content.ToString() != "CA" && d9.Content.ToString() != "CO" && d9.Content.ToString() != "S1" && d9.Content.ToString() != "S2" && d9.Content.ToString() != "P")
                            {
                                c9.IsEnabled = true;
                                c9.Click += C9_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b9.Content = "S1";
                                VettSottomarino1[0] = "B9";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a9")
                            {
                                VettSottomarino1[1] = "B9";
                                VettSottomarino1[2] = "C9";
                                b9.Content = "S1";
                                c9.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b10")
                            {
                                VettSottomarino1[1] = "B9";
                                VettSottomarino1[2] = "B8";
                                b9.Content = "S1";
                                b8.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b8")
                            {
                                VettSottomarino1[1] = "B9";
                                VettSottomarino1[2] = "B10";
                                b10.Content = "S1";
                                b9.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c9")
                            {
                                VettSottomarino1[1] = "B9";
                                VettSottomarino1[2] = "A9";
                                b9.Content = "S1";
                                a9.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P")
                            {
                                b8.IsEnabled = true;
                                b8.Click += B8_Click;
                                controllo = true;
                            }
                            if (c9.Content.ToString() != "CA" && c9.Content.ToString() != "CO" && c9.Content.ToString() != "S1" && c9.Content.ToString() != "S2" && c9.Content.ToString() != "P" && d9.Content.ToString() != "CA" && d9.Content.ToString() != "CO" && d9.Content.ToString() != "S1" && d9.Content.ToString() != "S2" && d9.Content.ToString() != "P")
                            {
                                c9.IsEnabled = true;
                                c9.Click += C9_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b9.Content = "S2";
                                VettSottomarino2[0] = "B9";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a9")
                            {
                                VettSottomarino2[1] = "B9";
                                VettSottomarino2[2] = "C9";
                                b9.Content = "S2";
                                c9.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b10")
                            {
                                VettSottomarino2[1] = "B9";
                                VettSottomarino2[2] = "B8";
                                b9.Content = "S2";
                                b8.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b8")
                            {
                                VettSottomarino2[1] = "B9";
                                VettSottomarino2[2] = "B10";
                                b10.Content = "S2";
                                b9.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c9")
                            {
                                VettSottomarino2[1] = "B9";
                                VettSottomarino2[2] = "A9";
                                b9.Content = "S2";
                                a9.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P")
                        {
                            b8.IsEnabled = true;
                            b8.Click += B8_Click;
                            controllo = true;
                        }
                        if (c9.Content.ToString() != "CA" && c9.Content.ToString() != "CO" && c9.Content.ToString() != "S1" && c9.Content.ToString() != "S2" && c9.Content.ToString() != "P" && d9.Content.ToString() != "CA" && d9.Content.ToString() != "CO" && d9.Content.ToString() != "S1" && d9.Content.ToString() != "S2" && d9.Content.ToString() != "P" && e9.Content.ToString() != "CA" && e9.Content.ToString() != "CO" && e9.Content.ToString() != "S1" && e9.Content.ToString() != "S2" && e9.Content.ToString() != "P")
                        {
                            c9.IsEnabled = true;
                            c9.Click += C9_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b9.Content = "CO";
                            VettCorazzate[0] = "B9";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a9")
                        {
                            VettCorazzate[1] = "B9";
                            VettCorazzate[2] = "C9";
                            VettCorazzate[3] = "D9";
                            b9.Content = "CO";
                            c9.Content = "CO";
                            d9.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b10")
                        {
                            VettCorazzate[1] = "B9";
                            VettCorazzate[2] = "B8";
                            VettCorazzate[3] = "B7";
                            b8.Content = "CO";
                            b9.Content = "CO";
                            b7.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P")
                        {
                            b8.IsEnabled = true;
                            b8.Click += B8_Click;
                            controllo = true;
                        }
                        if (c9.Content.ToString() != "CA" && c9.Content.ToString() != "CO" && c9.Content.ToString() != "S1" && c9.Content.ToString() != "S2" && c9.Content.ToString() != "P" && d9.Content.ToString() != "CA" && d9.Content.ToString() != "CO" && d9.Content.ToString() != "S1" && d9.Content.ToString() != "S2" && d9.Content.ToString() != "P" && e9.Content.ToString() != "CA" && e9.Content.ToString() != "CO" && e9.Content.ToString() != "S1" && e9.Content.ToString() != "S2" && e9.Content.ToString() != "P" && f9.Content.ToString() != "CA" && f9.Content.ToString() != "CO" && f9.Content.ToString() != "S1" && f9.Content.ToString() != "S2" && f9.Content.ToString() != "P")
                        {
                            c9.IsEnabled = true;
                            c9.Click += C9_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b9.Content = "P";
                            VettPortaerei[0] = "B9";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a9")
                        {
                            VettPortaerei[1] = "B9";
                            VettPortaerei[2] = "C9";
                            VettPortaerei[3] = "D9";
                            VettPortaerei[4] = "E9";
                            b9.Content = "P";
                            c9.Content = "P";
                            d9.Content = "P";
                            e9.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b10")
                        {
                            VettPortaerei[1] = "B9";
                            VettPortaerei[2] = "B8";
                            VettPortaerei[3] = "B7";
                            VettPortaerei[4] = "B6";
                            b8.Content = "P";
                            b7.Content = "P";
                            b6.Content = "P";
                            b9.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                    }

                }
                bottoneScelto = "b9";
                c = true;
            }
            else
                c = false;
        }

        private void C9_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P")
                        {
                            b7.IsEnabled = true;
                            b7.Click += B7_Click;
                            controllo = true;
                        }
                        if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && b10.Content.ToString() != "CA" && b10.Content.ToString() != "CO" && b10.Content.ToString() != "S1" && b10.Content.ToString() != "S2" && b10.Content.ToString() != "P")
                        {
                            b9.IsEnabled = true;
                            b9.Click += B9_Click;
                            controllo = true;
                        }
                        if (a8.Content.ToString() != "CA" && a8.Content.ToString() != "CO" && a8.Content.ToString() != "S1" && a8.Content.ToString() != "S2" && a8.Content.ToString() != "P")
                        {
                            a8.IsEnabled = true;
                            a8.Click += A8_Click;
                            controllo = true;
                        }
                        if (c8.Content.ToString() != "CA" && c8.Content.ToString() != "CO" && c8.Content.ToString() != "S1" && c8.Content.ToString() != "S2" && c8.Content.ToString() != "P" && d8.Content.ToString() != "CA" && d8.Content.ToString() != "CO" && d8.Content.ToString() != "S1" && d8.Content.ToString() != "S2" && d8.Content.ToString() != "P")
                        {
                            c8.IsEnabled = true;
                            c8.Click += C8_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b8.Content = "CA";
                            VettCacciatorpediniere[0] = "B8";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        b8.Content = "CA";
                        VettCacciatorpediniere[1] = "B8";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P")
                            {
                                b7.IsEnabled = true;
                                b7.Click += B7_Click;
                                controllo = true;
                            }
                            if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && b10.Content.ToString() != "CA" && b10.Content.ToString() != "CO" && b10.Content.ToString() != "S1" && b10.Content.ToString() != "S2" && b10.Content.ToString() != "P")
                            {
                                b9.IsEnabled = true;
                                b9.Click += B9_Click;
                                controllo = true;
                            }
                            if (c8.Content.ToString() != "CA" && c8.Content.ToString() != "CO" && c8.Content.ToString() != "S1" && c8.Content.ToString() != "S2" && c8.Content.ToString() != "P" && d8.Content.ToString() != "CA" && d8.Content.ToString() != "CO" && d8.Content.ToString() != "S1" && d8.Content.ToString() != "S2" && d8.Content.ToString() != "P")
                            {
                                c8.IsEnabled = true;
                                c8.Click += C8_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b8.Content = "S1";
                                VettSottomarino1[0] = "B8";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a8")
                            {
                                VettSottomarino1[1] = "B8";
                                VettSottomarino1[2] = "C8";
                                b8.Content = "S1";
                                c8.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b9")
                            {
                                VettSottomarino1[1] = "B8";
                                VettSottomarino1[2] = "B7";
                                b7.Content = "S1";
                                b8.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b7")
                            {
                                VettSottomarino1[1] = "B8";
                                VettSottomarino1[2] = "B9";
                                b8.Content = "S1";
                                b9.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c8")
                            {
                                VettSottomarino1[1] = "B8";
                                VettSottomarino1[2] = "A8";
                                b8.Content = "S1";
                                a8.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P")
                            {
                                b7.IsEnabled = true;
                                b7.Click += B7_Click;
                                controllo = true;
                            }
                            if (b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && b10.Content.ToString() != "CA" && b10.Content.ToString() != "CO" && b10.Content.ToString() != "S1" && b10.Content.ToString() != "S2" && b10.Content.ToString() != "P")
                            {
                                b9.IsEnabled = true;
                                b9.Click += B9_Click;
                                controllo = true;
                            }
                            if (c8.Content.ToString() != "CA" && c8.Content.ToString() != "CO" && c8.Content.ToString() != "S1" && c8.Content.ToString() != "S2" && c8.Content.ToString() != "P" && d8.Content.ToString() != "CA" && d8.Content.ToString() != "CO" && d8.Content.ToString() != "S1" && d8.Content.ToString() != "S2" && d8.Content.ToString() != "P")
                            {
                                c8.IsEnabled = true;
                                c8.Click += C8_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b8.Content = "S2";
                                VettSottomarino2[0] = "B8";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a8")
                            {
                                VettSottomarino2[1] = "B8";
                                VettSottomarino2[2] = "C8";
                                b8.Content = "S2";
                                c8.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b9")
                            {
                                VettSottomarino2[1] = "B8";
                                VettSottomarino2[2] = "B7";
                                b7.Content = "S2";
                                b8.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b7")
                            {
                                VettSottomarino2[1] = "B8";
                                VettSottomarino2[2] = "B9";
                                b8.Content = "S2";
                                b9.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c8")
                            {
                                VettSottomarino2[1] = "B8";
                                VettSottomarino2[2] = "A8";
                                b8.Content = "S2";
                                a8.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P")
                        {   
                            b7.IsEnabled = true;
                            b7.Click += B7_Click;
                            controllo = true;
                        }
                        if (c8.Content.ToString() != "CA" && c8.Content.ToString() != "CO" && c8.Content.ToString() != "S1" && c8.Content.ToString() != "S2" && c8.Content.ToString() != "P" && d8.Content.ToString() != "CA" && d8.Content.ToString() != "CO" && d8.Content.ToString() != "S1" && d8.Content.ToString() != "S2" && d8.Content.ToString() != "P" && e8.Content.ToString() != "CA" && e8.Content.ToString() != "CO" && e8.Content.ToString() != "S1" && e8.Content.ToString() != "S2" && e8.Content.ToString() != "P")
                        {
                            c8.IsEnabled = true;
                            c8.Click += C8_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b8.Content = "CO";
                            VettCorazzate[0] = "B8";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a8")
                        {
                            VettCorazzate[1] = "B8";
                            VettCorazzate[2] = "C8";
                            VettCorazzate[3] = "D8";
                            b8.Content = "CO";
                            c8.Content = "CO";
                            d8.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b7")
                        {
                            VettCorazzate[1] = "B8";
                            VettCorazzate[2] = "B9";
                            VettCorazzate[3] = "B10";
                            b8.Content = "CO";
                            b9.Content = "CO";
                            b10.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }else if (bottoneScelto == "b9")
                        {
                            VettCorazzate[1] = "B8";
                            VettCorazzate[2] = "B7";
                            VettCorazzate[3] = "B6";
                            b8.Content = "CO";
                            b6.Content = "CO";
                            b7.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P")
                        {
                            b7.IsEnabled = true;
                            b7.Click += B7_Click;
                            controllo = true;
                        }
                        if (c8.Content.ToString() != "CA" && c8.Content.ToString() != "CO" && c8.Content.ToString() != "S1" && c8.Content.ToString() != "S2" && c8.Content.ToString() != "P" && d8.Content.ToString() != "CA" && d8.Content.ToString() != "CO" && d8.Content.ToString() != "S1" && d8.Content.ToString() != "S2" && d8.Content.ToString() != "P" && e8.Content.ToString() != "CA" && e8.Content.ToString() != "CO" && e8.Content.ToString() != "S1" && e8.Content.ToString() != "S2" && e8.Content.ToString() != "P" && f8.Content.ToString() != "CA" && f8.Content.ToString() != "CO" && f8.Content.ToString() != "S1" && f8.Content.ToString() != "S2" && f8.Content.ToString() != "P")
                        {
                            c8.IsEnabled = true;
                            c8.Click += C8_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b8.Content = "P";
                            VettPortaerei[0] = "B8";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a8")
                        {
                            VettPortaerei[1] = "B8";
                            VettPortaerei[2] = "C8";
                            VettPortaerei[3] = "D8";
                            VettPortaerei[4] = "E8";
                            b8.Content = "P";
                            c8.Content = "P";
                            d8.Content = "P";
                            e8.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b9")
                        {
                            VettPortaerei[1] = "B8";
                            VettPortaerei[2] = "B7";
                            VettPortaerei[3] = "B6";
                            VettPortaerei[4] = "B5";
                            b8.Content = "P";
                            b7.Content = "P";
                            b6.Content = "P";
                            b5.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                    }

                }
                bottoneScelto = "b8";
                c = true;
            }
            else
                c = false;
        }

        private void C8_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P")
                        {
                            b6.IsEnabled = true;
                            b6.Click += B6_Click;
                            controllo = true;
                        }
                        if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P")
                        {
                            b8.IsEnabled = true;
                            b8.Click += B8_Click;
                            controllo = true;
                        }
                        if (a7.Content.ToString() != "CA" && a7.Content.ToString() != "CO" && a7.Content.ToString() != "S1" && a7.Content.ToString() != "S2" && a7.Content.ToString() != "P")
                        {
                            a7.IsEnabled = true;
                            a7.Click += A7_Click;
                            controllo = true;
                        }
                        if (c7.Content.ToString() != "CA" && c7.Content.ToString() != "CO" && c7.Content.ToString() != "S1" && c7.Content.ToString() != "S2" && c7.Content.ToString() != "P" && d7.Content.ToString() != "CA" && d7.Content.ToString() != "CO" && d7.Content.ToString() != "S1" && d7.Content.ToString() != "S2" && d7.Content.ToString() != "P")
                        {
                            c7.IsEnabled = true;
                            c7.Click += C7_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b7.Content = "CA";
                            VettCacciatorpediniere[0] = "B7";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        b7.Content = "CA";
                        VettCacciatorpediniere[1] = "B7";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P")
                            {
                                b6.IsEnabled = true;
                                b6.Click += B6_Click;
                                controllo = true;
                            }
                            if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P")
                            {
                                b8.IsEnabled = true;
                                b8.Click += B8_Click;
                                controllo = true;
                            }
                            if (c7.Content.ToString() != "CA" && c7.Content.ToString() != "CO" && c7.Content.ToString() != "S1" && c7.Content.ToString() != "S2" && c7.Content.ToString() != "P" && d7.Content.ToString() != "CA" && d7.Content.ToString() != "CO" && d7.Content.ToString() != "S1" && d7.Content.ToString() != "S2" && d7.Content.ToString() != "P")
                            {
                                c7.IsEnabled = true;
                                c7.Click += C7_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b7.Content = "S1";
                                VettSottomarino1[0] = "B7";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a7")
                            {
                                VettSottomarino1[1] = "B7";
                                VettSottomarino1[2] = "C7";
                                b7.Content = "S1";
                                c7.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b8")
                            {
                                VettSottomarino1[1] = "B7";
                                VettSottomarino1[2] = "B6";
                                b7.Content = "S1";
                                b6.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b6")
                            {
                                VettSottomarino2[1] = "B7";
                                VettSottomarino2[2] = "B8";
                                b8.Content = "S1";
                                b7.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c7")
                            {
                                VettSottomarino1[1] = "B7";
                                VettSottomarino1[2] = "A7";
                                b7.Content = "S1";
                                a7.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P")
                            {
                                b6.IsEnabled = true;
                                b6.Click += B6_Click;
                                controllo = true;
                            }
                            if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P")
                            {
                                b8.IsEnabled = true;
                                b8.Click += B8_Click;
                                controllo = true;
                            }
                            if (c7.Content.ToString() != "CA" && c7.Content.ToString() != "CO" && c7.Content.ToString() != "S1" && c7.Content.ToString() != "S2" && c7.Content.ToString() != "P" && d7.Content.ToString() != "CA" && d7.Content.ToString() != "CO" && d7.Content.ToString() != "S1" && d7.Content.ToString() != "S2" && d7.Content.ToString() != "P")
                            {
                                c7.IsEnabled = true;
                                c7.Click += C7_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b7.Content = "S2";
                                VettSottomarino2[0] = "B7";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a7")
                            {
                                VettSottomarino2[1] = "B7";
                                VettSottomarino2[2] = "C7";
                                b7.Content = "S2";
                                c7.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b8")
                            {
                                VettSottomarino2[1] = "B7";
                                VettSottomarino2[2] = "B6";
                                b7.Content = "S2";
                                b6.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b6")
                            {
                                VettSottomarino2[1] = "B7";
                                VettSottomarino2[2] = "B8";
                                b8.Content = "S2";
                                b7.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c7")
                            {
                                VettSottomarino2[1] = "B7";
                                VettSottomarino2[2] = "A7";
                                b7.Content = "S2";
                                a7.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P")
                        {
                            b6.IsEnabled = true;
                            b6.Click += B6_Click;
                            controllo = true;
                        }
                        if (b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && b10.Content.ToString() != "CA" && b10.Content.ToString() != "CO" && b10.Content.ToString() != "S1" && b10.Content.ToString() != "S2" && b10.Content.ToString() != "P")
                        {
                            b8.IsEnabled = true;
                            b8.Click += B8_Click;
                            controllo = true;
                        }
                        if (c7.Content.ToString() != "CA" && c7.Content.ToString() != "CO" && c7.Content.ToString() != "S1" && c7.Content.ToString() != "S2" && c7.Content.ToString() != "P" && d7.Content.ToString() != "CA" && d7.Content.ToString() != "CO" && d7.Content.ToString() != "S1" && d7.Content.ToString() != "S2" && d7.Content.ToString() != "P" && e7.Content.ToString() != "CA" && e7.Content.ToString() != "CO" && e7.Content.ToString() != "S1" && e7.Content.ToString() != "S2" && e7.Content.ToString() != "P")
                        {
                            c7.IsEnabled = true;
                            c7.Click += C7_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b7.Content = "CO";
                            VettCorazzate[0] = "B7";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a7")
                        {
                            VettCorazzate[1] = "B7";
                            VettCorazzate[2] = "C7";
                            VettCorazzate[3] = "D7";
                            b7.Content = "CO";
                            c7.Content = "CO";
                            d7.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b8")
                        {
                            VettCorazzate[1] = "B7";
                            VettCorazzate[2] = "B6";
                            VettCorazzate[3] = "B5";
                            b7.Content = "CO";
                            b6.Content = "CO";
                            b5.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b6")
                        {
                            VettCorazzate[1] = "B7";
                            VettCorazzate[2] = "B8";
                            VettCorazzate[3] = "B9";
                            b8.Content = "CO";
                            b9.Content = "CO";
                            b7.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P")
                        {
                            b6.IsEnabled = true;
                            b6.Click += B6_Click;
                            controllo = true;
                        }
                        if (c7.Content.ToString() != "CA" && c7.Content.ToString() != "CO" && c7.Content.ToString() != "S1" && c7.Content.ToString() != "S2" && c7.Content.ToString() != "P" && d7.Content.ToString() != "CA" && d7.Content.ToString() != "CO" && d7.Content.ToString() != "S1" && d7.Content.ToString() != "S2" && d7.Content.ToString() != "P" && e7.Content.ToString() != "CA" && e7.Content.ToString() != "CO" && e7.Content.ToString() != "S1" && e7.Content.ToString() != "S2" && e7.Content.ToString() != "P" && f7.Content.ToString() != "CA" && f7.Content.ToString() != "CO" && f7.Content.ToString() != "S1" && f7.Content.ToString() != "S2" && f7.Content.ToString() != "P")
                        {
                            c7.IsEnabled = true;
                            c7.Click += C7_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b7.Content = "P";
                            VettPortaerei[0] = "B7";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a7")
                        {
                            VettPortaerei[1] = "B7";
                            VettPortaerei[2] = "C7";
                            VettPortaerei[3] = "D7";
                            VettPortaerei[4] = "E7";
                            b7.Content = "P";
                            c7.Content = "P";
                            d7.Content = "P";
                            e7.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b8")
                        {
                            VettPortaerei[1] = "B7";
                            VettPortaerei[2] = "B6";
                            VettPortaerei[3] = "B5";
                            VettPortaerei[4] = "B4";
                            b4.Content = "P";
                            b7.Content = "P";
                            b6.Content = "P";
                            b5.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b6")
                        {
                            VettPortaerei[1] = "B7";
                            VettPortaerei[2] = "B8";
                            VettPortaerei[3] = "B9";
                            VettPortaerei[4] = "B10";
                            b9.Content = "P";
                            b10.Content = "P";
                            b7.Content = "P";
                            b8.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                    }

                }
                bottoneScelto = "b7";
                c = true;
            }
            else
                c = false;
        }

        private void C7_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P")
                        {
                            b5.IsEnabled = true;
                            b5.Click += B5_Click;
                            controllo = true;
                        }
                        if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P")
                        {
                            b7.IsEnabled = true;
                            b7.Click += B7_Click;
                            controllo = true;
                        }
                        if (a6.Content.ToString() != "CA" && a6.Content.ToString() != "CO" && a6.Content.ToString() != "S1" && a6.Content.ToString() != "S2" && a6.Content.ToString() != "P")
                        {
                            a6.IsEnabled = true;
                            a6.Click += A6_Click;
                            controllo = true;
                        }
                        if (c6.Content.ToString() != "CA" && c6.Content.ToString() != "CO" && c6.Content.ToString() != "S1" && c6.Content.ToString() != "S2" && c6.Content.ToString() != "P")
                        {
                            c6.IsEnabled = true;
                            c6.Click += C6_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b6.Content = "CA";
                            VettCacciatorpediniere[0] = "B6";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        b6.Content = "CA";
                        VettCacciatorpediniere[1] = "B6";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P")
                            {
                                b5.IsEnabled = true;
                                b5.Click += B5_Click;
                                controllo = true;
                            }
                            if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b8.Content.ToString() != "P")
                            {
                                b7.IsEnabled = true;
                                b7.Click += B7_Click;
                                controllo = true;
                            }
                            if (c6.Content.ToString() != "CA" && c6.Content.ToString() != "CO" && c6.Content.ToString() != "S1" && c6.Content.ToString() != "S2" && c6.Content.ToString() != "P" && d6.Content.ToString() != "CA" && d6.Content.ToString() != "CO" && d6.Content.ToString() != "S1" && d6.Content.ToString() != "S2" && d6.Content.ToString() != "P")
                            {
                                c6.IsEnabled = true;
                                c6.Click += C6_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b6.Content = "S1";
                                VettSottomarino1[0] = "B6";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a6")
                            {
                                VettSottomarino1[1] = "B6";
                                VettSottomarino1[2] = "C6";
                                b6.Content = "S1";
                                c6.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b7")
                            {
                                VettSottomarino1[1] = "B6";
                                VettSottomarino1[2] = "B5";
                                b5.Content = "S1";
                                b6.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b5")
                            {
                                VettSottomarino1[1] = "B6";
                                VettSottomarino1[2] = "B7";
                                b6.Content = "S1";
                                b7.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c6")
                            {
                                VettSottomarino1[1] = "B6";
                                VettSottomarino1[2] = "A6";
                                b6.Content = "S1";
                                a6.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P")
                            {
                                b5.IsEnabled = true;
                                b5.Click += B5_Click;
                                controllo = true;
                            }
                            if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b8.Content.ToString() != "P")
                            {
                                b7.IsEnabled = true;
                                b7.Click += B7_Click;
                                controllo = true;
                            }
                            if (c6.Content.ToString() != "CA" && c6.Content.ToString() != "CO" && c6.Content.ToString() != "S1" && c6.Content.ToString() != "S2" && c6.Content.ToString() != "P" && d6.Content.ToString() != "CA" && d6.Content.ToString() != "CO" && d6.Content.ToString() != "S1" && d6.Content.ToString() != "S2" && d6.Content.ToString() != "P")
                            {
                                c6.IsEnabled = true;
                                c6.Click += C6_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b6.Content = "S2";
                                VettSottomarino2[0] = "B6";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a6")
                            {
                                VettSottomarino2[1] = "B6";
                                VettSottomarino2[2] = "C6";
                                b6.Content = "S2";
                                c6.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b7")
                            {
                                VettSottomarino2[1] = "B6";
                                VettSottomarino2[2] = "B5";
                                b5.Content = "S2";
                                b6.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b5")
                            {
                                VettSottomarino2[1] = "B6";
                                VettSottomarino2[2] = "B7";
                                b6.Content = "S2";
                                b7.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c6")
                            {
                                VettSottomarino2[1] = "B6";
                                VettSottomarino2[2] = "A6";
                                b6.Content = "S2";
                                a6.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P")
                        {
                            b5.IsEnabled = true;
                            b5.Click += B5_Click;
                            controllo = true;
                        }
                        if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P")
                        {
                            b7.IsEnabled = true;
                            b7.Click += B7_Click;
                            controllo = true;
                        }
                        if (c6.Content.ToString() != "CA" && c6.Content.ToString() != "CO" && c6.Content.ToString() != "S1" && c6.Content.ToString() != "S2" && c6.Content.ToString() != "P" && d6.Content.ToString() != "CA" && d6.Content.ToString() != "CO" && d6.Content.ToString() != "S1" && d6.Content.ToString() != "S2" && d6.Content.ToString() != "P" && e6.Content.ToString() != "CA" && e6.Content.ToString() != "CO" && e6.Content.ToString() != "S1" && e6.Content.ToString() != "S2" && e6.Content.ToString() != "P")
                        {
                            c6.IsEnabled = true;
                            c6.Click += C6_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b6.Content = "CO";
                            VettCorazzate[0] = "B6";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a6")
                        {
                            VettCorazzate[1] = "B6";
                            VettCorazzate[2] = "C6";
                            VettCorazzate[3] = "D6";
                            b6.Content = "CO";
                            c6.Content = "CO";
                            d6.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b7")
                        {
                            VettCorazzate[1] = "B6";
                            VettCorazzate[2] = "B5";
                            VettCorazzate[3] = "B4";
                            b4.Content = "CO";
                            b6.Content = "CO";
                            b5.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b5")
                        {
                            VettCorazzate[1] = "B6";
                            VettCorazzate[2] = "B7";
                            VettCorazzate[3] = "B8";
                            b8.Content = "CO";
                            b6.Content = "CO";
                            b7.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b5.Content.ToString() != "CA" && b5.Content.ToString() != "CO" && b5.Content.ToString() != "S1" && b5.Content.ToString() != "S2" && b5.Content.ToString() != "P" && b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P")
                        {
                            b5.IsEnabled = true;
                            b5.Click += B5_Click;
                            controllo = true;
                        }
                        if (b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P" && b10.Content.ToString() != "CA" && b10.Content.ToString() != "CO" && b10.Content.ToString() != "S1" && b10.Content.ToString() != "S2" && b10.Content.ToString() != "P")
                        {
                            b7.IsEnabled = true;
                            b7.Click += B7_Click;
                            controllo = true;
                        }
                        if (c6.Content.ToString() != "CA" && c6.Content.ToString() != "CO" && c6.Content.ToString() != "S1" && c6.Content.ToString() != "S2" && c6.Content.ToString() != "P" && d6.Content.ToString() != "CA" && d6.Content.ToString() != "CO" && d6.Content.ToString() != "S1" && d6.Content.ToString() != "S2" && d6.Content.ToString() != "P" && e6.Content.ToString() != "CA" && e6.Content.ToString() != "CO" && e6.Content.ToString() != "S1" && e6.Content.ToString() != "S2" && e6.Content.ToString() != "P")
                        {
                            c6.IsEnabled = true;
                            c6.Click += C6_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b6.Content = "P";
                            VettPortaerei[0] = "B6";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a6")
                        {
                            VettPortaerei[1] = "B6";
                            VettPortaerei[2] = "C6";
                            VettPortaerei[3] = "D6";
                            VettPortaerei[4] = "E6";
                            b6.Content = "P";
                            c6.Content = "P";
                            d6.Content = "P";
                            e6.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b7")
                        {
                            VettPortaerei[1] = "B6";
                            VettPortaerei[2] = "B5";
                            VettPortaerei[3] = "B4";
                            VettPortaerei[4] = "B3";
                            b4.Content = "P";
                            b3.Content = "P";
                            b6.Content = "P";
                            b5.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b5")
                        {
                            VettPortaerei[1] = "B6";
                            VettPortaerei[2] = "B7";
                            VettPortaerei[3] = "B8";
                            VettPortaerei[4] = "B9";
                            b9.Content = "P";
                            b6.Content = "P";
                            b7.Content = "P";
                            b8.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                    }

                }
                bottoneScelto = "b6";
                c = true;
            }
            else
                c = false;
        }

        private void C6_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            if (c == false)
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    if (VettCacciatorpediniere[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P")
                        {
                            b4.IsEnabled = true;
                            b4.Click += B4_Click;
                            controllo = true;
                        }
                        if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P")
                        {
                            b6.IsEnabled = true;
                            b6.Click += B6_Click;
                            controllo = true;
                        }
                        if (a5.Content.ToString() != "CA" && a5.Content.ToString() != "CO" && a5.Content.ToString() != "S1" && a5.Content.ToString() != "S2" && a5.Content.ToString() != "P")
                        {
                            a5.IsEnabled = true;
                            a5.Click += A5_Click;
                            controllo = true;
                        }
                        if (c5.Content.ToString() != "CA" && c5.Content.ToString() != "CO" && c5.Content.ToString() != "S1" && c5.Content.ToString() != "S2" && c5.Content.ToString() != "P")
                        {
                            c5.IsEnabled = true;
                            c5.Click += C5_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b5.Content = "CA";
                            VettCacciatorpediniere[0] = "B5";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        b5.Content = "CA";
                        VettCacciatorpediniere[1] = "B5";
                        btnCac.IsEnabled = false;
                        btnConferma.IsEnabled = true;
                    }
                }
                else if (NaveScelta == "Sottomarino")
                {
                    if (countSott == 1)
                    {
                        if (VettSottomarino1[0] == null)
                        {
                            ButtonsNotEnabled();
                            bool controllo = false;
                            if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P")
                            {
                                b4.IsEnabled = true;
                                b4.Click += B4_Click;
                                controllo = true;
                            }
                            if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P")
                            {
                                b6.IsEnabled = true;
                                b6.Click += B6_Click;
                                controllo = true;
                            }
                            if (c5.Content.ToString() != "CA" && c5.Content.ToString() != "CO" && c5.Content.ToString() != "S1" && c5.Content.ToString() != "S2" && c5.Content.ToString() != "P" && d5.Content.ToString() != "CA" && d5.Content.ToString() != "CO" && d5.Content.ToString() != "S1" && d5.Content.ToString() != "S2" && d5.Content.ToString() != "P")
                            {
                                c5.IsEnabled = true;
                                c5.Click += C5_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b5.Content = "S1";
                                VettSottomarino1[0] = "B5";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a5")
                            {
                                VettSottomarino1[1] = "B5";
                                VettSottomarino1[2] = "C5";
                                b5.Content = "S1";
                                c5.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b6")
                            {
                                VettSottomarino1[1] = "B5";
                                VettSottomarino1[2] = "B4";
                                b5.Content = "S1";
                                b4.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b4")
                            {
                                VettSottomarino1[1] = "B5";
                                VettSottomarino1[2] = "B6";
                                b5.Content = "S1";
                                b6.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c5")
                            {
                                VettSottomarino1[1] = "B5";
                                VettSottomarino1[2] = "A5";
                                b5.Content = "S1";
                                a5.Content = "S1";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                    else if (countSott == 2)
                    {
                        if (VettSottomarino2[0] == null)
                        {
                            ButtonsNotEnabled();

                            bool controllo = false;
                            if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P")
                            {
                                b4.IsEnabled = true;
                                b4.Click += B4_Click;
                                controllo = true;
                            }
                            if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P")
                            {
                                b6.IsEnabled = true;
                                b6.Click += B6_Click;
                                controllo = true;
                            }
                            if (c5.Content.ToString() != "CA" && c5.Content.ToString() != "CO" && c5.Content.ToString() != "S1" && c5.Content.ToString() != "S2" && c5.Content.ToString() != "P" && d5.Content.ToString() != "CA" && d5.Content.ToString() != "CO" && d5.Content.ToString() != "S1" && d5.Content.ToString() != "S2" && d5.Content.ToString() != "P")
                            {
                                c5.IsEnabled = true;
                                c5.Click += C5_Click;
                                controllo = true;
                            }
                            if (controllo == false)
                            {
                                MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                                ButtonsEnabled();
                                controlloBottoniGiaSelezionati();
                            }
                            else
                            {
                                b6.Content = "S2";
                                VettSottomarino2[0] = "B6";
                            }
                        }
                        else
                        {
                            ButtonsNotEnabled();
                            if (bottoneScelto == "a5")
                            {
                                VettSottomarino2[1] = "B5";
                                VettSottomarino2[2] = "C5";
                                b5.Content = "S2";
                                c5.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b6")
                            {
                                VettSottomarino2[1] = "B5";
                                VettSottomarino2[2] = "B4";
                                b5.Content = "S2";
                                b4.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "b4")
                            {
                                VettSottomarino2[1] = "B5";
                                VettSottomarino2[2] = "B6";
                                b5.Content = "S2";
                                b6.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                            else if (bottoneScelto == "c5")
                            {
                                VettSottomarino2[1] = "B5";
                                VettSottomarino2[2] = "A5";
                                b5.Content = "S2";
                                a5.Content = "S2";
                                btnConferma.IsEnabled = true;
                            }
                        }
                    }
                }
                else if (NaveScelta == "Corazzate")
                {
                    if (VettCorazzate[0] == null)
                    {
                        bool controllo = false;

                        ButtonsNotEnabled();
                        if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P")
                        {
                            b4.IsEnabled = true;
                            b4.Click += B4_Click;
                            controllo = true;
                        }
                        if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P")
                        {
                            b6.IsEnabled = true;
                            b6.Click += B6_Click;
                            controllo = true;
                        }
                        if (c5.Content.ToString() != "CA" && c5.Content.ToString() != "CO" && c5.Content.ToString() != "S1" && c5.Content.ToString() != "S2" && c5.Content.ToString() != "P" && d5.Content.ToString() != "CA" && d5.Content.ToString() != "CO" && d5.Content.ToString() != "S1" && d5.Content.ToString() != "S2" && d5.Content.ToString() != "P" && e5.Content.ToString() != "CA" && e5.Content.ToString() != "CO" && e5.Content.ToString() != "S1" && e5.Content.ToString() != "S2" && e5.Content.ToString() != "P")
                        {
                            c5.IsEnabled = true;
                            c5.Click += C5_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b5.Content = "CO";
                            VettCorazzate[0] = "B5";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a5")
                        {
                            VettCorazzate[1] = "B5";
                            VettCorazzate[2] = "C5";
                            VettCorazzate[3] = "D5";
                            b5.Content = "CO";
                            c5.Content = "CO";
                            d5.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b6")
                        {
                            VettCorazzate[1] = "B5";
                            VettCorazzate[2] = "B4";
                            VettCorazzate[3] = "B3";
                            b5.Content = "CO";
                            b4.Content = "CO";
                            b3.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }else if (bottoneScelto == "b4")
                        {
                            VettCorazzate[1] = "B5";
                            VettCorazzate[2] = "B6";
                            VettCorazzate[3] = "B7";
                            b5.Content = "CO";
                            b6.Content = "CO";
                            b7.Content = "CO";
                            btnConferma.IsEnabled = true;
                        }
                    }
                }
                else if (NaveScelta == "Portaerei")
                {
                    if (VettPortaerei[0] == null)
                    {
                        bool controllo = false;
                        ButtonsNotEnabled();
                        if (b4.Content.ToString() != "CA" && b4.Content.ToString() != "CO" && b4.Content.ToString() != "S1" && b4.Content.ToString() != "S2" && b4.Content.ToString() != "P" && b3.Content.ToString() != "CA" && b3.Content.ToString() != "CO" && b3.Content.ToString() != "S1" && b3.Content.ToString() != "S2" && b3.Content.ToString() != "P" && b2.Content.ToString() != "CA" && b2.Content.ToString() != "CO" && b2.Content.ToString() != "S1" && b2.Content.ToString() != "S2" && b2.Content.ToString() != "P" && b1.Content.ToString() != "CA" && b1.Content.ToString() != "CO" && b1.Content.ToString() != "S1" && b1.Content.ToString() != "S2" && b1.Content.ToString() != "P")
                        {
                            b4.IsEnabled = true;
                            b4.Click += B4_Click;
                            controllo = true;
                        }
                        if (b6.Content.ToString() != "CA" && b6.Content.ToString() != "CO" && b6.Content.ToString() != "S1" && b6.Content.ToString() != "S2" && b6.Content.ToString() != "P" && b7.Content.ToString() != "CA" && b7.Content.ToString() != "CO" && b7.Content.ToString() != "S1" && b7.Content.ToString() != "S2" && b7.Content.ToString() != "P" && b8.Content.ToString() != "CA" && b8.Content.ToString() != "CO" && b8.Content.ToString() != "S1" && b8.Content.ToString() != "S2" && b8.Content.ToString() != "P" && b9.Content.ToString() != "CA" && b9.Content.ToString() != "CO" && b9.Content.ToString() != "S1" && b9.Content.ToString() != "S2" && b9.Content.ToString() != "P")
                        {
                            b6.IsEnabled = true;
                            b6.Click += B6_Click;
                            controllo = true;
                        }
                        if (c5.Content.ToString() != "CA" && c5.Content.ToString() != "CO" && c5.Content.ToString() != "S1" && c5.Content.ToString() != "S2" && c5.Content.ToString() != "P" && d5.Content.ToString() != "CA" && d5.Content.ToString() != "CO" && d5.Content.ToString() != "S1" && d5.Content.ToString() != "S2" && d5.Content.ToString() != "P" && e5.Content.ToString() != "CA" && e5.Content.ToString() != "CO" && e5.Content.ToString() != "S1" && e5.Content.ToString() != "S2" && e5.Content.ToString() != "P" && f5.Content.ToString() != "CA" && f5.Content.ToString() != "CO" && f5.Content.ToString() != "S1" && f5.Content.ToString() != "S2" && f5.Content.ToString() != "P")
                        {
                            c5.IsEnabled = true;
                            c5.Click += C5_Click;
                            controllo = true;
                        }
                        if (controllo == false)
                        {
                            MessageBox.Show("Non ci sono caselle disponibili intorno alla casella selezionata", "Error");
                            ButtonsEnabled();
                            controlloBottoniGiaSelezionati();
                        }
                        else
                        {
                            b5.Content = "P";
                            VettPortaerei[0] = "B5";
                        }
                    }
                    else
                    {
                        ButtonsNotEnabled();
                        if (bottoneScelto == "a5")
                        {
                            VettPortaerei[1] = "B5";
                            VettPortaerei[2] = "C5";
                            VettPortaerei[3] = "D5";
                            VettPortaerei[4] = "E5";
                            b5.Content = "P";
                            c5.Content = "P";
                            d5.Content = "P";
                            e5.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b6")
                        {
                            VettPortaerei[1] = "B5";
                            VettPortaerei[2] = "B4";
                            VettPortaerei[3] = "B3";
                            VettPortaerei[4] = "B2";
                            b4.Content = "P";
                            b3.Content = "P";
                            b2.Content = "P";
                            b5.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                        else if (bottoneScelto == "b4")
                        {
                            VettPortaerei[1] = "B5";
                            VettPortaerei[2] = "B6";
                            VettPortaerei[3] = "B7";
                            VettPortaerei[4] = "B8";
                            b5.Content = "P";
                            b6.Content = "P";
                            b7.Content = "P";
                            b8.Content = "P";
                            btnConferma.IsEnabled = true;
                        }
                    }

                }
                bottoneScelto = "b5";
                c = true;
            }
            else
                c = false;
        }

        private void C5_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCac_Click(object sender, RoutedEventArgs e)
        {
            ButtonsEnabled();
            controlloBottoniGiaSelezionati();
            NaveScelta = "Cacciatorpediniere";
            btnCor.IsEnabled = false;
            btnPor.IsEnabled = false;
            btnSot.IsEnabled = false;
            btnCac.IsEnabled = false;
            a1.Click += A1_Click;
            b1.Click += B1_Click;
            a2.Click += A2_Click;
            a3.Click += A3_Click;
            a5.Click += A5_Click;
            a4.Click += A4_Click;
            a6.Click += A6_Click;
            a7.Click += A7_Click;
            a8.Click += A8_Click;
            a9.Click += A9_Click;
            a10.Click += A10_Click;
            b2.Click += B2_Click;
            b3.Click += B3_Click;
            b4.Click += B4_Click;
            b5.Click += B5_Click;
            b6.Click += B6_Click;
            b7.Click += B7_Click;
            b8.Click += B8_Click;
            b9.Click += B9_Click;
            b10.Click += B10_Click;
            c1.Click += C1_Click;
            c2.Click += C2_Click;
            c3.Click += C3_Click;
            c4.Click += C4_Click;
            c5.Click += C5_Click;
            c6.Click += C6_Click;
            c7.Click += C7_Click;
            c8.Click += C8_Click;
            c9.Click += C9_Click;
            c10.Click += C10_Click;
        }

        private void btnSot_Click(object sender, RoutedEventArgs e)
        {
            ButtonsEnabled();
            btnCor.IsEnabled = false;
            btnPor.IsEnabled = false;
            btnSot.IsEnabled = false;
            btnCac.IsEnabled = false;
            controlloBottoniGiaSelezionati();
            NaveScelta = "Sottomarino";
            countSott++;
            if (countSott == 1)
                lblSot.Content = 1;
            a1.Click += A1_Click;
            b1.Click += B1_Click;
            a3.Click += A3_Click;
            a4.Click += A4_Click;
            a2.Click += A2_Click;
            a5.Click += A5_Click;
            a6.Click += A6_Click;
            a7.Click += A7_Click;
            a8.Click += A8_Click;
            a9.Click += A9_Click;
            a10.Click += A10_Click;
            b2.Click += B2_Click;
            b3.Click += B3_Click;
            b4.Click += B4_Click;
            b5.Click += B5_Click;
            b6.Click += B6_Click;
            b7.Click += B7_Click;
            b8.Click += B8_Click;
            b9.Click += B9_Click;
            b10.Click += B10_Click;
            c1.Click += C1_Click;
            c2.Click += C2_Click;
            c3.Click += C3_Click;
            c4.Click += C4_Click;
            c5.Click += C5_Click;
            c6.Click += C6_Click;
            c7.Click += C7_Click;
            c8.Click += C8_Click;
            c9.Click += C9_Click;
            c10.Click += C10_Click;
        }

        private void btnCor_Click(object sender, RoutedEventArgs e)
        {
            ButtonsEnabled();
            controlloBottoniGiaSelezionati();
            NaveScelta = "Corazzate";
            btnCor.IsEnabled = false;
            btnPor.IsEnabled = false;
            btnSot.IsEnabled = false;
            btnCac.IsEnabled = false;
            a1.Click += A1_Click;
            b1.Click += B1_Click;
            a3.Click += A3_Click;
            a4.Click += A4_Click;
            a2.Click += A2_Click;
            a5.Click += A5_Click;
            a6.Click += A6_Click;
            a7.Click += A7_Click;
            a8.Click += A8_Click;
            a9.Click += A9_Click;
            a10.Click += A10_Click;
            b2.Click += B2_Click;
            b3.Click += B3_Click;
            b4.Click += B4_Click;
            b5.Click += B5_Click;
            b6.Click += B6_Click;
            b7.Click += B7_Click;
            b8.Click += B8_Click;
            b9.Click += B9_Click;
            b10.Click += B10_Click;
            c1.Click += C1_Click;
            c2.Click += C2_Click;
            c3.Click += C3_Click;
            c4.Click += C4_Click;
            c5.Click += C5_Click;
            c6.Click += C6_Click;
            c7.Click += C7_Click;
            c8.Click += C8_Click;
            c9.Click += C9_Click;
            c10.Click += C10_Click;
        }

        private void btnPor_Click(object sender, RoutedEventArgs e)
        {
            ButtonsEnabled();
            controlloBottoniGiaSelezionati();
            NaveScelta = "Portaerei";
            btnCor.IsEnabled = false;
            btnPor.IsEnabled = false;
            btnSot.IsEnabled = false;
            btnCac.IsEnabled = false;
            a1.Click += A1_Click;
            b1.Click += B1_Click;
            a3.Click += A3_Click;
            a4.Click += A4_Click;
            a2.Click += A2_Click;
            a5.Click += A5_Click;
            a6.Click += A6_Click;
            a7.Click += A7_Click;
            a8.Click += A8_Click;
            a9.Click += A9_Click;
            a10.Click += A10_Click;
            b2.Click += B2_Click;
            b3.Click += B3_Click;
            b4.Click += B4_Click;
            b5.Click += B5_Click;
            b6.Click += B6_Click;
            b7.Click += B7_Click;
            b8.Click += B8_Click;
            b9.Click += B9_Click;
            b10.Click += B10_Click;
            c1.Click += C1_Click;
            c2.Click += C2_Click;
            c3.Click += C3_Click;
            c4.Click += C4_Click;
            c5.Click += C5_Click;
            c6.Click += C6_Click;
            c7.Click += C7_Click;
            c8.Click += C8_Click;
            c9.Click += C9_Click;
            c10.Click += C10_Click;
        }

        private void btnAnnulla_Click(object sender, RoutedEventArgs e)
        {
            MainWindow finestra2 = new MainWindow();
            finestra2.Show();
            this.Close();
            btnConferma.IsEnabled = false;
        }

        private void btnConferma_Click(object sender, RoutedEventArgs e)
        {
            if (VettCacciatorpediniere[0] == null && VettCacciatorpediniere[1] == null && VettCorazzate[0] == null && VettCorazzate[1] == null && VettCorazzate[2] == null && VettCorazzate[3] == null && VettPortaerei[0] == null && VettPortaerei[1] == null && VettPortaerei[2] == null && VettPortaerei[3] == null && VettPortaerei[4] == null && VettSottomarino1[0] == null && VettSottomarino1[1] == null && VettSottomarino1[2] == null && VettSottomarino2[0] == null && VettSottomarino2[1] == null && VettSottomarino2[2] == null)
                MessageBox.Show("Errore imprevisto", "errore");
            else
            {
                ButtonsEnabled();
                controlloBottoniGiaSelezionati();
            }
            if (VettCacciatorpediniere[0] != null && VettCacciatorpediniere[1] != null)
            {
                btnCor.IsEnabled = false;
                lblCac.Content = 0;
            }
            else
                btnCac.IsEnabled = true;

            if (VettCorazzate[0] != null && VettCorazzate[1] != null && VettCorazzate[2] != null && VettCorazzate[3] != null)
            {
                btnCor.IsEnabled = false;
                lblCor.Content = 0;
            }
            else
                btnCor.IsEnabled = true;

            if (VettPortaerei[0] != null && VettPortaerei[1] != null && VettPortaerei[2] != null && VettPortaerei[3] != null && VettPortaerei[4] != null)
            {
                btnPor.IsEnabled = false;
                lblPor.Content = 0;
            }
            else
                btnPor.IsEnabled = true;
            if (VettSottomarino1[0] != null && VettSottomarino1[1] != null && VettSottomarino1[2] != null && VettSottomarino2[0] != null && VettSottomarino2[1] != null && VettSottomarino2[2] != null)
            {
                btnSot.IsEnabled = false;
                lblSot.Content = 0;
            }
            else
                btnSot.IsEnabled = true;

            btnConferma.IsEnabled = false;

            NaveScelta = "";
        }

        private void controlloBottoniGiaSelezionati()
        {
            if (a1.Content.ToString() != "A1")
            {
                a1.IsEnabled = false;
            }

            if (a2.Content.ToString() != "A2")
            {
                a2.IsEnabled = false;
            }

            if (a3.Content.ToString() != "A3")
            {
                a3.IsEnabled = false;
            }

            if (a4.Content.ToString() != "A4")
            {
                a4.IsEnabled = false;
            }

            if (a5.Content.ToString() != "A5")
            {
                a5.IsEnabled = false;
            }

            if (a6.Content.ToString() != "A6")
            {
                a6.IsEnabled = false;
            }

            if (a7.Content.ToString() != "A7")
            {
                a7.IsEnabled = false;
            }

            if (a8.Content.ToString() != "A8")
            {
                a8.IsEnabled = false;
            }

            if (a9.Content.ToString() != "A9")
            {
                a9.IsEnabled = false;
            }

            if (a10.Content.ToString() != "A10")
            {
                a10.IsEnabled = false;
            }



            if (b1.Content.ToString() != "B1")
            {
                b1.IsEnabled = false;
            }

            if (b2.Content.ToString() != "B2")
            {
                b2.IsEnabled = false;
            }

            if (b3.Content.ToString() != "B3")
            {
                b3.IsEnabled = false;
            }

            if (b4.Content.ToString() != "B4")
            {
                b4.IsEnabled = false;
            }

            if (b5.Content.ToString() != "B5")
            {
                b5.IsEnabled = false;
            }

            if (b6.Content.ToString() != "B6")
            {
                b6.IsEnabled = false;
            }

            if (b7.Content.ToString() != "B7")
            {
                b7.IsEnabled = false;
            }

            if (b8.Content.ToString() != "B8")
            {
                b8.IsEnabled = false;
            }

            if (b9.Content.ToString() != "B9")
            {
                b9.IsEnabled = false;
            }

            if (b10.Content.ToString() != "B10")
            {
                b10.IsEnabled = false;
            }


            if (c1.Content.ToString() != "C1")
            {
                c1.IsEnabled = false;
            }

            if (c2.Content.ToString() != "C2")
            {
                c2.IsEnabled = false;
            }

            if (c3.Content.ToString() != "C3")
            {
                c3.IsEnabled = false;
            }

            if (c4.Content.ToString() != "C4")
            {
                c4.IsEnabled = false;
            }

            if (c5.Content.ToString() != "C5")
            {
                c5.IsEnabled = false;
            }

            if (c6.Content.ToString() != "C6")
            {
                c6.IsEnabled = false;
            }

            if (c7.Content.ToString() != "C7")
            {
                c7.IsEnabled = false;
            }

            if (c8.Content.ToString() != "C8")
            {
                c8.IsEnabled = false;
            }

            if (c9.Content.ToString() != "C9")
            {
                c9.IsEnabled = false;
            }

            if (c10.Content.ToString() != "C10")
            {
                c10.IsEnabled = false;
            }



            if (d1.Content.ToString() != "D1")
            {
                d1.IsEnabled = false;
            }

            if (d2.Content.ToString() != "D2")
            {
                d2.IsEnabled = false;
            }

            if (d3.Content.ToString() != "D3")
            {
                d3.IsEnabled = false;
            }

            if (d4.Content.ToString() != "D4")
            {
                d4.IsEnabled = false;
            }

            if (d5.Content.ToString() != "D5")
            {
                d5.IsEnabled = false;
            }

            if (d6.Content.ToString() != "D6")
            {
                d6.IsEnabled = false;
            }

            if (d7.Content.ToString() != "D7")
            {
                d7.IsEnabled = false;
            }

            if (d8.Content.ToString() != "D8")
            {
                d8.IsEnabled = false;
            }

            if (d9.Content.ToString() != "D9")
            {
                d9.IsEnabled = false;
            }

            if (d10.Content.ToString() != "D10")
            {
                d10.IsEnabled = false;
            }




            if (e1.Content.ToString() != "E1")
            {
                e1.IsEnabled = false;
            }

            if (e2.Content.ToString() != "E2")
            {
                e2.IsEnabled = false;
            }

            if (e3.Content.ToString() != "E3")
            {
                e3.IsEnabled = false;
            }

            if (e4.Content.ToString() != "E4")
            {
                e4.IsEnabled = false;
            }

            if (e5.Content.ToString() != "E5")
            {
                e5.IsEnabled = false;
            }

            if (e6.Content.ToString() != "E6")
            {
                e6.IsEnabled = false;
            }

            if (e7.Content.ToString() != "E7")
            {
                e7.IsEnabled = false;
            }

            if (e8.Content.ToString() != "E8")
            {
                e8.IsEnabled = false;
            }

            if (e9.Content.ToString() != "E9")
            {
                e9.IsEnabled = false;
            }

            if (e10.Content.ToString() != "E10")
            {
                e10.IsEnabled = false;
            }


            if (f1.Content.ToString() != "F1")
            {
                f1.IsEnabled = false;
            }

            if (f2.Content.ToString() != "F2")
            {
                f2.IsEnabled = false;
            }

            if (f3.Content.ToString() != "F3")
            {
                f3.IsEnabled = false;
            }

            if (f4.Content.ToString() != "F4")
            {
                f4.IsEnabled = false;
            }

            if (f5.Content.ToString() != "F5")
            {
                f5.IsEnabled = false;
            }

            if (f6.Content.ToString() != "F6")
            {
                f6.IsEnabled = false;
            }

            if (f7.Content.ToString() != "F7")
            {
                f7.IsEnabled = false;
            }

            if (f8.Content.ToString() != "F8")
            {
                f8.IsEnabled = false;
            }

            if (f9.Content.ToString() != "F9")
            {
                f9.IsEnabled = false;
            }

            if (f10.Content.ToString() != "F10")
            {
                f10.IsEnabled = false;
            }



            if (g1.Content.ToString() != "G1")
            {
                g1.IsEnabled = false;
            }

            if (g2.Content.ToString() != "G2")
            {
                g2.IsEnabled = false;
            }

            if (g3.Content.ToString() != "G3")
            {
                g3.IsEnabled = false;
            }

            if (g4.Content.ToString() != "G4")
            {
                g4.IsEnabled = false;
            }

            if (g5.Content.ToString() != "G5")
            {
                g5.IsEnabled = false;
            }

            if (g6.Content.ToString() != "G6")
            {
                g6.IsEnabled = false;
            }

            if (g7.Content.ToString() != "G7")
            {
                g7.IsEnabled = false;
            }

            if (g8.Content.ToString() != "G8")
            {
                g8.IsEnabled = false;
            }

            if (g9.Content.ToString() != "G9")
            {
                g9.IsEnabled = false;
            }

            if (g10.Content.ToString() != "G10")
            {
                g10.IsEnabled = false;
            }




            if (h1.Content.ToString() != "H1")
            {
                h1.IsEnabled = false;
            }

            if (h2.Content.ToString() != "H2")
            {
                h2.IsEnabled = false;
            }

            if (h3.Content.ToString() != "H3")
            {
                h3.IsEnabled = false;
            }

            if (h4.Content.ToString() != "H4")
            {
                h4.IsEnabled = false;
            }

            if (h5.Content.ToString() != "H5")
            {
                h5.IsEnabled = false;
            }

            if (h6.Content.ToString() != "H6")
            {
                h6.IsEnabled = false;
            }

            if (h7.Content.ToString() != "H7")
            {
                h7.IsEnabled = false;
            }

            if (h8.Content.ToString() != "H8")
            {
                h8.IsEnabled = false;
            }

            if (h9.Content.ToString() != "H9")
            {
                h9.IsEnabled = false;
            }

            if (h10.Content.ToString() != "H10")
            {
                h10.IsEnabled = false;
            }




            if (i1.Content.ToString() != "I1")
            {
                i1.IsEnabled = false;
            }

            if (i2.Content.ToString() != "I2")
            {
                i2.IsEnabled = false;
            }

            if (i3.Content.ToString() != "I3")
            {
                i3.IsEnabled = false;
            }

            if (i4.Content.ToString() != "I4")
            {
                i4.IsEnabled = false;
            }

            if (i5.Content.ToString() != "I5")
            {
                i5.IsEnabled = false;
            }

            if (i6.Content.ToString() != "I6")
            {
                i6.IsEnabled = false;
            }

            if (i7.Content.ToString() != "I7")
            {
                i7.IsEnabled = false;
            }

            if (i8.Content.ToString() != "I8")
            {
                i8.IsEnabled = false;
            }

            if (i9.Content.ToString() != "I9")
            {
                i9.IsEnabled = false;
            }

            if (i10.Content.ToString() != "I10")
            {
                i10.IsEnabled = false;
            }



            if (j1.Content.ToString() != "J1")
            {
                j1.IsEnabled = false;
            }

            if (j2.Content.ToString() != "J2")
            {
                j2.IsEnabled = false;
            }

            if (j3.Content.ToString() != "J3")
            {
                j3.IsEnabled = false;
            }

            if (j4.Content.ToString() != "J4")
            {
                j4.IsEnabled = false;
            }

            if (j5.Content.ToString() != "J5")
            {
                j5.IsEnabled = false;
            }

            if (j6.Content.ToString() != "J6")
            {
                j6.IsEnabled = false;
            }

            if (j7.Content.ToString() != "J7")
            {
                j7.IsEnabled = false;
            }

            if (j8.Content.ToString() != "J8")
            {
                j8.IsEnabled = false;
            }

            if (j9.Content.ToString() != "J9")
            {
                j9.IsEnabled = false;
            }

            if (j10.Content.ToString() != "J10")
            {
                j10.IsEnabled = false;
            }
        }
    }
}

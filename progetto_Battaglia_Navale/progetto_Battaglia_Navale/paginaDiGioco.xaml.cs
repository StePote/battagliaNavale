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
            RowDefinition r3= new RowDefinition();
            RowDefinition r4 = new RowDefinition();
            RowDefinition r5 = new RowDefinition();
            RowDefinition r6 = new RowDefinition();
            RowDefinition r7 = new RowDefinition();
            RowDefinition r8 = new RowDefinition();
            RowDefinition r9= new RowDefinition();
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
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            if (a1.Content.ToString() != "CA" && a1.Content.ToString() != "S" && a1.Content.ToString() != "CO" && a1.Content.ToString() != "P")
            {
                if (NaveScelta == "Cacciatorpediniere")
                {
                    a1.Content = "CA";
                    VettCacciatorpediniere[0] = "A1";
                    ButtonsNotEnabled();
                    b1.IsEnabled = true;
                    a2.IsEnabled = true;
                    b1.Click += a1_b1_Click;
                    a2.Click += a1_a2_Click;
                }
                else if (NaveScelta == "Sottomarino")
                {
                    a1.Content = "S";
                    if (countSott == 0)
                        VettSottomarino1[0] = "A1";
                    else if (countSott == 1)
                        VettSottomarino2[0] = "A1";
                    ButtonsNotEnabled();
                    b1.IsEnabled = true;
                    c1.IsEnabled = true;
                    a2.IsEnabled = true;
                    a3.IsEnabled = true;
                    b1.Click += a1_b1_Click_sottomarino;
                    a2.Click += a1_a2_Click_sottomarino;
                }
                else if (NaveScelta == "Portaerei")
                {
                    a1.Content = "P";
                    VettPortaerei[0] = "A1";
                    ButtonsNotEnabled();
                    b1.IsEnabled = true;
                    c1.IsEnabled = true;
                    d1.IsEnabled = true;
                    e1.IsEnabled = true;
                    a2.IsEnabled = true;
                    a3.IsEnabled = true;
                    a4.IsEnabled = true;
                    a5.IsEnabled = true;
                    b1.Click += a1_b1_Click_portaerei;
                    a2.Click += a1_a2_Click_portaerei;
                }
            }
            else
                MessageBox.Show("Casella già selezionata", "Attention!");
        }

        private void a1_b1_Click_portaerei(object sender, RoutedEventArgs e)
        {
            a2.IsEnabled = false;
            a3.IsEnabled = false;
            a4.IsEnabled = false;
            a5.IsEnabled = false;
            b1.Content = "P";
            c1.Content = "P";
            d1.Content = "P";
            e1.Content = "P";
            VettPortaerei[1] = "B1";
            VettPortaerei[2] = "C1";
            VettPortaerei[3] = "D1";
            VettPortaerei[4] = "E1";
            btnConferma.IsEnabled = true;
        }

        private void a1_a2_Click_portaerei(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = false;
            c1.IsEnabled = false;
            d1.IsEnabled = false;
            e1.IsEnabled = false;
            a2.Content = "P";
            a3.Content = "P";
            a4.Content = "P";
            a5.Content = "P";
            VettPortaerei[1] = "A2";
            VettPortaerei[2] = "A3";
            VettPortaerei[3] = "A4";
            VettPortaerei[4] = "A5";
            btnConferma.IsEnabled = true;
        }
        private void a1_a2_Click_corazzate(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = false;
            c1.IsEnabled = false;
            d1.IsEnabled = false;
            a2.Content = "CO";
            a3.Content = "CO";
            a4.Content = "CO";
            VettCorazzate[1] = "A2";
            VettCorazzate[2] = "A3";
            VettCorazzate[3] = "A4";
            btnConferma.IsEnabled = true;
        }

        private void a1_b1_Click_corazzate(object sender, RoutedEventArgs e)
        {
            a2.IsEnabled = false;
            a3.IsEnabled = false;
            a4.IsEnabled = false;
            b1.Content = "CO";
            c1.Content = "CO";
            d1.Content = "CO";
            VettCorazzate[1] = "B1";
            VettCorazzate[2] = "C1";
            VettCorazzate[2] = "D1";
            btnConferma.IsEnabled = true;
        }

        private void a1_a2_Click_sottomarino(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = false;
            c1.IsEnabled = false;
            a2.Content = "S";
            a3.Content = "S";
            if (countSott == 0)
            {
                VettSottomarino1[1] = "A2";
                VettSottomarino1[2] = "A3";
            }
            else if (countSott == 1)
            {
                VettSottomarino2[1] = "A2";
                VettSottomarino2[2] = "A3";
            }
            btnConferma.IsEnabled = true;
        }
        private void a1_b1_Click_sottomarino(object sender, RoutedEventArgs e)
        {
            a2.IsEnabled = false;
            a3.IsEnabled = false;
            b1.Content = "S";
            c1.Content = "S";

            if (countSott == 0)
            {
                VettSottomarino1[1] = "B1";
                VettSottomarino1[2] = "C1";
            }
            else if (countSott == 1)
            {
                VettSottomarino1[1] = "B1";
                VettSottomarino1[2] = "C1";
            }
            btnConferma.IsEnabled = true;
        }
        private void a1_a2_Click(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = false;
            a2.Content = "CA";
            VettCacciatorpediniere[1] = "A2";
            btnCac.IsEnabled = false;
            btnConferma.IsEnabled = true;
        }
        private void a1_b1_Click(object sender, RoutedEventArgs e)
        {
            a2.IsEnabled = false;
            b1.Content = "CA";
            VettCacciatorpediniere[1] = "B1";
            btnCac.IsEnabled = false;
            btnConferma.IsEnabled = true;
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

            a1.Click += A1_Click;
            b1.Click += B1_Click;
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
        }

        private void btnPor_Click(object sender, RoutedEventArgs e)
        {
            ButtonsEnabled();
            NaveScelta = "Portaerei";
            btnCor.IsEnabled = false;
            btnPor.IsEnabled = false;
            btnSot.IsEnabled = false;
            btnCac.IsEnabled = false;
            a1.Click += A1_Click;
            b1.Click += B1_Click;
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
            if(a1.Content.ToString() != "A1")
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

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
using System.Threading;

namespace _1popitka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[] inf = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int puv = 2;
        public int pr = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Butt_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Background = (Brush)new BrushConverter().ConvertFrom("#FFFCE5AD");
            string w = "";
            int v = 0;
            if (puv == 1)
            {
                v = 1;
                w = "X";
            }
            if (puv == 2)
            {
                v = 2;
                w = "O";
            }
            if ((sender as Button).Name == "OdOd")
            {
                OdOdT.Text = w;
                inf[0] = v;
                OdOd.IsEnabled = false;
            }
            if ((sender as Button).Name == "OdDv")
            {
                OdDvT.Text = w;
                inf[1] = v;
                OdDv.IsEnabled = false;
            }
            if ((sender as Button).Name == "OdTr")
            {
                OdTrT.Text = w;
                inf[2] = v;
                OdTr.IsEnabled = false;
            }
            if ((sender as Button).Name == "DvOd")
            {
                DvOdT.Text = w;
                inf[3] = v;
                DvOd.IsEnabled = false;
            }
            if ((sender as Button).Name == "DvDv")
            {
                DvDvT.Text = w;
                inf[4] = v;
                DvDv.IsEnabled = false;
            }
            if ((sender as Button).Name == "DvTr")
            {
                DvTrT.Text = w;
                inf[5] = v;
                DvTr.IsEnabled = false;
            }
            if ((sender as Button).Name == "TrOd")
            {
                TrOdT.Text = w;
                inf[6] = v;
                TrOd.IsEnabled = false;
            }
            if ((sender as Button).Name == "TrDv")
            {
                TrDvT.Text = w;
                inf[7] = v;
                TrDv.IsEnabled = false;
            }
            if ((sender as Button).Name == "TrTr")
            {
                TrTrT.Text = w;
                inf[8] = v;
                TrTr.IsEnabled = false;
            }
            Proverka();
            Protivnik();
            Proverka();
        }
        private void Proverka()
        {
            int d = 0, b = 0;
            d = puv;
            if (d == 1)
            {
                b = 2;
            }
            else
            {
                b = 1;
            }

            if (inf[0] == d && inf[1] == d && inf[2] == d || inf[3] == d && inf[4] == d && inf[5] == d || inf[6] == d && inf[7] == d && inf[8] == d || inf[0] == d && inf[4] == d && inf[8] == d || inf[2] == d && inf[4] == d && inf[6] == d || inf[0] == d && inf[3] == d && inf[6] == d || inf[1] == d && inf[4] == d && inf[7] == d || inf[2] == d && inf[5] == d && inf[8] == d)
            {
                pozdravlenia.Text = "Вы победили";
                Starr.IsEnabled = true;
                OdOd.IsEnabled = false;
                OdDv.IsEnabled = false;
                OdTr.IsEnabled = false;
                DvOd.IsEnabled = false;
                DvDv.IsEnabled = false;
                DvTr.IsEnabled = false;
                TrOd.IsEnabled = false;
                TrDv.IsEnabled = false;
                TrTr.IsEnabled = false;
                pr = 1;

            }
            if (inf[0] == b && inf[1] == b && inf[2] == b || inf[3] == b && inf[4] == b && inf[5] == b || inf[6] == b && inf[7] == b && inf[8] == b || inf[0] == b && inf[4] == b && inf[8] == b || inf[2] == b && inf[4] == b && inf[6] == b || inf[0] == b && inf[3] == b && inf[6] == b || inf[1] == b && inf[4] == b && inf[7] == b || inf[2] == b && inf[5] == b && inf[8] == b)
            {
                pozdravlenia.Text = "Вы проиграли";
                Starr.IsEnabled = true;
                OdOd.IsEnabled = false;
                OdDv.IsEnabled = false;
                OdTr.IsEnabled = false;
                DvOd.IsEnabled = false;
                DvDv.IsEnabled = false;
                DvTr.IsEnabled = false;
                TrOd.IsEnabled = false;
                TrDv.IsEnabled = false;
                TrTr.IsEnabled = false;
                pr = 1;
            }
            if (pr == 0)
            {
                int j = 0;
                for (int i = 0; i < 9; i++)
                {
                    if (inf[i] != 0)
                    {
                        j++;
                    }
                }
                if (j == 9)
                {
                    pozdravlenia.Text = "Ничья";
                    Starr.IsEnabled = true;
                }
            }
        }
        private void Protivnik()
        {
            if (pr == 0)
            {

                Random r = new Random();
                int s = r.Next(0, 9);
                int a = -1;
                int d = 0;

                while (a == -1)
                {

                    if (inf[s] == 1 || inf[s] == 2)
                    {
                        s = r.Next(0, 9);
                    }
                    else
                    {
                        a = 0;
                    }
                }
                string w = "";
                if (puv == 1)
                {
                    w = "O";
                    inf[s] = 2;
                }
                else
                {
                    w = "X";
                    inf[s] = 1;
                }
                if (s == 0)
                {
                    OdOdT.Text = w;
                    OdOd.IsEnabled = false;
                }
                if (s == 1)
                {
                    OdDvT.Text = w;
                    OdDv.IsEnabled = false;
                }
                if (s == 2)
                {
                    OdTrT.Text = w;
                    OdTr.IsEnabled = false;
                }
                if (s == 3)
                {
                    DvOdT.Text = w;
                    DvOd.IsEnabled = false;
                }
                if (s == 4)
                {
                    DvDvT.Text = w;
                    DvDv.IsEnabled = false;
                }
                if (s == 5)
                {
                    DvTrT.Text = w;
                    DvTr.IsEnabled = false;
                }
                if (s == 6)
                {
                    TrOdT.Text = w;
                    TrOd.IsEnabled = false;
                }
                if (s == 7)
                {
                    TrDvT.Text = w;
                    TrDv.IsEnabled = false;
                }
                if (s == 8)
                {
                    TrTrT.Text = w;
                    TrTr.IsEnabled = false;
                }
            }
        }
        private void staart(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                inf[i] = 0;

            }
/*
            Button[] buttons = new Button[] { OdOd, OdDv, };
            foreach (var item in buttons)
            {

            }*/
            OdOd.IsEnabled = true;
            OdOdT.Text = "";
            OdOd.Background = (Brush)new BrushConverter().ConvertFrom("#FFFCADAD");
            OdDv.IsEnabled = true;
            OdDvT.Text = "";
            OdDv.Background = (Brush)new BrushConverter().ConvertFrom("#FFFCADAD");
            OdTr.IsEnabled = true;
            OdTrT.Text = "";
            OdTr.Background = (Brush)new BrushConverter().ConvertFrom("#FFFCADAD");
            DvOd.IsEnabled = true;
            DvOdT.Text = "";
            DvOd.Background = (Brush)new BrushConverter().ConvertFrom("#FFFCADAD");
            DvDv.IsEnabled = true;
            DvDvT.Text = "";
            DvDv.Background = (Brush)new BrushConverter().ConvertFrom("#FFFCADAD");
            DvTr.IsEnabled = true;
            DvTrT.Text = "";
            DvTr.Background = (Brush)new BrushConverter().ConvertFrom("#FFFCADAD");
            TrOd.IsEnabled = true;
            TrOdT.Text = "";
            TrOd.Background = (Brush)new BrushConverter().ConvertFrom("#FFFCADAD");
            TrDv.IsEnabled = true;
            TrDvT.Text = "";
            TrDv.Background = (Brush)new BrushConverter().ConvertFrom("#FFFCADAD");
            TrTr.IsEnabled = true;
            TrTrT.Text = "";
            TrTr.Background = (Brush)new BrushConverter().ConvertFrom("#FFFCADAD");
            Starr.IsEnabled = false;
            pozdravlenia.Text = "";
            pr = 0;
            if (puv == 1)
            {
                puv = 2;
            }
            else
            {
                puv = 1;
            }
            if (puv == 2)
            {
                Protivnik();
            }

        }
    }
}

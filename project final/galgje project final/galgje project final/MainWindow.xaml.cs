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

namespace galgje_project_final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        private string[] galgjeWoorden = new string[]
        {
            "grafeem",
            "tjiftjaf",
            "maquette",
            "kitsch",
            "pochet",
            "convocaat",
            "jakkeren",
            "collaps",
            "zuivel",
            "cesium",
            "voyant",
            "spitten",
            "pancake",
            "gietlepel",
            "karwats",
            "dehydreren",
            "viswijf",
            "flater",
            "cretonne",
            "sennhut",
            "tichel",
            "wijten",
            "cadeau",
            "trotyl",
        };
        Random randomWoord = new Random();
        StringBuilder geheimWoord = new StringBuilder();
        public MainWindow()
        {
            InitializeComponent();           
        }

        

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }                
        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }        
        private void SpelerButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            SpelerButton.Background = Brushes.Black;
            SpelerButton.Foreground = Brushes.Maroon;
            SpelerButton.BorderBrush = Brushes.Red;
        }
        private void SpelerButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
            SpelerButton.Background = Brushes.Maroon;
            SpelerButton.Foreground = Brushes.Black;
            SpelerButton.BorderBrush = Brushes.Black;
        }
        private void SpelerButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            VWBX_InputBox.Visibility = Visibility.Visible;
            VWBX_RaadButton.Visibility = Visibility.Visible;
            VWBX_SpelerButton.Visibility = Visibility.Collapsed;
            VWBX_SpelersButton.Visibility = Visibility.Collapsed;
            NieuwSpelButton.Visibility = Visibility.Visible;

        }
        private void RaadButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            RaadButton.Background = Brushes.Black;
            RaadButton.Foreground = Brushes.Maroon;
            RaadButton.BorderBrush = Brushes.Red;
        }

        private void RaadButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
            RaadButton.Background = Brushes.Maroon;
            RaadButton.Foreground = Brushes.Black;
            RaadButton.BorderBrush = Brushes.Black;
        }

        private void SpelersButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            SpelersButton.Background = Brushes.Black;
            SpelersButton.Foreground = Brushes.Maroon;
            SpelersButton.BorderBrush = Brushes.Red;
        }

        private void SpelersButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
            SpelersButton.Background = Brushes.Maroon;
            SpelersButton.Foreground = Brushes.Black;
            SpelersButton.BorderBrush = Brushes.Black;
        }

        private void SpelersButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            VWBX_SpelersButton.Visibility = Visibility.Collapsed;
            VWBX_SpelerButton.Visibility = Visibility.Collapsed;
            VWBX_VerbergWoord.Visibility = Visibility.Visible;
            VWBX_InputBox.Visibility = Visibility.Visible;
            VWBX_ImageGalgje.Visibility = Visibility.Visible;
            NieuwSpelButton.Visibility = Visibility.Visible;

        }

        private void VerbergWoord_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            VerbergWoord.Background = Brushes.Black;
            VerbergWoord.Foreground = Brushes.Maroon;
            VerbergWoord.BorderBrush = Brushes.Red;
        }

        private void VerbergWoord_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
            VerbergWoord.Background = Brushes.Maroon;
            VerbergWoord.Foreground = Brushes.Black;
            VerbergWoord.BorderBrush = Brushes.Black;
        }
        private void VerbergWoord_MouseDown(object sender, MouseButtonEventArgs e)
        {
            VWBX_RaadButton.Visibility = Visibility.Visible;
            VWBX_VerbergWoord.Visibility = Visibility.Collapsed;
            VWBX_ImageGalgje.Visibility = Visibility.Collapsed;
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void NieuwSpelButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            NieuwSpelButton.Background = Brushes.Black;
            NieuwSpelButton.Foreground = Brushes.Maroon;
            NieuwSpelButton.BorderBrush = Brushes.Red;
        }

        private void NieuwSpelButton_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
            NieuwSpelButton.Background = Brushes.Maroon;
            NieuwSpelButton.Foreground = Brushes.Black;
            NieuwSpelButton.BorderBrush = Brushes.Black;
        }

        private void NieuwSpelButton_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        //methodes





    }
}

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

namespace PADKwiatyZadanie
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void greenone_Checked(object sender, RoutedEventArgs e)
        {
            if (greenone.IsChecked == true)
            {
                oneBox.Visibility = Visibility.Visible;
                progressBox.Value++;
            }
        }
        private void greenone_UnChecked(object sender, RoutedEventArgs e)
        {
            if (greenone.IsChecked == false)
            {
                oneBox.Visibility = Visibility.Hidden;
                progressBox.Value--;
            }
        }

        private void darkblueCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (darkblueCheckBox.IsChecked == true)
            {
                twoBox.Visibility = Visibility.Visible;
                progressBox.Value++;
            }
        }

        private void darkblueCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (darkblueCheckBox.IsChecked == false)
            {
                twoBox.Visibility = Visibility.Hidden;
                progressBox.Value--;
            }
        }

        private void brownCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (brownCheckBox.IsChecked == true)
            {
                threeBox.Visibility = Visibility.Visible;
                progressBox.Value++;
            }
        }

        private void brownCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (brownCheckBox.IsChecked == false)
            {
                threeBox.Visibility = Visibility.Hidden;
                progressBox.Value--;
            }
        }

        private void fourCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (fourCheckBox.IsChecked == true)
            {
                fourBox.Visibility = Visibility.Visible;
                progressBox.Value++;
            }
        }
        private void fourCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (fourCheckBox.IsChecked == false)
            {
                fourBox.Visibility = Visibility.Hidden;
                progressBox.Value--;
            }
        }

        private void fiveCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (fiveCheckBox.IsChecked == true)
            {
                fiveBox.Visibility = Visibility.Visible;
                progressBox.Value++;
            }
        }

        private void fiveCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (fiveCheckBox.IsChecked == false)
            {
                fiveBox.Visibility = Visibility.Hidden;
                progressBox.Value--;
            }
        }

        private void pinkCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (pinkCheckBox.IsChecked == true)
            {
                sixBox.Visibility = Visibility.Visible;
                progressBox.Value++;
            }
        }
        private void pinkCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (pinkCheckBox.IsChecked == false)
            {
                sixBox.Visibility = Visibility.Hidden;
                progressBox.Value--;
            }
        }
    }
}

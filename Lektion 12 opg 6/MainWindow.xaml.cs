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

namespace Lektion_12_opg_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MyButton.Content.Equals("Stor Grøn Tekst"))
            {
                MyButton.Content = "Det her er en knap";
            } else
            {
                MyButton.Content = "Stor Grøn Tekst";
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            if (e.RoutedEvent == CheckBox.CheckedEvent)
            {
                MyButton.Visibility = Visibility.Hidden;
            }
            else if (e.RoutedEvent == CheckBox.UncheckedEvent)
            {
                MyButton.Visibility = Visibility.Visible;
            }
        }
    }
}

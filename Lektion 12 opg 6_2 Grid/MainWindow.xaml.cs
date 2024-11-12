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

namespace Lektion_12_opg_6_2_Grid
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
            String upperLabel1 = (string)LabelUpperLeft.Content;
            String upperLabel2 = (string)LabelUpperRight.Content;
            String temp = upperLabel1;
            LabelUpperLeft.Content = upperLabel2;
            LabelUpperRight.Content = temp;
            Console.WriteLine(upperLabel1 + " " + upperLabel2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String lowerLabel1 = (string)LabelLowerLeft.Content;
            String lowerLabel2 = (string)LabelLowerRight.Content;
            String temp = lowerLabel1;
            LabelLowerLeft.Content = lowerLabel2;
            LabelLowerRight.Content = temp;
        }
    }
}

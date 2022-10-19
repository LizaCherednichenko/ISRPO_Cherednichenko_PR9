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

namespace ISRPO_Cherednichenko_PR9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            string a = Convert.ToString(Dany.Content);
            int index = a.IndexOf("OP");
            Itog.Content = Convert.ToString(index);
            string b = a.Substring(3, 5);
            Itog2.Content = b;
        }

        private void primer2_Click(object sender, RoutedEventArgs e)
        {
            Window window1 = new Window1();
            window1.Show();
        }

        private void indZ_Click(object sender, RoutedEventArgs e)
        {
            Window window2 = new Window2();
            window2.Show();
        }
    }
}

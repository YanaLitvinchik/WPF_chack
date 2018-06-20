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

namespace WpfApplication3
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

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ok");
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            box1.Text += "ku ku";
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            foreach (var item in stack.Children)
            {
                var tmp = (item as RadioButton);
                if (tmp.IsChecked == true && tmp != null)
                {
                    s = $"{tmp.Content.ToString()} -> {tmp.IsChecked}";
                    MessageBox.Show("check");
                }
            }
        }
    }
}

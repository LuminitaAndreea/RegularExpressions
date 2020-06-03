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
using System.Text.RegularExpressions;

namespace WpfApp3
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
        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {
            Regex reg = new Regex(text_Pattern.Text);
            bool result = reg.IsMatch(text_Text.Text);
            lbl_result.Text = result.ToString();
        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            Reference reference = new Reference();
            this.Visibility = Visibility.Hidden;
            reference.Show();

        }
    }
}

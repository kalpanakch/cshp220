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

namespace HelloWorld
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

        public string userName = "";
        public string password = "";


        private void UxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting password:" + uxPassword.Text);
        }

        private bool IsValidUserName()
        {
            return Regex.IsMatch(uxName.Text, @"^[a-zA-Z]+$");
        }
        private bool IsValidPassword()
        {
            return Regex.IsMatch(uxPassword.Text, @"^[a-zA-Z]+$");
        }


        private void UxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsValidUserName() && IsValidPassword())
            {
                uxSubmit.IsEnabled = true;
            }
            else
            {
                uxSubmit.IsEnabled = false;
            }

        }

        private void UxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (IsValidUserName() && IsValidPassword())
            {
                uxSubmit.IsEnabled = true;

            }
            else
            {
                uxSubmit.IsEnabled = false;
            }
        }


    }
}

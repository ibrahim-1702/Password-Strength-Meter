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
using PSM;

namespace PasswordStrength
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
        private void PasswordChangedHandler(object sender, RoutedEventArgs args)
        {
            PasswordStrMeter psm = new PasswordStrMeter();
            psm.Check(PasswordBox.Password);
            psm.StrengthSetter(PasswordBox.Password);
            UprCase.Content = psm.UpperCase;
            Lwrcase.Content = psm.LowerCase;
            SpCharD.Content = psm.SpChDigi;
            LenLB.Content = PasswordBox.Password.Length;
            StrengthLB.Content = (StengthOpt)psm.Strength;
            ShwPwdTB.Text = PasswordBox.Password;
        }
        public enum StengthOpt
        {
            VeryWeak = 2,
            Weak = 4,
            Average = 6,
            Strong = 8,
            VeryStrong = 10
        }

        

        private void ShwPwdCB_Checked_1(object sender, RoutedEventArgs e)
        {
            ShwPwdTB.Text = PasswordBox.Password;
            ShwPwdTB.Visibility = Visibility.Visible;
        }

        private void ShwPwdCB_Unchecked_1(object sender, RoutedEventArgs e)
        {
            ShwPwdTB.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PasswordBox.Password = "";
            ShwPwdTB.Text = "";
        }
    }
}

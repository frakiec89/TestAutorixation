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

namespace TestAutorixation.MyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnGo.Click += BtnGo_Click;
        }

        /// <summary>
        /// нажатие на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
           if ( string.IsNullOrEmpty(tbLogin.Text)
                || string.IsNullOrEmpty(tbPassword.Text))
            { MessageBox.Show("введите логин  и пароль"); return; }
                
           if (IAuthorization.IsLogIn(tbLogin.Text , tbPassword.Text) ==  true )
           {
                var user = IAuthorization.GetUser(tbLogin.Text, tbPassword.Text);
                MessageBox.Show( $"привет {user.Name }");

                //  продолжение 


           }
           else
            {
                MessageBox.Show("неверный логин  или пароль");
            }


        }
    }
}

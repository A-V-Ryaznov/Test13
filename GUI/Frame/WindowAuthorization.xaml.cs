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
using System.Windows.Shapes;

namespace LearnApp.GUI.Frame
{
    /// <summary>
    /// Логика взаимодействия для WindowAuthorization.xaml
    /// </summary>
    public partial class WindowAuthorization : Window
    {
        public WindowAuthorization()
        {
            InitializeComponent();
        }

        private void btnAuthorization_Click(object sender, RoutedEventArgs e)
        {
            if (Library.Verification.ValidateUserData(tbLogin.Text,pbPassword.Password))
            {
                LearnApp.GUI.Frame.WindowMain windowMain = new WindowMain();
                Library.PageManager.MainFrame.Navigate(new GUI.Pages.PageServices());
                windowMain.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Данные введены не корректно. Проверьте корректность данных и повторите попытку.","Внимание",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }  

        private void btnEntrance_Click(object sender, RoutedEventArgs e)
        {
            LearnApp.GUI.Frame.WindowMain windowMain = new WindowMain();
            windowMain.Show();
            this.Close();
        }
    }
}

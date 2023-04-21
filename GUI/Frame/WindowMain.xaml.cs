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
    /// Логика взаимодействия для WindowMain.xaml
    /// </summary>
    public partial class WindowMain : Window
    {
        public WindowMain()
        {
            InitializeComponent();
            //MainFrame.Navigate(new GUI.Pages.PageServices());
            Library.PageManager.MainFrame = MainFrame;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            LearnApp.GUI.Frame.WindowAuthorization windowAuthorization = new WindowAuthorization();
            windowAuthorization.Show();
            this.Close();
        }
    }
}

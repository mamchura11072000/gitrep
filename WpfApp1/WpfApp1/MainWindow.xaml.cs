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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var context = new leadmanageEntities();
            var user = context
                .User
                .Where(item => item.Login == TX1.Text && item.Password == TX2.Password)
                .FirstOrDefault();
            if (user != null)
            {
                var win = new Window1(user);
                Close();
                win.Show();
                return;
            }
            MessageBox.Show("Пользователь не найден!");
        }
    }
}
    
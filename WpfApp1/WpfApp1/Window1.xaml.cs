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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private MainWindowViewModel    mainWindow = new MainWindowViewModel();
        private leadmanageEntities _context;
        private readonly User _user;

        public Window1(User user)
        {
            InitializeComponent();

            _user = user;

            DataContext = mainWindow;

            _context = new leadmanageEntities();

            _context.Lead.ToList().Where(i => i.User.ID == _user.ID && i.IsActive == true).ToList().ForEach(item=> mainWindow.Leads.Add(item));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Leads.Clear();
            if ((bool)IsLead.IsChecked)
                _context.Lead.ToList().ForEach(item => mainWindow.Leads.Add(item));
            else
                _context.Lead.ToList().Where(i => i.User.ID == _user.ID).ToList().ForEach(item => mainWindow.Leads.Add(item));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var win = new AddWindow();
            win.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (mainWindow.Lead == null)
                return;

            if (mainWindow.Lead.IsActive == false)
            {
                MessageBox.Show("Нельзя удалить неактивного лида!");
                return;
            }

            _context.Lead.Remove(mainWindow.Lead);

            _context.SaveChanges();

            mainWindow.Leads.Remove(mainWindow.Lead);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}

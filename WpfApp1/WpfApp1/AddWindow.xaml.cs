using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private leadmanageEntities _context;

        private AddViewModel vm = new AddViewModel();

        public AddWindow()
        {
            InitializeComponent();

            DataContext = vm;

            _context = new leadmanageEntities();

            _context.User.ToList().ForEach(item => { vm.Users.Add(item); });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(vm.User.IsDeleted)
            {
                MessageBox.Show("Пользователь удален!!!");
                return;
            }

            var lead = new Lead {
                Phone = PhoneTxt.Text,
                SellTechniques = double.Parse(Skill.Text),
                CreateDateTime = DateTime.Now,
                UserID = vm.User.ID
            };

            _context.Lead.Add(lead);

            _context.SaveChanges();
        }
    }
}

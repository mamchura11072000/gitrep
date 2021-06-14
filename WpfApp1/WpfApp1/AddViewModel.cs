using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class AddViewModel
    {
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

        public User User { get; set; }
    }
}

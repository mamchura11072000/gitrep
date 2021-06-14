using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MainWindowViewModel
    {

        public ObservableCollection<Lead> Leads { get; set; } = new ObservableCollection<Lead>();

        public Lead Lead { get; set; }
    }
}

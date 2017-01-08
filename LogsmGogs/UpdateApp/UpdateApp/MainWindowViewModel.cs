using BindingHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace UpdateApp
{
    public class MainWindowViewModel
    { 
        public ICommand ButtonCommand
        {
            get { return new RelayCommand(ShowMessage); }
        }

        public void ShowMessage()
        {
            MessageBox.Show("Hello");
        }
    }
}

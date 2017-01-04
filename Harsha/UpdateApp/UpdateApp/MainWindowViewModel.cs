using BindingHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
            get{ return new RelayCommand(ShowMessage); }
        }

        public void ShowMessage()
        {
            MessageBox.Show("hello " + Name1);
        }

     

        private string _name;

        public string Name1
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

       
}

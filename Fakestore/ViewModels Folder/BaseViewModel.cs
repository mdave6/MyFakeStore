using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Fakestore.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnProperty(string propName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public static implicit operator BaseViewModel(AdminViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}

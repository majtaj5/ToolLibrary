using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolLibrary.MVVM.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (s, e) => { };
        protected void OnProperyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));

        }
    }
}

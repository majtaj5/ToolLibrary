using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolLibrary.Core
{
    class ObservableObject : INotifyPropertyChanged
{
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnProperyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}

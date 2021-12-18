using System.Windows;
using System.Windows.Input;
using ToolLibrary.Core;

namespace ToolLibrary.MVVM.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private ObservableObject _SelectedViewModel = new BorrowToolViewModel();




        public ObservableObject SelectedViewModel
        {
            get { return _SelectedViewModel; }
            set 
            { 
                _SelectedViewModel = value;
                OnProperyChanged(nameof(SelectedViewModel));

            }
        }

        bool loggIn = false;//todo logg in access
        private ICommand _updateViewCommand;

        public ICommand UpdateViewCommand => _updateViewCommand ??= new RelayCommand(SwitchViews);

        public void SwitchViews(object o)
        {
            switch (o.ToString())
            {
                case "Borrow tool":
                    {
                        SelectedViewModel = new BorrowToolViewModel();
                        break;
                    }
                case "Librarary management":
                    {
                        if (loggIn)//todo logg in access
                        {
                            SelectedViewModel = new LibraryManagementViewModel();
                        }
                        else if (loggIn == false)
                        {
                            MessageBoxResult result = MessageBox.Show("You don't have access to management library");
                        }
                        break;
                    }
            }
        }

    }
}
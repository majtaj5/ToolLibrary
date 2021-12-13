using System.Windows.Input;
using ToolLibrary.Core;

namespace ToolLibrary.MVVM.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private ObservableObject _SelectedViewModel = new LibraryManagementViewModel();




        public ObservableObject SelectedViewModel
        {
            get { return _SelectedViewModel; }
            set 
            { 
                _SelectedViewModel = value;
                OnProperyChanged(nameof(SelectedViewModel));

            }
        }


        private ICommand _updateViewCommand;

        public ICommand UpdateViewCommand => _updateViewCommand ?? (_updateViewCommand = new RelayCommand(SwitchViews));

        public void SwitchViews(object dupa)
        {
            switch (dupa.ToString())
            {
                case "Librarary management":
                    {
                        SelectedViewModel = new LibraryManagementViewModel();
                        break;
                    }
                case "Borrow tool":
                    {
                        SelectedViewModel = new BorrowToolViewModel();
                        break;
                    }
            }
        }

    }
}
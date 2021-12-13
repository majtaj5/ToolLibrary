using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToolLibrary.MVVM.ViewModels;

namespace ToolLibrary.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Librarary management")
            {
                viewModel.SelectedViewModel = new LibraryManagementViewModel();
            }
            else if(parameter.ToString()== "Borrow tool")
            {
                viewModel.SelectedViewModel = new BorrowToolViewModel();
            }

        }
    }
}

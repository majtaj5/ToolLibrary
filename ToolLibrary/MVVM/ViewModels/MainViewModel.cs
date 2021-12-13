﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToolLibrary.Commands;
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
        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {

            UpdateViewCommand = new UpdateViewCommand(this);
               
        }





    }
}
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MvvmDemoNet.ViewModel
{
    internal partial class MainViewModel:ObservableObject
    {
        public MainViewModel()
        {
            indexColor = 10;
        }
        [ObservableProperty]
        int indexColor;

        [RelayCommand]
        public void CloseWindow()
        {
            Application.Current.MainWindow.Close();            
        }
    }
}

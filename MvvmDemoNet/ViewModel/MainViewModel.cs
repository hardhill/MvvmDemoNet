using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}

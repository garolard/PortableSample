using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using PortableSample.ViewModels;

namespace PortableSample.UAP
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
        }

        private MainViewModel _main;
        public MainViewModel Main
        {
            get
            {
                if (_main == null)
                    _main = new MainViewModel(new SQLiteDataContextUAP());
                return _main;
            }
        }

    }
}

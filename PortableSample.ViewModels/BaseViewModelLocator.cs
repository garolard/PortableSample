using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using PortableSample.DataAccess;

namespace PortableSample.ViewModels
{
    public abstract class BaseViewModelLocator
    {
        public abstract ISqLiteDataContext DataContext { get; }

        public BaseViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);


            SimpleIoc.Default.Register<MainViewModel>(() =>
            {
                return new MainViewModel(DataContext);
            });
        }        

        public MainViewModel Main
        {
            get { return SimpleIoc.Default.GetInstance<MainViewModel>(); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using PortableSample.DataAccess;
using PortableSample.UAP;
using PortableSample.ViewModels;

namespace PortableSample.UAP
{
    public class UapViewModelLocator : BaseViewModelLocator
    {
        public override ISqLiteDataContext DataContext
        {
            get
            {
                return new SQLiteDataContextUAP();
            }
        }
    }
}

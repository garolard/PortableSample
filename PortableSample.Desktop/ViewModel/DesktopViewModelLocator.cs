/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:PortableSample.Desktop"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using System;
using PortableSample.DataAccess;
using PortableSample.Desktop;
using PortableSample.ViewModels;

namespace PortableSample.Desktop.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class DesktopViewModelLocator : BaseViewModelLocator
    {
        public override ISqLiteDataContext DataContext
        {
            get
            {
                return new SQLiteDataContextNet();
            }
        }
    }
}
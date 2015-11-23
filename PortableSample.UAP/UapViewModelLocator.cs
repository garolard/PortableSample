using PortableSample.DataAccess;
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

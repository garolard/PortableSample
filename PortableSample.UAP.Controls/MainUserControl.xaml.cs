#if WINDOWS_UWP
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
#else
using System.Windows.Controls;
#endif

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PortableSample.Shared.Controls
{
    public sealed partial class MainUserControl : UserControl
    {
        public MainUserControl()
        {
#if WINDOWS_UWP
            this.InitializeComponent();
#else
            InitializeComponent();
#endif
        }
    }
}

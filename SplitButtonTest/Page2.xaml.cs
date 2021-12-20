using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using SplitButtonClickEventArgs = Microsoft.UI.Xaml.Controls.SplitButtonClickEventArgs;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SplitButtonTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
        }

        private void SplitButton_Loaded(object sender, RoutedEventArgs e)
        {
            var b = sender as Microsoft.UI.Xaml.Controls.SplitButton;
            b.Focus(FocusState.Programmatic);
        }

        private void SplitButton_Click(Microsoft.UI.Xaml.Controls.SplitButton splitButton, SplitButtonClickEventArgs splitButtonClickEventArgs)
        {

        }
    }
}

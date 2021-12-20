using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SplitButtonTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {
        public Page1()
        {
            this.InitializeComponent();
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;
            b.Focus(FocusState.Programmatic);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}

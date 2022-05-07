using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace xamarin.Views
{
    /// <summary>
    /// Page to display on-boarding gradient with animation
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WelcomePage" /> class.
        /// </summary>
        public WelcomePage()
        {
            this.InitializeComponent();
        }
    }
}
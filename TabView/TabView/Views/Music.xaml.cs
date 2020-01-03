using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Music : ContentView
	{
		public Music ()
		{
			InitializeComponent ();
            for (int i = 0; i < 5; i++)
            {
                flex.Children.Add(new Frame());
            }
        }
	}
}
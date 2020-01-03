using System.Collections.Generic;
using TabView.Modal;
using TabView.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Account : ContentView
	{
        public Account ()
		{
			InitializeComponent ();
            
            BindingContext = new AccountViewModal();
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabView.Modal;
using TabView.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Setting : ContentView
	{
        
		public Setting ()
		{
			InitializeComponent ();
            
            BindingContext = new SettingViewModel();

        }
	}
}
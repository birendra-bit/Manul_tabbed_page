using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabView.Modal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabView.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserContactDetails : ContentView
	{
		public UserContactDetails ()
		{
			InitializeComponent ();
		}
        public UserContactDetails(UserAccount model )
        {
            populateUserDetails(model);
            
        }

        private void populateUserDetails(UserAccount model)
        {
            
        }
    }
}
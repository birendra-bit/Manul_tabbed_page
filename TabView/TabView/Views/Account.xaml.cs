using System.Collections.Generic;
using System.Diagnostics;
using TabView.Modal;
using TabView.ViewModel;
using TabView.Views;
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
        public static readonly BindableProperty EventNameProperty =
            BindableProperty.Create("EventName", typeof(string), typeof(Account), null);
        public string EventName
        {
            get { return (string)GetValue(EventNameProperty); }
            set { SetValue(EventNameProperty, value); }
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //UserAccount model = e.Item as UserAccount;
            //UserContactDetails user = new UserContactDetails();
            //user.BindingContext = model;
            //this.Content = new UserContactDetails();
        }
    }
}
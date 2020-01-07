using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace TabView.ViewModel
{
    class ClockViewModal : INotifyPropertyChanged
    {
        DateTime dateTime;
        public event PropertyChangedEventHandler PropertyChanged;

        public ClockViewModal()
        {
            this.dateTime = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                dateTime = DateTime.Now;
                return true;
            });
        }
        public DateTime DateTime {
            get {
                return dateTime;
            }
            set {
                if(dateTime != value)
                {
                    dateTime = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                }
            }
        }
    }
}

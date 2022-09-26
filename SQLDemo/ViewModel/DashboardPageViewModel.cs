using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SQLDemo.ViewModel
{
    public class DashboardPageViewModel : BaseViewModel
    {
        public DashboardPageViewModel()
        {
        }
        string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        public string _adddress;
        public string Adddress
        {
            get { return _adddress; }
            set { _adddress = value; OnPropertyChanged(nameof(Adddress)); }
        }

        public ICommand SaveCommand { get { return new Command(save); } }
        public void save()
        {

        }
    }
}

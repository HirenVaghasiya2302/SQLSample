using System;
using SQLDemo.Base;

namespace SQLDemo.ViewModel
{
    public class BaseViewModel : BaseNotify
	{
		//public ICommand BackCommand { get { return new Command(GoBack); } }
		//public async void GoBack()
		//{
		//	await App.Current.MainPage.Navigation.PopAsync();
		//}

		public virtual void OnFirstTimeAppearing() { }

		public virtual void OnAppearing() { }

		public virtual void OnDisappearing() { }
	}
}

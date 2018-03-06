using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinAzureApp.Service
{
    public class NavigationService
    {
        public void NavigateForward(Page p)
        {
            Application.Current.MainPage.Navigation.PushAsync(p as Page);
        }

        public void NavigateBack()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAzureApp.Model;
using XamarinAzureApp.ViewModel;

namespace XamarinAzureApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		public DetailPage (Ciudades ciudad)
		{
			InitializeComponent();
		    BindingContext = new DetailViewModel(ciudad);
        }
	}
}
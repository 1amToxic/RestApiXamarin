﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestApi.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		public DetailPage(string Name,string ImageUrl)
		{
			InitializeComponent();
			text.Text = Name;
			image.Source = ImageUrl;
		}
	}
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace navegacion.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactoPage : ContentPage
	{
		public ContactoPage ()
		{
			InitializeComponent ();
		}

        private void Detalle_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new DetallePage());
        }
    }
}
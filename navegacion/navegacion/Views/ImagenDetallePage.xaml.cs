using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using navegacion.Dto;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace navegacion.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagenDetallePage : ContentPage
	{
		public ImagenDetallePage (ImagenesProyecto Imagen)
		{
			InitializeComponent ();
            BindingContext= Imagen;
		}
	}
}
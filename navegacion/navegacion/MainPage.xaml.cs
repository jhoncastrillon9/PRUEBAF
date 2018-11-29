using navegacion.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace navegacion
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Proyectos_clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ContactoPage());
            IsPresented = false;
        }

        private void Acerca_c(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutPage());
            IsPresented = false;
        }

        private void Inicio_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
        }
        private void Salir_clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new LoginPage());
            IsPresented = false;
        }

    }
}

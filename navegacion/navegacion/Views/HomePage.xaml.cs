using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using navegacion.Dto;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace navegacion.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            CargarProyectos();
        }

        private void CargarProyectos()
        {
            HttpClient Cliente = new HttpClient();
            Cliente.BaseAddress = new Uri("http://grupodiamante.co/index.php/");
            var request = Cliente.GetAsync("ApiProyectos/Proyectos").Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;     
                var response = JsonConvert.DeserializeObject<List<Proyecto>>(responseJson);                

                ListProyectos.ItemsSource = response;
            }
        }

        private async void Item_Selecte(object sender, SelectedItemChangedEventArgs e)
        {
            var Proyecto = e.SelectedItem as Proyecto;
            await Navigation.PushAsync(new DetallePage(Proyecto));
        }
    }

}
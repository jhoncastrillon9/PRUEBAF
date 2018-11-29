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
	public partial class DetallePage : ContentPage
	{
		public DetallePage (Proyecto proyecto)
		{
			InitializeComponent ();
            //BindingContext = proyecto;

            //Aca se toma el id del proyecto se consultan las imagenes a mostrar 
            CargarImagenes(proyecto.Id);
        }

        private void CargarImagenes(string id)
        {
            HttpClient Cliente = new HttpClient();
            Cliente.BaseAddress = new Uri("http://grupodiamante.co/index.php/");
            var request = Cliente.GetAsync("ApiProyectos/ImagenesProyectos/" + id ).Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<ImagenesProyecto>>(responseJson);
                response.ToList();
                foreach (var item in response)
                {
                    item.UrlImagen = "http://grupodiamante.co/assets/uploads/Proyectos/Generales/" + item.UrlImagen;
                }

                ListImagenes.ItemsSource = response;
            }
        }

        private async void Item_Selecte(object sender, SelectedItemChangedEventArgs e)
        {
            var Imagen = e.SelectedItem as ImagenesProyecto;
            await Navigation.PushAsync(new ImagenDetallePage(Imagen));
        }
    }
}
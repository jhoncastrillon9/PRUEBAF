using navegacion.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using navegacion.Dto;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace navegacion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{

        public LoginPage ()
		{
			InitializeComponent ();
		}

        private async Task Ingresar_Clicked(object sender, EventArgs e)
        {
            string Email = EmailEntry.Text;
            string Password = PasswordEntry.Text;
            string Message = "";
            try
            {
                if (Email != null)
                {
                    if (Password != null)
                    {
                        if (Email == "1" && Password == "1")
                        {
                            await Navigation.PushAsync(new MainPage());
                        }
                        else
                        {                            
                            await DisplayAlert("Login", "Usuario o contraseña incorrecta", "Ok");
                        }                        
                    }
                    else
                    {                        
                        await DisplayAlert("Login", "La contraseña es requerido", "Ok");
                    }

                }
                else
                {                    
                    await DisplayAlert("Login", "El email es requerido", "Ok");
                }

            }
            catch (Exception ex)
            {                
                await App.Current.MainPage.DisplayAlert("Error de conexión", ex.Message, "Ok");
            }
        }
    }
}
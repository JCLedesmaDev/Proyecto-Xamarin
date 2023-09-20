using System;
using Xamarin.Forms;
using Newtonsoft.Json;
using Proyecto_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Proyecto_Xamarin;
using Proyecto_Xamarin.Controllers;

namespace Proyecto_Xamarin
{
    public partial class MainPage : ContentPage
    {
        private UserController userController = new UserController();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            Models.UserModel usuarioLogin = new Models.UserModel
            {
                _Email = txtEmail.Text,
                _Password = txtPassword.Text,
            };

            var data = userController.Login(usuarioLogin);

            if (data.StatusCode == 400)
            {

                await DisplayAlert("Ha ocurrido un error", $"{data.Value}", "OK");
                return;
            }
            await Navigation.PushAsync(new Home());
        } 
  
    }
}

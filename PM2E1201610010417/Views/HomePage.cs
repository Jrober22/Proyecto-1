﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PM2E1201610010417.Views
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            this.Title = "Selecciona una opcion";

            StackLayout stackLayout = new StackLayout();

            // Button Save
            Button button = new Button();
            button.Text = "Nueva casa";
            button.Clicked += Button_Añadir;
            stackLayout.Children.Add(button);

            //Button Get
            button = new Button();
            button.Text = "Casas Salvadas";
            button.Clicked += Button_Registros;
            stackLayout.Children.Add(button);

            Content = stackLayout;
        }

        private async void Button_Añadir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddSite());
        }

        private async void Button_Registros(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetSite());
        }
    }
}
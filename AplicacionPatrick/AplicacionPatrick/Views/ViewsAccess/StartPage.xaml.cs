using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplicacionPatrick.Views.ViewsAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

       /// <summary>
       /// Method for button to register user
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void RegisterNav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }


        /// <summary>
        /// Method for button  to login user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginNav_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}
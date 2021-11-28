using Android.App;
using Android.Content;
using Android.Content.PM;

using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionPatrick.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash", Label = "APATRICK", MainLauncher = true, NoHistory = true)]

    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            StartActivity(typeof(MainActivity));
        }
    }
}
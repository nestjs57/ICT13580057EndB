﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ICT13580057EndB.Droid
{
    [Activity(Label = "ICT13580057EndB", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            var dbpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            dbpath = System.IO.Path.Combine(dbpath, "myshop.db3");
            LoadApplication(new App(dbpath));
        }
    }
}


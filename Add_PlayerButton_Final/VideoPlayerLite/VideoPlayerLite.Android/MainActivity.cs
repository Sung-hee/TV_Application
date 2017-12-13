﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using VideoPlayerLite.Android.Port;

namespace VideoPlayerLite.Droid
{
    [Activity(Label = "VideoPlayerLite", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.DependencyService.Register<MediaContentPort>();
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}


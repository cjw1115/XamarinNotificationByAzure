﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Xaml;
using Com.Baidu.Android.Pushservice;
using Android.Content;
using CN.Jpush.Android.Api;

namespace NotificationDemo.Droid
{
    [Activity(Label = "NotificationDemo", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            //RegisterReceiver(new NotificationDemo.Droid.NotifyMessageReceiver(), new IntentFilter(""));
            PushManager.StartWork(ApplicationContext, PushConstants.LoginTypeApiKey, ConfigurationSettings.API_KEY);
            PushSettings.EnableDebugMode(ApplicationContext, true);
            //JPushInterface.SetDebugMode(true);
            //JPushInterface.Init(this);

            //var name = typeof(MainActivity).Assembly.ToString();

        }
    }
}


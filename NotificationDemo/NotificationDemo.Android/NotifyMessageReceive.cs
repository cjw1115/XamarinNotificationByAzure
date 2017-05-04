using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Baidu.Android.Pushservice;
using WindowsAzure.Messaging;
using System.Threading.Tasks;

namespace NotificationDemo.Droid
{
    public class ConfigurationSettings
    {
        public static readonly string API_KEY = "";
        public static readonly string HUB_NAME = "";
        public static readonly string HUB_CONNEXTION_STRING = "";
    }
    public class NotifyMessageReceiver : PushMessageReceiver
    {
        
        NotificationHub hub;
        public override void OnBind(Context p0, int p1, string p2, string p3, string p4, string p5)
        {
            System.Diagnostics.Debug.WriteLine($"OnBind {p1} {p2} {p3}");

            if (hub == null)
            {
                hub = new NotificationHub(ConfigurationSettings.HUB_NAME,ConfigurationSettings.HUB_CONNEXTION_STRING, p0);
            }
            Task.Run(() =>
            {
                hub.RegisterBaidu(p3, p4);
            });
        }

        public override void OnDelTags(Context p0, int p1, IList<string> p2, IList<string> p3, string p4)
        {
            System.Diagnostics.Debug.WriteLine("OnDelTags");
        }

        public override void OnListTags(Context p0, int p1, IList<string> p2, string p3)
        {
            System.Diagnostics.Debug.WriteLine("OnListTags");
        }

        public override void OnMessage(Context p0, string p1, string p2)
        {
            System.Diagnostics.Debug.WriteLine("OnMessage");
        }

        public override void OnNotificationArrived(Context p0, string p1, string p2, string p3)
        {
            System.Diagnostics.Debug.WriteLine("OnNotificationArrived");
        }

        public override void OnNotificationClicked(Context p0, string p1, string p2, string p3)
        {
            System.Diagnostics.Debug.WriteLine("OnNotificationClicked");
        }



        public override void OnSetTags(Context p0, int p1, IList<string> p2, IList<string> p3, string p4)
        {
            System.Diagnostics.Debug.WriteLine("OnSetTags");
        }

        public override void OnUnbind(Context p0, int p1, string p2)
        {
            System.Diagnostics.Debug.WriteLine("OnUnbind");
            hub.Unregister();
        }
    }
}
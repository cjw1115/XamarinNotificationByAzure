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
using CN.Jpush.Android.Service;

namespace NotificationDemo.Droid
{
    //[BroadcastReceiver]
    //[IntentFilter(new string[] { "cn.jpush.android.intent.REGISTRATION" }, Categories = new string[] { "com.cq.notificationdemo" })]
    //[IntentFilter(new string[] { "cn.jpush.android.intent.UNREGISTRATION" }, Categories = new string[] { "com.cq.notificationdemo" })]
    //[IntentFilter(new string[] { "cn.jpush.android.intent.MESSAGE_RECEIVED" }, Categories = new string[] { "com.cq.notificationdemo" })]
    //[IntentFilter(new string[] { "cn.jpush.android.intent.NOTIFICATION_RECEIVED" }, Categories = new string[] { "com.cq.notificationdemo" })]
    //[IntentFilter(new string[] { "cn.jpush.android.intent.NOTIFICATION_OPENED" }, Categories = new string[] { "com.cq.notificationdemo" })]
    //[IntentFilter(new string[] { "cn.jpush.android.intent.ACTION_RICHPUSH_CALLBACK" }, Categories = new string[] { "com.cq.notificationdemo" })]
    public class JPushReceiver : PushReceiver
    {
        public override void OnReceive(Context ctx, Intent ite)
        {
			//在这里处理各种消息类型
			base.OnReceive(ctx, ite);
        }
    }
}

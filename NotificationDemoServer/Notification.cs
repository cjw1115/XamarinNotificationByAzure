using Microsoft.Azure.NotificationHubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationDemoServer
{
    public class Notification
    {
        public static readonly string defaultFullSharedAccessSignatureSASConnectionString = "";//listen,send
        public static readonly string notificationHubName = "";

        public async void SendNotificationAsync(string title, string dsc)
        {
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString(defaultFullSharedAccessSignatureSASConnectionString, notificationHubName);
            string message = "{\"title\":\"" + title + "\",\"description\":\"" + dsc + "\"}";
            
            await hub.SendBaiduNativeNotificationAsync(message);

            string appleMsg = "{\"aps\":{\"alert\":\""+dsc+"\"}}";

            await hub.SendAppleNativeNotificationAsync(appleMsg);
            //string appleMsg = "";

            //await hub.SendWindowsNativeNotificationAsync();
        }

    }
}

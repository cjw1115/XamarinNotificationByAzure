using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationDemoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Notification notification = new Notification();
            while (true)
            {
                var title=Console.ReadLine();
                var dsc = Console.ReadLine();
                notification.SendNotificationAsync(title, dsc);
            }
        }
    }
}

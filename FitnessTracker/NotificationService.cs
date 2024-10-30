using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class NotificationService : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Notification: {message}");
        }
    }
}

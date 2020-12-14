using SmartCup.Observer.DeviceManager.UpdateMessage;
using SmartCup.Observer.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCup.Observer
{
    internal static class Program
    {
        private static void Main1(string[] args)
        {
            var room1 = Guid.NewGuid();
            var room2 = Guid.NewGuid();
            var cup1 = new CupDevice(room1);
            var cup2 = new CupDevice(room2);

            var deviceManager = new DeviceManager.DeviceManager();
            deviceManager.AddObserver(cup1);
            deviceManager.AddObserver(cup2);

            deviceManager.NotifyObservers(new UsedModeMessage(room1));

            Console.WriteLine($"Room: {cup1.RoomID}\n" +
                              $"Is Cup1`s mode is used: {cup1.IsUsed}\n");
            Console.WriteLine($"Room: {cup2.RoomID}\n" +
                              $"Is Cup2`s mode is used:: {cup2.IsUsed}\n");
        }
    }
}

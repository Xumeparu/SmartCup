using SmartCup.Observer.DeviceManager.UpdateMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCup.Observer.DeviceManager
{
    public class DeviceManager : IObservable
    {
        private readonly List<ICupObserver> observers;

        public DeviceManager()
        {
            observers = new List<ICupObserver>();
        }

        public void AddObserver(ICupObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(ICupObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers(DeviceMessage info)
        {
            switch(info)
            {
                case UsedModeMessage usedModeMessage:
                    foreach (var observer in observers)
                    {
                        observer.UsedMode(usedModeMessage);
                    }
                    break;
                default:
                    throw new ArgumentException($"Unknown message type: {info.GetType().Name}");
            }
        }
    }
}

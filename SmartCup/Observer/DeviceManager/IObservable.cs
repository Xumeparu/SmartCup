using SmartCup.Observer.DeviceManager.UpdateMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCup.Observer.DeviceManager
{
    public interface IObservable
    {
        void AddObserver(ICupObserver cupObserver);
        void RemoveObserver(ICupObserver cupObserver);
        void NotifyObservers(DeviceMessage type);
    }
}

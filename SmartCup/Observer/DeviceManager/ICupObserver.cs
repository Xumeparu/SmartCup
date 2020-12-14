using SmartCup.Observer.DeviceManager.UpdateMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCup.Observer.DeviceManager
{
    public interface ICupObserver : IDevice
    {
        void UsedMode(UsedModeMessage usedModeMessage);
    }
}

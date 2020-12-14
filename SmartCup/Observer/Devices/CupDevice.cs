using SmartCup.Observer.DeviceManager;
using SmartCup.Observer.DeviceManager.UpdateMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCup.Observer.Devices
{
    public class CupDevice : ICupObserver
    {
        public bool IsUsed { get; private set; } = false;

        public Guid RoomID { get; }

        public CupDevice(Guid roomID)
        {
            RoomID = roomID;
        }

        private void CupUsed()
        {
            IsUsed = !IsUsed;
        }

        public void UsedMode(UsedModeMessage usedModeMessage)
        {
            if (!usedModeMessage.RoomID.Equals(RoomID))
            {
                return;
            }
            CupUsed();
        }
    }
}

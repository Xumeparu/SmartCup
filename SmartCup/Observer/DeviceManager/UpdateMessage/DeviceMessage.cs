using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCup.Observer.DeviceManager.UpdateMessage
{
    public abstract class DeviceMessage
    {
        protected DeviceMessage(Guid roomID)
        {
            RoomID = roomID;
        }

        public Guid RoomID { get; }
    }
}

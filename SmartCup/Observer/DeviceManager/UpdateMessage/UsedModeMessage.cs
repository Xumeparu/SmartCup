using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCup.Observer.DeviceManager.UpdateMessage
{
    public class UsedModeMessage : DeviceMessage
    {
        public UsedModeMessage(Guid roomID) : base(roomID)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCup.Observer
{
    public class CupInfo
    {
        private int cupID;
        private int cupStatus;

        internal CupInfo(int cupID, int cupStatus)
        {
            this.cupID = cupID;
            this.cupStatus = cupStatus;
        }

        public int CupID
        {
            get { return this.cupID; }
        }

        public int CupStatus
        {
            get { return this.cupStatus; }
        }
    }
}

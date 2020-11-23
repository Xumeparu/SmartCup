using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCup.Observer
{
    public class Monitor : IObserver<CupInfo>
    {
        private string name;
        private List<string> cupInfos = new List<string>();
        private IDisposable cancellation;
        private string fmt = "{0,-20} {1,5}  {2, 3}";

        public Monitor(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("The observer must be assigned a name.");
            }

            this.name = name;
        }

        public virtual void Subscribe(CupHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
            cupInfos.Clear();
        }

        public virtual void OnCompleted()
        {
            cupInfos.Clear();
        }

        public virtual void OnError(Exception e)
        {
        }

        public virtual void OnNext(CupInfo info)
        {
            bool updated = false;

            if (info.CupStatus == 0)
            {
                var cupsToRemove = new List<string>();
                string cupID = String.Format("{0,5}", info.CupID);

                foreach (var cupInfo in cupInfos)
                {
                    if (cupInfo.Substring(21, 5).Equals(cupID))
                    {
                        cupsToRemove.Add(cupInfo);
                        updated = true;
                    }
                }

                foreach (var cupToRemove in cupsToRemove)
                {
                    cupInfos.Remove(cupToRemove);
                }

                cupsToRemove.Clear();
            }
            else
            {
                string upInfo = String.Format(fmt, info.CupID, info.CupStatus);

                if (!cupInfos.Contains(upInfo))
                {
                    cupInfos.Add(upInfo);
                    updated = true;
                }
            }

            if (updated)
            {
                cupInfos.Sort();

                Console.WriteLine("Information from {0}", this.name);

                foreach (var cupInfo in cupInfos)
                {
                    Console.WriteLine(cupInfo);
                }

                Console.WriteLine();
            }
        }
    }
}

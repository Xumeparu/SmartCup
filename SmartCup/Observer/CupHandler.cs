using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCup.Observer
{
    public class CupHandler : IObservable<CupInfo>
    {
        private List<IObserver<CupInfo>> observers;
        private List<CupInfo> cups;

        public CupHandler()
        {
            observers = new List<IObserver<CupInfo>>();
            cups = new List<CupInfo>();
        }

        public IDisposable Subscribe(IObserver<CupInfo> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);

                foreach(var item in cups)
                {
                    observer.OnNext(item);
                }
            }

            return new Unsubscriber<CupInfo>(observers, observer);
        }

        public void CupStatus(int cupID)
        {
            CupStatus(cupID, 0);
        }

        public void CupStatus(int cupID, int cupStatus)
        {
            var info = new CupInfo(cupID, cupStatus);
            
            if (cupStatus > 0 && !cups.Contains(info))
            {
                cups.Add(info);

                foreach (var observer in observers)
                {
                    observer.OnNext(info);
                }
            }
            else if (cupStatus == 0)
            {
                var cupsToRemove = new List<CupInfo>();
                foreach (var cup in cups)
                {
                    if (info.CupID == cup.CupID)
                    {
                        cupsToRemove.Add(cup);
                        foreach (var observer in observers)
                            observer.OnNext(info);
                    }
                }
                foreach (var cupToRemove in cupsToRemove)
                    cups.Remove(cupToRemove);

                cupsToRemove.Clear();
            }
        }

        public void LastCupClaimed()
        {
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }

            observers.Clear();
        }
    }
}

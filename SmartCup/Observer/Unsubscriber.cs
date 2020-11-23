using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCup.Observer
{
    internal class Unsubscriber<CupInfo> : IDisposable
    {
        private List<IObserver<CupInfo>> _observers;
        private IObserver<CupInfo> _observer;

        internal Unsubscriber(List<IObserver<CupInfo>> observers, IObserver<CupInfo> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if(_observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TheBestMVVMFrameworkInTown.Events
{
    public class EventAggregator<TEvent>
      where TEvent : EventArgs
    {
        public static EventAggregator<TEvent> s_eventAggregator;

        public static EventAggregator<TEvent> Instance =>
          s_eventAggregator ??
            (s_eventAggregator = new EventAggregator<TEvent>());

        private EventAggregator() { }
        public event Action<object, TEvent> Event;
        public void Publish(object source, TEvent ev)
        {
            Event?.Invoke(source, ev);
        }
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtc.plain.net.api.repository.client.util
{
    public class EventSource : IEventSource
    {
        private EventSource eventSource;

        public EventSource(EventSource eventSource)
        {
            this.eventSource = eventSource;
        }

        public void addTypedListener(Object category, Object listener)
        {
            throw new NotImplementedException();
        }

        public static explicit operator EventSource(ITeamRepositoryService v)
        {
            throw new NotImplementedException();
        }

        public void removeTypedListener(Object category, Object listener)
        {
            throw new NotImplementedException();
        }

        public void purgeTypedListener(Object listener)
        {
            throw new NotImplementedException();
        }

        public void queueEvent(Object events)
        {
            throw new NotImplementedException();
        }

        public void acquire()
        {
            //publicLock.lock();
            throw new NotImplementedException();
        }

        public override void addGenericListener(object paramObject, IListener paramIListener)
        {
            throw new NotImplementedException();
        }

        public override void removeGenericListener(object paramObject, IListener paramIListener)
        {
            throw new NotImplementedException();
        }

        public override void purgeGenericListener(IListener paramIListener)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rtc.plain.net.api.repository.client.util
{
    public abstract class IEventSource
    {
        public abstract void addGenericListener(Object paramObject, IListener paramIListener);

        public abstract void removeGenericListener(Object paramObject, IListener paramIListener);

        public abstract void purgeGenericListener(IListener paramIListener);
    }
}

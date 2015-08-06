using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rtc.plain.net.api.repository.client.util
{
    public interface IEvent
    {
        IEventSource getEventSource();

        String getEventType();

        List<Object> getCategories();
    }
}

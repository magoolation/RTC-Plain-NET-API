using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rtc.plain.net.api.repository.client.util;
using rtc.plain.net.api.links.common;

namespace rtc.plain.net.api.links.client
{
    public abstract class ILinkEvent : IEvent
    {

        public const String LINK_SAVED_EVENT_TYPE = "com.ibm.team.links.LinkSaveEvent";
        public const String LINK_DELETED_EVENT_TYPE = "com.ibm.team.links.LinkDeletedEvent";

        public abstract ILink getLink();

        public abstract IEventSource getEventSource();

        public abstract string getEventType();

        public abstract List<object> getCategories();
    }
}

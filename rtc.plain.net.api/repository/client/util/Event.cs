using System;
using System.Collections.Generic;

namespace rtc.plain.net.api.repository.client.util
{
    public class Event : IEvent
    {
        private static readonly long serialVersionUID = 1L;
        private readonly string eventType;
        private List<Object> categories = null;

        public Event(IEventSource eventSource, string eventType) /* : base(eventSource)*/
        {

            if (eventSource == null)
            {
                throw new System.ArgumentException();
            }
            if (eventType == null)
            {
                throw new System.ArgumentException();
            }
            this.eventType = eventType;
        }

        public IEventSource getEventSource()
        {
            return (IEventSource)getSource();
        }

        private IEventSource getSource()
        {
            throw new NotImplementedException();
        }

        public string getEventType()
        {
            return eventType;
        }

        List<Object> getCategories()
        {
            if (categories == null)
            {
                List<Object> tempCategories = computeCategories();
                lock (this)
                {
                    if (categories == null)
                    {
                        categories = tempCategories;
                    }
                }
            }

            return categories;
        }

        private List<Object> computeCategories()
        {
            List<object> result = new List<object>(1);
            addCategories(result);
            result.Add(getEventType());

            for (IEnumerator<object> it = result.GetEnumerator(); it.MoveNext();)
            {
                object element = it.Current;
                if (element == null)
                {
                    throw new InvalidOperationException(
                            "event categories must not be null");
                }
            }
            return result;
        }

        protected void addCategories(List<object> categoryList)
        {
            if (categoryList == null)
            {
                throw new System.ArgumentException();
            }
        }

        List<object> IEvent.getCategories()
        {
            throw new NotImplementedException();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rtc.plain.net.api.repository.client.util
{
    public interface IListener
    {
        void handleEvents(List<Object> paramList);
    }
}

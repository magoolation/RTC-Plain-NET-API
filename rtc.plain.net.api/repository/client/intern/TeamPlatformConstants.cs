using System;
using System.Collections.Concurrent;
using System.Threading;

namespace rtc.plain.net.api.repository.client.intern
{
    public class TeamPlatformConstants
    {
        public static readonly string BUNDLE_ID = "com.ibm.team.repository.client";
        private static Object EVENT_SOURCE_TPE = null;

        public static void initializeEventSourceTPE()
        {
            throw new NotImplementedException(typeof(TeamPlatformConstants).ToString());
        }

        public static void shutDownEventSourceTPE()
        {
            throw new NotImplementedException(typeof(TeamPlatformConstants).ToString());
        }

        public static Object getEventSourceTPE()
        {
            return null;
        }
    }
}
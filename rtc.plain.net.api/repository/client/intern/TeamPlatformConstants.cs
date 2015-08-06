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
            // No OSGi impl for now
        }

        public static void shutDownEventSourceTPE()
        {
            // No OSGi impl for now
        }

        public static Object getEventSourceTPE()
        {
            return null;
        }
    }
}
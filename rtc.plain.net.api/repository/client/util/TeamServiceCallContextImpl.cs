using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace rtc.plain.net.api.repository.client.util
{
    internal class TeamServiceCallContextImpl
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static ThreadLocal<Stack<TeamServiceCallContextImpl>> contextStacks = new ThreadLocal<Stack<TeamServiceCallContextImpl>>();

        //private static Dictionary<Thread, SocketChannel> connectingSockets = new Dictionary<Thread, SocketChannel>();

        //private HttpMethod httpMethod;

        private static bool logNonCancelableServiceCalls = false;

        internal static void setLogNonCancelableServiceCalls(bool logNonCancelableServiceCalls)
        {
            TeamServiceCallContextImpl.logNonCancelableServiceCalls = logNonCancelableServiceCalls;
        }
    }
}
/* Location:           C:\RTC40Dev\installs\PlainJavaAPI\com.ibm.team.repository.common_1.3.3000.v20131022_0156.jar
 * Qualified Name:     com.ibm.team.repository.common.transport.TeamServiceCallContextImpl
 * Java Class Version: 6 (50.0)
 * JD-Core Version:    0.7.1
 */

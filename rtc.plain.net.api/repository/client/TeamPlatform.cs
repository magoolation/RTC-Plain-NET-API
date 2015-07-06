using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using rtc.plain.net.api.repository.client.intern;
using rtc.plain.net.api.repository.client.util;

namespace rtc.plain.net.api.repository.client
{
    public sealed class TeamPlatform
    {
        public const String PI_REPOSITORY = "com.ibm.team.repository";
        private static ITeamRepositoryService repositoryService;

        public static void startup()
        {
            InternalTeamPlatform.getDefault().start(false);
            TeamPlatformConstants.initializeEventSourceTPE();
        }

        public static void shutdown()
        {
            InternalTeamPlatform.getDefault().shutdown();
            TeamPlatformConstants.shutDownEventSourceTPE();
        }

        public static bool isStarted()
        {
            return InternalTeamPlatform.getDefault().isStarted();
        }

        public static void setMaxContentThreads(int count)
        {
            ContentManager.setMaxSimultaneousDownloads(count);
        }

        public static int getMaxContentThreads()
        {
            return ContentManager.getMaxSimultaneousDownloads();
        }

        public static ITeamRepositoryService getTeamRepositoryService()
        {
            lock (repositoryService)
            {
                if (!InternalTeamPlatform.getDefault().isStarted())
                {
                    throw new InvalidOperationException("Platform hasn't been started yet");
                }
                if (repositoryService == null)
                {
                    repositoryService = new TeamRepositoryService();
                }
                return repositoryService;
            }
        }
    }
}


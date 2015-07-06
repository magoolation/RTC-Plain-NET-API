using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rtc.plain.net.api.extras;
using rtc.plain.net.api.repository.client.util;
using rtc.plain.net.api.repository.common;

namespace rtc.plain.net.api.repository.client
{
    public abstract class ITeamRepositoryService : IEventSource
    {
        public const String REPOSITORIES = "repositories";
        public const int DEFAULT = 0;
        public const int UNSHARED = 1;
        public const int MANUAL_LOGIN_HANDLERS = 2;
        public const int EXISTING_SHARED = 4;

        public abstract ITeamRepository getTeamRepository(String paramString, int paramInt);

        public abstract ITeamRepository getTeamRepository(String paramString);

        public abstract ITeamRepository getUnmanagedRepository(String paramString);

        public abstract ITeamRepository getTeamRepository(String paramString, IProgressMonitor paramIProgressMonitor); //    throws TeamRepositoryException;

        public abstract ITeamRepository getTeamRepository(String paramString, int paramInt, IProgressMonitor paramIProgressMonitor); //    throws TeamRepositoryException;

        public abstract ITeamRepository getTeamRepositoryWithOverride(String paramString, IProgressMonitor paramIProgressMonitor); //    throws TeamRepositoryException;

        public abstract ITeamRepository getApplicationTeamRepository(String paramString, int paramInt, IProgressMonitor paramIProgressMonitor); //    throws TeamRepositoryException;

        public abstract void addTeamRepository(ITeamRepository paramITeamRepository);

        public abstract void removeTeamRepository(ITeamRepository paramITeamRepository);

        [Obsolete("Not used anymore", true)]
        public abstract void removeRepository(ITeamRepository paramITeamRepository);

        public abstract ITeamRepository[] getTeamRepositories();

        public abstract int getDefaultConnectionTimeout();

        public abstract void addRepositoryServiceListener(IRepositoryServiceListener paramIRepositoryServiceListener);

        public abstract void removeRepositoryServiceListener(IRepositoryServiceListener paramIRepositoryServiceListener);

        public abstract ITeamRepository getTeamRepository(UUID paramUUID);

    }

    public interface IRepositoryServiceListener
    {

        void addedRepository(ITeamRepository paramITeamRepository);


        void removedRepository(ITeamRepository paramITeamRepository);
    }
}

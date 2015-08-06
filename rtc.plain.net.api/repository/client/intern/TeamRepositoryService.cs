using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace rtc.plain.net.api.repository.client.intern
{
    class TeamRepositoryService : ITeamRepositoryService
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private bool allowJtsLogin;

        public override ITeamRepository getTeamRepository(string repositoryURI, int flags)
        {
            if (repositoryURI == null)
            {
                throw new ArgumentException();
            }

            if ((flags & 0x1) != 0)
            {
                bool autoLoginHandler = (flags & 0x2) == 0;

                ITeamRepository teamRepository = new TeamRepository(repositoryURI, autoLoginHandler);

                if (!allowJtsLogin)
                    teamRepository.setMayLogIntoJts(false);

                return teamRepository;
            }

            try
            {
                acquire();
                cleanOrphans();

                ITeamRepository repository = getSharedTeamRepository(repositoryURI, allowJtsLogin);

                if (repository == null)
                {
                    if ((flags & 0x4) == 0)
                    {
                        repository = createSharedTeamRepository(repositoryURI, flags);
                    }
                }
                else
                {
                    shareTeamRepository(repository);
                }

                return repository;
            }
            finally
            {
                release();
            }
        }

        private void shareTeamRepository(ITeamRepository repository)
        {
            throw new NotImplementedException();
        }

        private ITeamRepository createSharedTeamRepository(string repositoryURI, int flags)
        {
            throw new NotImplementedException();
        }

        private ITeamRepository getSharedTeamRepository(string repositoryURI, bool allowJtsLogin)
        {
            throw new NotImplementedException();
        }

        private void cleanOrphans()
        {
            throw new NotImplementedException();
        }

        private void release()
        {
            throw new NotImplementedException();
        }

        private void acquire()
        {
            throw new NotImplementedException();
        }

        public override ITeamRepository getTeamRepository(string repositoryURI)
        {
            return getTeamRepository(repositoryURI, 0);
        }

        public override ITeamRepository getUnmanagedRepository(string repositoryURI)
        {
            return getTeamRepository(repositoryURI, 3);
        }

        public override ITeamRepository getTeamRepository(string paramString, extras.IProgressMonitor paramIProgressMonitor)
        {
            throw new NotImplementedException();
        }

        public override ITeamRepository getTeamRepository(string paramString, int paramInt, extras.IProgressMonitor paramIProgressMonitor)
        {
            throw new NotImplementedException();
        }

        public override ITeamRepository getTeamRepositoryWithOverride(string paramString, extras.IProgressMonitor paramIProgressMonitor)
        {
            throw new NotImplementedException();
        }

        public override ITeamRepository getApplicationTeamRepository(string paramString, int paramInt, extras.IProgressMonitor paramIProgressMonitor)
        {
            throw new NotImplementedException();
        }

        public override void addTeamRepository(ITeamRepository paramITeamRepository)
        {
            throw new NotImplementedException();
        }

        public override void removeTeamRepository(ITeamRepository paramITeamRepository)
        {
            throw new NotImplementedException();
        }

        public override void removeRepository(ITeamRepository paramITeamRepository)
        {
            throw new NotImplementedException();
        }

        public override ITeamRepository[] getTeamRepositories()
        {
            throw new NotImplementedException();
        }

        public override int getDefaultConnectionTimeout()
        {
            throw new NotImplementedException();
        }

        public override void addRepositoryServiceListener(IRepositoryServiceListener paramIRepositoryServiceListener)
        {
            throw new NotImplementedException();
        }

        public override void removeRepositoryServiceListener(IRepositoryServiceListener paramIRepositoryServiceListener)
        {
            throw new NotImplementedException();
        }

        public override ITeamRepository getTeamRepository(common.UUID paramUUID)
        {
            throw new NotImplementedException();
        }

        public override void addGenericListener(object paramObject, util.IListener paramIListener)
        {
            throw new NotImplementedException();
        }

        public override void removeGenericListener(object paramObject, util.IListener paramIListener)
        {
            throw new NotImplementedException();
        }

        public override void purgeGenericListener(util.IListener paramIListener)
        {
            throw new NotImplementedException();
        }
    }
}

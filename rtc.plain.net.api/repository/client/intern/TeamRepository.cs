using System;
using rtc.plain.net.api.repository.client.util;
using System.Collections.Generic;

namespace rtc.plain.net.api.repository.client.intern
{
    internal class TeamRepository : EventSource, ITeamRepository
    {
        private bool autoLoginHandler;
        private string repositoryURI;
        private ITeamServer teamServer;
        private String localRepositoryURI;
        private readonly HashSet<string> aliasRepositoryURIs = new HashSet<string>();

        public TeamRepository(string repositoryURI, bool autoLoginHandler) : base((EventSource)TeamPlatform.getTeamRepositoryService())
        {
            this.repositoryURI = repositoryURI;

            teamServer = TeamServerFactory.INSTANCE.newTeamServerFromURL(repositoryURI, getCertificateHandler());

            if (teamServer == null)
            {
                throw new ArgumentException("The server address is not valid.");
            }

            initialize(repositoryURI);

            teamServer.setCredentials("", "");
        }

        private object getCertificateHandler()
        {
            throw new NotImplementedException();
        }

        private void initialize(string repositoryURI)
        {
            if (repositoryURI.StartsWith("local:/"))
            {
                localRepositoryURI = repositoryURI;
            }
            else
            {
                localRepositoryURI = null;
            }

            aliasRepositoryURIs.Add(repositoryURI);

            if (repositoryURI.EndsWith("/"))
            {
                aliasRepositoryURIs.Add(repositoryURI.Substring(0, repositoryURI.Length - 1));
            }
            else
            {
                aliasRepositoryURIs.Add(repositoryURI + '/');
            }

            String actualRepositoryURI = teamServer.getRepositoryURL();

            aliasRepositoryURIs.Add(actualRepositoryURI);

            if (actualRepositoryURI.EndsWith("/"))
            {
                aliasRepositoryURIs.Add(actualRepositoryURI.Substring(0, actualRepositoryURI.Length - 1));
            }
            else
            {
                aliasRepositoryURIs.Add(actualRepositoryURI + '/');
            }
        }

        public void registerLoginHandler(LoginHandler loginHandler)
        {
            throw new NotImplementedException();
        }

        public void login(object monitor)
        {
            throw new NotImplementedException();
        }

        public void setMayLogIntoJts(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
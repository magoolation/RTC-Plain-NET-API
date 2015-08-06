using System;

namespace rtc.plain.net.api.repository.client.intern
{
    internal class TeamServerFactory
    {
        internal static readonly TeamServerFactory INSTANCE = new TeamServerFactory();

        internal ITeamServer newTeamServerFromURL(string repositoryURI, object p)
        {
            throw new NotImplementedException();
        }
    }
}
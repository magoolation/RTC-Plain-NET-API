namespace rtc.plain.net.api.repository.client.intern
{
    internal interface ITeamServer
    {
        string getRepositoryURL();
        void setCredentials(string v1, string v2);
    }
}
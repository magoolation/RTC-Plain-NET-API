namespace rtc.plain.net.api.repository.client
{
    public class LoginHandler
    {
        private string password;
        private string userId;

        public LoginHandler(string userId, string password)
        {
            this.userId = userId;
            this.password = password;
        }
    }
}
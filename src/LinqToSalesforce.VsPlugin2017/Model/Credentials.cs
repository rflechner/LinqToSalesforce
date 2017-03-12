namespace LinqToSalesforce.VsPlugin2017.Model
{
    public class Credentials
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SecurityToken { get; set; }
        public string Instance { get; set; }

        public static Credentials From(Rest.OAuth.ImpersonationParam auth)
        {
            return new Credentials
            {
                Password = auth.Password,
                ClientSecret = auth.ClientSecret,
                Username = auth.Username,
                SecurityToken = auth.SecurityToken,
                ClientId = auth.ClientId
            };
        }

        public Rest.OAuth.ImpersonationParam ToImpersonationParam()
        {
            return new Rest.OAuth.ImpersonationParam
            {
                ClientId = ClientId,
                ClientSecret = ClientSecret,
                Username = Username,
                Password = Password,
                SecurityToken = SecurityToken
            };
        }
    }
}
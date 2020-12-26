namespace Fluffy.Models
{
    public class AccessToken
    {
        public ExpiringToken Token { get; }
        public bool Revoked { get; }
        public Identity Identity { get; set; }
    }
}
namespace Fluffy.Models
{
    public class RefreshToken
    {
        public ExpiringToken Token { get; }
        public bool Revoked { get; }
        public Identity Identity { get; set; }
    }
}
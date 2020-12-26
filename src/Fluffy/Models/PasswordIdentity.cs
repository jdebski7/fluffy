using System;

namespace Fluffy.Models
{
    public class PasswordIdentity
    {
        public string Identifier { get; set; }
        public string PasswordHash { get; set; }
        public DateTime PasswordValidTo { get; set; }
        public ExpiringToken ResetPasswordToken { get; set; }
        public Identity Identity { get; set; }
    }
}
using System;

namespace Fluffy
{
    public class ExpiringToken
    {
        public string Token { get; }
        public DateTime ValidTo { get; }

        public ExpiringToken(string token, DateTime validTo)
        {
            Token = token;
            ValidTo = validTo;
        }
    }
}
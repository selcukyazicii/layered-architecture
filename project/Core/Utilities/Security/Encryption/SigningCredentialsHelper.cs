using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        //sisteme girmek için elimizde olanlar,hangi algoritma ve anahtarı kullanacağını yaz.
        //public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        //{
        //    return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);
        //}
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
        }
    }
}

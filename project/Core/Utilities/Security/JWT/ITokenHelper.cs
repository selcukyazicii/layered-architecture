using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //kullanıcı id ve password girilip submitleyince burası çalışacak
        //eğer id/pass doğruysa db gidip kullanıcının claimlerini bulacak
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);   
    }
}

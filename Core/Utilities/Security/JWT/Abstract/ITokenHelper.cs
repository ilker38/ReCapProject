using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Security.JWT.Concrete;

namespace Core.Utilities.Security.JWT.Abstract
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}

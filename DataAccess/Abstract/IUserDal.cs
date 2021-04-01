using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Core.Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}

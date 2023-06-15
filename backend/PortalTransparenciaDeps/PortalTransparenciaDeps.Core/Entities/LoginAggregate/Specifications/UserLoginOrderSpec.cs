using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Entities.LoginAggregate.Specifications
{
    public class UserLoginOrderSpec : Specification<UserLogin>
    {
        public UserLoginOrderSpec() 
        {
            Query.AsNoTracking().OrderBy(user => user.Id);
        }
    }
}

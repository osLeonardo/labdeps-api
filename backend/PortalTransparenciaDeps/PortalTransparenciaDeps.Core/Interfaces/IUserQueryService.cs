using PortalTransparenciaDeps.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalTransparenciaDeps.Core.Interfaces
{
    public interface IUserQueryService
    {
        List<UserDto> ListUser();
        UserDto GetUser(int id);
    }
}

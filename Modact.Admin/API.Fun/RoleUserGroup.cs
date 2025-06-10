using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class RoleUserGroup : ApiClassRelationalTableDao<DTO_modr_role_usergroup>
    {
        public RoleUserGroup(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class RolePermission : ApiClassRelationalTableDao<DTO_modr_role_permission>
    {
        public RolePermission(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

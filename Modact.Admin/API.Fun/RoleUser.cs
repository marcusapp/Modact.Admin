using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class RoleUser : ApiClassRelationalTableDao<DTO_modr_role_user>
    {
        public RoleUser(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

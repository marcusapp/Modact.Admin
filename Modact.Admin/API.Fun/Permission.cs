using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class Permission : ApiClassMasterTableDao<DTO_modm_permission>
    {
        public Permission(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

        public List<string> GetCurrentUserPermission()
        {
            return ApiFunctionAccessory.UserPermission.Permissions;
        }
    }
}

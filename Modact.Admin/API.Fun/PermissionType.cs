using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class PermissionType : ApiClassMasterTableDao<DTO_modm_permissiontype>
    {
        public PermissionType(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }
    }
}

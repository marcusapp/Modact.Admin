using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class Role : ApiClassMasterTableDao<DTO_modm_role>
    {
        public Role(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

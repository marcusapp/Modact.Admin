using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class AppNode : ApiClassMasterTableDao<DTO_modm_appnode>
    {
        public AppNode(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }
    }
}

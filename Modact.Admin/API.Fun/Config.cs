using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class Config : ApiClassMasterTableDao<DTO_modm_config>
    {
        public Config(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

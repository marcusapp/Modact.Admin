using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class ConfigType : ApiClassMasterTableDao<DTO_modm_configtype>
    {
        public ConfigType(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

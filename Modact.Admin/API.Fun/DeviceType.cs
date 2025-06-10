using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class DeviceType : ApiClassMasterTableDao<DTO_modm_devicetype>
    {
        public DeviceType(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

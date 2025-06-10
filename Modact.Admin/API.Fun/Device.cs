using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class Device : ApiClassMasterTableDao<DTO_modm_device>
    {
        public Device(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

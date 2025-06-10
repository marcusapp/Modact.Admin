using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class DeviceUser : ApiClassRelationalTableDao<DTO_modr_device_user>
    {
        public DeviceUser(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class DevicePermission : ApiClassRelationalTableDao<DTO_modr_device_permission>
    {
        public DevicePermission(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

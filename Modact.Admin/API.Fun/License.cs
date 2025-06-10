using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class License : ApiClassMasterTableDao<DTO_modm_license>
    {
        public License(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }
    }
}

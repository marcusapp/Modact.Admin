using Modact.Data.DAL;
using Modact.Data.Models;
using Dapper.SimpleCRUD;

namespace Modact.API.Fun
{
    public class SerialNumber : ApiClassMasterTableDao<DTO_modm_serialnumber>
    {
        public SerialNumber(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

        public string PickNextNumber(string snId)
        {
            return PickNextNumber(snId, null);
        }

        public string PickNextNumber(string snId, string? datetimeValue)
        {
            var sn = new Modact.SerialNumber(appDB, snId);

            return sn.PickNextNumber(datetimeValue);
        }

        public string ViewNextNumber(string snId)
        {
            return ViewNextNumber(snId);
        }

        public string ViewNextNumber(string snId, string datetimeValue)
        {
            var sn = new Modact.SerialNumber(appDB, snId);

            return sn.ViewNextNumber(datetimeValue);
        }

        public string ResetNumber(string snId)
        {
            var sn = this.Get(snId);
            sn.sn_number = 0;
            this.Update(sn);
            return sn.sn_number.ToString();
        }
    }
}

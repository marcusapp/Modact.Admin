using Modact.Data.DAL;
using Modact.Data.Models;


namespace Modact.API.Fun
{
    public class App : ApiClassMasterTableDao<DTO_modm_app>
    {
        public App(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }
    }
}

using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class TokenUser : ApiClassMasterTableDao<DTO_modm_token_user>
    {
        public TokenUser(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

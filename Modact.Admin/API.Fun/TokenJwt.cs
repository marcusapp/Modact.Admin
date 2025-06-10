using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class TokenJwt : ApiClassMasterTableDao<DTO_modm_token_jwt>
    {
        public TokenJwt(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

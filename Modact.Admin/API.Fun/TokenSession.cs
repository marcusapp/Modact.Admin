using Modact.Data.DAL;
using Modact.Data.Models;

namespace Modact.API.Fun
{
    public class TokenSession : ApiClassTransactionTableDao<DTO_modt_token_session>
    {
        public TokenSession(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

    }
}

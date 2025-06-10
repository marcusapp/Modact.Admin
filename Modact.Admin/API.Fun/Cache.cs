using Modact.Data.Cache;

namespace Modact.API.Fun
{
    internal class Cache : ApiClass
    {
        public Cache(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

        public void RefreshDatabaseCache()
        {
            DatabaseCache.Refresh(ApiFunctionAccessory.Databases.AppDatabase);

            ApiFunctionAccessory.AddMessage(ApiMessageType.Success, "Database cache refresh success.");
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}

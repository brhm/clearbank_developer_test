using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearBank.DeveloperTest.Data
{
    public static class DataStoreFactory
    {
        public static IDataStore CreateDataStore(string type)
        {
            switch (type)
            {
                case "Backup":
                    return new BackupAccountDataStore();

                default:
                    return new AccountDataStore();

            }
        }
    }

}

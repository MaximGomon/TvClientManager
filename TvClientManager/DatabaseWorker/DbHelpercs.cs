using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalEntity;

namespace DatabaseWorker
{
    public static class DbHelpercs
    {
        public static List<GlobalEntity.TvClients> LoadClients()
        {
            List<TvClients> result = new List<TvClients>();
            
            using (var db = new TvManagerModelContainer())
            {
                result = db.TvClientsSet.ToList();
            }

            return result;
        }

        public static List<TvClients> AddItem()
        {
            List<TvClients> result = new List<TvClients>();

            using (var db = new TvManagerModelContainer())
            {
                result = db.TvClientsSet.ToList();
            }

            return result;
        }
    }
}

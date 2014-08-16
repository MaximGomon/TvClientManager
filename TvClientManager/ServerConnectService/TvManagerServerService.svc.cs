using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DatabaseWorker;
using GlobalEntity;

namespace ServerConnectService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TvManagerServerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TvManagerServerService.svc or TvManagerServerService.svc.cs at the Solution Explorer and start debugging.
    public class TvManagerServerService : ITvManagerServerService
    {
        //public string GetData(int value)
        //{
        //    return string.Format("Client send: {0}", value);
        //}

        public bool ClientLogin(string login, string password)
        {
            return true;
        }

        public List<TvClients> LoadClients()
        {
            return DbHelpercs.LoadClients();
        }

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
    }
}

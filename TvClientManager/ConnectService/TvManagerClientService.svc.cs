using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ConnectService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TvManagerClientService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TvManagerClientService.svc or TvManagerClientService.svc.cs at the Solution Explorer and start debugging.
    public class TvManagerClientService : ITvManagerClientService
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        public string GetServerData(int value)
        {
            string resp = String.Empty;

            var serverService = ServiceManager.ServiceInstance;
            resp = serverService.GetData(value);

            return string.Format("Server return: {0}", resp);
        }
    }
}

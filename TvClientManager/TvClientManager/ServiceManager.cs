using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvClientManager.ServiceReference;

namespace TvClientManager
{
    public static class ServiceManager
    {
        private static TvManagerClientServiceClient clientService;

        public static TvManagerClientServiceClient ServiceInstance
        {
            get 
            {
                if (clientService == null)
                {
                    clientService = new TvManagerClientServiceClient();
                }
                return clientService;
            }
        }
    }
}

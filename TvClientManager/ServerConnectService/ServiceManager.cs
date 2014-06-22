using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServerConnectService.ServiceReference;

namespace ServerConnectService
{
    public static class ServiceManager
    {
        private static TvManagerClientServiceClient clientService;

        public static TvManagerClientServiceClient ClientInstance
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
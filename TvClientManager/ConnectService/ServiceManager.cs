using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConnectService.ServiceReference;

namespace ConnectService
{
    public static class ServiceManager
    {
        private static TvManagerServerServiceClient serverService;

        public static TvManagerServerServiceClient ServiceInstance
        {
            get
            {
                if (serverService == null)
                {
                    serverService = new TvManagerServerServiceClient();
                }
                return serverService;
            }
        }
    }
}
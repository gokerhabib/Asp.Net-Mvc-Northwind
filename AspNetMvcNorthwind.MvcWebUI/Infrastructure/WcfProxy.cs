using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using AspNetMvcNorthwind.Interfaces;

namespace AspNetMvcNorthwind.MvcWebUI.Infrastructure
{
    public static class WcfProxy<T>
    {
        public static T CreateChannel()
        {
            string address = string.Format("http://localhost:57550/{0}.svc?wsdl", typeof(T).Name.Substring(1));

            var binding = new BasicHttpBinding();

            var channel = new ChannelFactory<T>(binding,address);

            return channel.CreateChannel();
        }
    }
}
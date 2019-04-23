using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            RunAsync().GetAwaiter().GetResult();


        }

        private static async Task RunAsync()
        {

            string MyAppId = "";
            string MyReturnUri = "";
            string UrlCRM = "https://micrm.crm4.dynamics.com";

            AuthenticationContext authcontext = new AuthenticationContext("https://login.microsoftonline.com/common");


            var result = await authcontext.AcquireTokenAsync(UrlCRM,
                MyAppId, 
                new Uri(MyReturnUri), 
                new PlatformParameters(PromptBehavior.Auto));
        }


    }
}

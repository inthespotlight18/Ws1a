/*******************************************************************************************************************\
*                    
                     DZ220814 - Windows Service
                     Version : 1.1
                     Release : August 14/2022
                                                                                                                    *
\*******************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.ServiceProcess;
using System.Text;

namespace WindowsServiceCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
 
        public static string SERVICE_NAME = "DZ_test";

        static void Main()
        {
            try
            {
                // GS2110125 : ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc0 | 0x300 | 0xc00);
                if (GAPP.Gap.Test)
                {
                    // Console.WriteLine("Public ... {0}\n", GAPP.GapLib.GetPUBurl());
                    Console.WriteLine("\n");
                    Console.ReadLine();
                }
                else
                {
                    ServiceBase[] ServicesToRun;
                    ServicesToRun = new ServiceBase[]
                    {
                         new Service1()
                    };
                    ServiceBase.Run(ServicesToRun);
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Trace.TraceWarning(ex.Message);
                if (GAPP.Gap.Test) Console.ReadKey();
            }
         
        }
    }
}

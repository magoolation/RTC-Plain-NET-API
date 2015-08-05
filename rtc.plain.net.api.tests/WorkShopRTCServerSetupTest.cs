using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rtc.plain.net.api.repository.client;
using rtc.plain.net.api.repository.common;

namespace rtc.plain.net.api.tests
{
    [TestClass]
    public class WorkShopRTCServerSetupTest
    {
        private const String RTC_EXTENSION_WORKSHOP_PROJECT_NAME = "RTC Extension Workshop";
        private const String SCRUM_PROCESS_ID = "scrum2.process.ibm.com";
        private const String SCRUM_MASTER_ROLE_ID = "ScrumMaster";
        private const String RTC_EXTENSION_STREAM_NAME = "RTC Extension Stream";
        private const String EXTENSION_STREAM_DESCRIPTION = "Stream with Extension code";
        private const String RTC_EXTENSION_WORKSPACE_NAME = "RTC Extension Workspace";
        private const String EXTENSION_WORKSPACE_DESCRIPTION = "Workspace for loading the Workshop code.";
        private const String RTC_EXTENSION_WORKSHOP_LICENSE_COMPONENT = "RTC Extension Lab Code License";
        private const String RTC_EXTENSION_WORKSHOP_LAB_CODE_COMPONENT = "RTC Extension Lab Code";
        private const String RTC_EXTENSION_WORKSHOP_CONFIGURATION_COMPONENT = "RTC Extension Workshop Configuration";

        [TestMethod]
        public void TestMethod1()
        {
            bool result;
            Console.WriteLine("Starting Team Platform");
            if (!TeamPlatform.isStarted())
                TeamPlatform.startup();
            try
            {
                Console.WriteLine("Team Platform started");
                WorkShopRTCServerSetupTest setupExtDevServer = new WorkShopRTCServerSetupTest();
                string args = null;
                result = setupExtDevServer.run(args);
            }
            catch (TeamRepositoryException x)
            {
                Console.WriteLine(x.ToString());
                result = false;
            }
            finally
            {
                TeamPlatform.shutdown();
            }
        }

        private bool run(string args)
        {
            throw new NotImplementedException();
        }
    }
}

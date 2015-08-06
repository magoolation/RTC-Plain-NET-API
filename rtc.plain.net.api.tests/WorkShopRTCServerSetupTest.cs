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
                string[] args = { "http://localhost:9443/ccm", "myadmin", "myadmin" };
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

        private bool run(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: ServerSetup <repositoryURI> <userId> <password>");
                return false;
            }

            String repositoryURI = args[0];
            String userId = args[1];
            String password = args[2];

            IProgressMonitor monitor = new NullProgressMonitor();
            ITeamRepository teamRepository = logIntoTeamRepository(repositoryURI,
                    userId, password, monitor);

            throw new NotImplementedException();
        }

        private ITeamRepository logIntoTeamRepository(string repositoryURI, string userId, string password, object monitor)
        {
            Console.WriteLine("Trying to log into repository: " + repositoryURI);
            ITeamRepository teamRepository = TeamPlatform
                    .getTeamRepositoryService().getTeamRepository(repositoryURI);
            teamRepository.registerLoginHandler(new LoginHandler(userId, password));
            teamRepository.login(monitor);
            Console.WriteLine("Login succeeded.");
            return teamRepository;
        }
    }
}

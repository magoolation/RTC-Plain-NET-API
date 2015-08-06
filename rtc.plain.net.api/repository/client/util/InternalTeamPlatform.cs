using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using log4net;
using rtc.plain.net.api.common.intern.util;
using rtc.plain.net.api.extras;
using ComLib.Configuration;

namespace rtc.plain.net.api.repository.client.util
{
    class InternalTeamPlatform
    {
        private static readonly InternalTeamPlatform singleton = new InternalTeamPlatform();
        private static readonly ILog logger = LogManager.GetLogger(typeof(InternalTeamPlatform));

        private const String URI = "uri";
        private const String CLASS = "class";
        private const String ECORE = "org.eclipse.emf.ecore";
        private const String PACKAGE = "package";
        private const String GEN_PACKAGE = "generated_package";
        private const String EINSTANCE = "eINSTANCE";
        private const String BUNDLE = "bundle";
        private const String PATH = "path";

        private StandaloneExtensionRegistry standaloneRegistry;
        private StandaloneFileLocator standaloneFileLocator;
        private StandaloneAdapterRegistry standaloneAdapterRegistry;
        private bool started = false;
        private bool asBundle = false;
        private bool stopped = false;

        internal static InternalTeamPlatform getDefault()
        {
            return singleton;
        }

        internal void start(bool asBundle)
        {
            lock (this)
            {
                logDebug(Thread.CurrentThread.ToString());
                logDebug("start asBundle: " + asBundle);
                if ((started) && (asBundle != this.asBundle))
                    throw new InvalidOperationException(
                      "Already started from a different context. Current context = " + (asBundle ? "bundle" : "plain .NET"));
                if (started)
                {
                    return;
                }
                started = true;
                stopped = false;
                logDebug("set start true");
                this.asBundle = asBundle;

                initializeDebugOptions();

                if (!asBundle)
                {
                    initializeRegistry();
                    initializeGeneratedPackages();
                    initializeFileLocator();
                    initializeAdapterRegistry();
                }
            }
        }

        private void initializeAdapterRegistry()
        {
            standaloneAdapterRegistry = new StandaloneAdapterRegistry();
            standaloneAdapterRegistry.start();
        }

        private void initializeFileLocator()
        {
            standaloneFileLocator = new StandaloneFileLocator();
        }

        private void initializeGeneratedPackages()
        {
            // No EMF impl for now
        }

        private void initializeRegistry()
        {
            standaloneRegistry = new StandaloneExtensionRegistry();
            // No OSGi impl for now
        }

        private void initializeDebugOptions()
        {
            String value = null;

            if (asBundle)
            {
                throw new NotImplementedException();
            }
            else
            {
                value = Config.Get<string>("com.ibm.team.repository.client.traceNoCancelableServerCall");
            }

            bool TRACE_NON_CANCELABLE_SERVER_CALLS = (value != null) && (value.Equals("true", StringComparison.InvariantCultureIgnoreCase));

            TeamServiceCallContextImpl.setLogNonCancelableServiceCalls(TRACE_NON_CANCELABLE_SERVER_CALLS);
        }

        internal void shutdown()
        {
            lock(this) {
                
                logDebug(Thread.CurrentThread.ToString());                
                logDebug("shutdown stopped: " + stopped);
                
                if (stopped)
                {                    
                    throw new InvalidOperationException("Already stopped");                    
                }
                
                if (!asBundle)                
                {
                    // No OSGi impl for now
                }
                
                logDebug("setting stopped variables");                
                started = false;                
                asBundle = false;                
                stopped = true;                
            }
        }

        internal bool isStarted()
        {
            return started;
        }


        private static void logWarning(String prefix, String bundleSymbolicName, IPath path)
        {
            if (!logger.IsDebugEnabled)
            {
                return;
            }

            String msg = messageForFind(prefix, bundleSymbolicName, path);
            Exception e = new ArgumentException(msg);
            logger.Debug(e.Message, e);
        }

        private static string messageForFind(string prefix, string bundleSymbolicName, IPath path)
        {
            throw new NotImplementedException();
        }


        private static void logDebug(String debugMessage)
        {
            if (!logger.IsDebugEnabled)
            {
                return;
            }

            logger.Debug(debugMessage);
        }
    }
}

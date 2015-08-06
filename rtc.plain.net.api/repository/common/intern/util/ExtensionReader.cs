using log4net;
using rtc.plain.net.api.common.intern.util;
using System;
using System.Collections;
using System.Reflection;

namespace rtc.plain.net.api.common.intern.util
{
    internal class ExtensionReader
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly Object startLock = new Object();

        private bool started;

        private readonly String extensionPointId;

        private readonly IRegistryChangeListener registryChangeListener;

        private readonly String pluginId;

        private ArrayList listeners;

        protected ExtensionReader(String pluginID, String extensionPoint)
        {
            pluginId = pluginID;
            extensionPointId = extensionPoint;
            registryChangeListener = createRegistryChangeListener();
            listeners = new ArrayList(3);
            started = false;
        }

        private IRegistryChangeListener createRegistryChangeListener()
        {
            return new RegistryChangeListener(this);

        }

        internal void handleRegistryChanged(IRegistryChangeEvent events)
        {
            throw new NotImplementedException();
        }

        internal void start()
        {
            lock (startLock)
            {
                bool started = isStarted();

                if (started) return;

                setStarted(true);
                addRegistryListener(registryChangeListener, pluginId);
                readRegistry();
                ProcessStarted();
            }
        }

        protected void readRegistry()
        {
            // No OSGi impl for now
        }

        private void addRegistryListener(object registryChangeListener, object pluginId)
        {
            // No OSGi impl for now
        }

        private void setStarted(bool started)
        {
            lock (startLock)
            {
                this.started = started;
            }
        }

        protected void ProcessStarted() { }

        protected bool isStarted()
        {
            lock (startLock)
            {
                return this.started;
                // Can't determine how it works
            }
        }

        class RegistryChangeListener : IRegistryChangeListener
        {
            readonly ExtensionReader INSTANCE;

            public RegistryChangeListener(ExtensionReader er)
            {
                INSTANCE = er;
            }

            public void registryChanged(IRegistryChangeEvent events)
            {
                INSTANCE.handleRegistryChanged(events);
            }
        }
    }
}
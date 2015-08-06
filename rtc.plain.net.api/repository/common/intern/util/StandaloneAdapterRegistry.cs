using System;

namespace rtc.plain.net.api.common.intern.util
{
    class StandaloneAdapterRegistry : ExtensionReader
    {

        public const String RUNTIME_PLUGIN_ID = "org.eclipse.core.runtime";
        public const String ADAPTER_POINT_ID = "adapters";

        public StandaloneAdapterRegistry() : base("org.eclipse.core.runtime", "adapters")
        {
            // No OSGi impl for now
        }


        protected bool handleExtensionAdded(Object element)
        {
            throw new NotImplementedException();
        }


        private String getAdaptableType(Object element)
        {
            throw new NotImplementedException();
        }


        public object loadFactory(Object element)
        {
            throw new NotImplementedException();
        }
    }
}

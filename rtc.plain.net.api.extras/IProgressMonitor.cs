using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rtc.plain.net.api.extras
{
    public abstract class IProgressMonitor
    {
        public const int UNKNOWN = -1;

        public abstract void beginTask(String paramString, int paramInt);

        public abstract void done();

        public abstract void internalWorked(double paramDouble);

        public abstract bool isCanceled();

        public abstract void setCanceled(bool paramBoolean);

        public abstract void setTaskName(String paramString);

        public abstract void subTask(String paramString);

        public abstract void worked(int paramInt);
    }
}

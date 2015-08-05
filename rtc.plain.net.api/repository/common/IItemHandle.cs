using rtc.plain.net.api.links.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rtc.plain.net.api.repository.common
{
    public interface IItemHandle
    {
        UUID getItemId();

        bool hasStateId();

        UUID getStateId();

        bool sameStateId(IItemHandle paramIItemHandle);

        IItemType getItemType();

        Object getOrigin();

        bool isImmutable();

        void makeImmutable();

        void protect();

        bool sameItemId(IItemHandle paramIItemHandle);

        bool hasFullState();

        IItem getFullState();

        bool isAuditable();

        bool isUnmanaged();

        bool isSimple();

        Object getAdapter(Type paramClass);

        bool equals(Object paramObject);

        long size();
    }
}

/* Location:           C:\RTC40Dev\installs\PlainJavaAPI\com.ibm.team.repository.common_1.3.3000.v20131022_0156.jar
 * Qualified Name:     com.ibm.team.repository.common.IItemHandle
 * Java Class Version: 6 (50.0)
 * JD-Core Version:    0.7.1
 */
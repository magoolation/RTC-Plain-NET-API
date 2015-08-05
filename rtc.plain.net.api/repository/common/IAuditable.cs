using rtc.plain.net.api.repository.common.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rtc.plain.net.api.repository.common
{
    public abstract class IAuditable
    {
        public static readonly String PREDECESSOR_STATE_PROPERTY = RepositoryPackage.eINSTANCE.getAuditable_Predecessor().getName();

        public static readonly String MERGE_PREDECESSOR_STATE_PROPERTY = RepositoryPackage.eINSTANCE.getAuditable_MergePredecessor().getName();

        public abstract IAuditableHandle getPredecessorState();

        public abstract IAuditableHandle getMergePredecessorState();
    }
}

namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface EOperation
    {

        /**
         * Obtains the delegate for this operation.
         * A default delegate is always available, so this should not return
         * <code>null</code>.
         * 
         * @return the operation delegate
         */
        InvocationDelegate getInvocationDelegate();

        /**
         * Assigns a delegate to this operation.
         * 
         * @param invocationDelegate the new operation delegate
         */
        void setInvocationDelegate(InvocationDelegate invocationDelegate);
    }
}
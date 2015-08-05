using System;

namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface Adapter
    {
        /**
   * Notifies that a change to some feature has occurred.
   * @param notification a description of the change.
   */
        void notifyChanged(Notification notification);

        /**
         * Returns the target from which the adapter receives notification.
         * In general, an adapter may be shared by more than one notifier.
         * @return the target notifier.
         * @see #setTarget
         */
        Notifier getTarget();

        /**
         * Sets the target from which the adapter will receive notification.
         * This method is only to be called by a notifier when this adapter
         * is added to or removed from its adapter list.
         * In general, an adapter may be shared by more than one notifier.
         * @param newTarget the new notifier.
         * @see #getTarget
         */
        void setTarget(Notifier newTarget);

        /**
         * Returns whether the adapter is of the given type.
         * In general, an adapter may be the adapter for many types.
         * @param type the type.
         * @return whether the adapter is of the given type.
         * @see AdapterFactory#isFactoryForType
         */
        bool isAdapterForType(Object type);
    }
}
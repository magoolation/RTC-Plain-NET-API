namespace rtc.plain.net.api.extras.emf.ecore
{
    /**
 * A source of notification delivery.
 * Since all modeled objects will be notifiers, 
 * the method names start with "e" to distinguish the EMF methods 
 * from the client's methods.
 */
    public interface Notifier
    {
        /**
         * Returns list of the adapters associated with this notifier.
         * @return the adapters associated with this notifier.
         */
        EList<Adapter> eAdapters();

        /**
         * Returns whether this notifier will deliver notifications to the adapters.
         * @return whether notifications will be delivered.
         * @see #eSetDeliver
         */
        bool eDeliver();

        /**
         * Sets whether this notifier will deliver notifications to the adapters.
         * @param deliver whether or not to deliver.
         * @see #eDeliver()
         */
        void eSetDeliver(bool deliver);

        /**
         * Notifies a change to a feature of this notifier as described by the notification.
         * The notifications will generally be {@link #eDeliver() delivered} 
         * to the {@link #eAdapters adapters}
         * via {@link Adapter#notifyChanged Adapter.notifyChanged}.
         * @param notification a description of the change.
         */
        void eNotify(Notification notification);
    }
}
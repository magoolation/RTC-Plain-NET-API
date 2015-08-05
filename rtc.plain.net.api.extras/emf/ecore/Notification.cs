﻿using System;

namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface Notification
    {
        /**
   * Returns the object affected by the change.
   * @return the object affected by the change.
   */
        Object getNotifier();

        

        /**
         * Returns the type of change that has occurred.
         * The valid types of events are defined by the constants in this class.
         * @return the type of change that has occurred.
         * @see Notifier
         */
        int getEventType();
        
        /**
         * Returns the numeric ID of the feature relative to the given class, or {@link #NO_FEATURE_ID} when not applicable.
         * @param expectedClass the class to which the ID is relative.
         * @return the numeric ID of the feature.
         * @see #NO_FEATURE_ID
         */
        int getFeatureID(Type expectedClass);

        /**
         * Returns the object representing the feature of the notifier that has changed.
         * @return the feature that has changed.
         */
        Object getFeature();

        /**
         * Returns the value of the notifier's feature before the change occurred.
         * For a list-based feature, this represents a value, or a list of values, removed from the list.
         * For a move, this represents the old position of the moved value.
         * @return the old value of the notifier's feature.
         */
        Object getOldValue();

        /**
         * Returns the value of the notifier's feature after the change occurred.
         * For a list-based feature, this represents a value, or a list of values, added to the list.
         * @return the new value of the notifier's feature.
         */
        Object getNewValue();

        /**
         * Returns whether the notifier's feature was considered set before the change occurred.
         * @return whether the notifier's feature was considered set before the change occurred.
         */
        bool wasSet();

        /**
         * Returns true if this notification represents an event that did not change the state of the notifying object.
         * For the events {@link #ADD}, {@link #ADD_MANY}, {@link #REMOVE}, {@link #REMOVE_MANY}, {@link #MOVE}, 
         * it always returns false.
         * For the events {@link #RESOLVE} and {@link #REMOVING_ADAPTER} it always returns true.
         * For the events {@link #SET} and {@link #UNSET} it returns true if the old and the new value are equal;
         * In addition, for certain types of features there may be a distinction between 
         * being set to a default value and not being set at all, which implies that it has the default value.
         * In this situation, even in the case that the old and new values are equal, 
         * isTouch may never the less return false in order to indicate that, although the value has not changed,
         * the feature has gone from simply having a default value to being set to that same default value,
         * or has gone from being set to the default value back to being unset.
         * @return whether or not this is a state changing modification.
         */
        bool isTouch();

        /**
         * Returns true if the notification's feature has been set to its default value.
         * @return whether or not this is a feature reset event.
         */
        bool isReset();

        /**
         * Returns the position within a list-based feature at which the change occurred.
         * It returns {@link #NO_INDEX} when not applicable.
         * @return the position at which the change occurred.
         */
        int getPosition();

        /**
         * Returns whether the notification can be and has been merged with this one.
         * @return whether the notification can be and has been merged with this one.
         */
        bool merge(Notification notification);

        /**
         * Returns the old value of the notifier's feature, if it is of type <code>bool</code>. 
         * @return the old value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>bool</code>.
         */
        bool getOldboolValue();

        /**
         * Returns the new value of the notifier's feature, if it is of type <code>bool</code>. 
         * @return the new value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>bool</code>.
         */
        bool getNewboolValue();

        /**
         * Returns the old value of the notifier's feature, if it is of type <code>byte</code>. 
         * @return the old value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>byte</code>.
         */
        byte getOldByteValue();

        /**
         * Returns the new value of the notifier's feature, if it is of type <code>byte</code>. 
         * @return the new value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>byte</code>.
         */
        byte getNewByteValue();

        /**
         * Returns the old value of the notifier's feature, if it is of type <code>char</code>. 
         * @return the old value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>char</code>.
         */
        char getOldCharValue();

        /**
         * Returns the new value of the notifier's feature, if it is of type <code>char</code>. 
         * @return the new value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>char</code>.
         */
        char getNewCharValue();

        /**
         * Returns the old value of the notifier's feature, if it is of type <code>double</code>. 
         * @return the old value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>double</code>.
         */
        double getOldDoubleValue();

        /**
         * Returns the new value of the notifier's feature, if it is of type <code>double</code>. 
         * @return the new value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>double</code>.
         */
        double getNewDoubleValue();

        /**
         * Returns the old value of the notifier's feature, if it is of type <code>float</code>. 
         * @return the old value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>float</code>.
         */
        float getOldFloatValue();

        /**
         * Returns the new value of the notifier's feature, if it is of type <code>float</code>. 
         * @return the new value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>float</code>.
         */
        float getNewFloatValue();

        /**
         * Returns the old value of the notifier's feature, if it is of type <code>int</code>. 
         * @return the old value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>int</code>.
         */
        int getOldIntValue();

        /**
         * Returns the new value of the notifier's feature, if it is of type <code>int</code>. 
         * @return the new value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>int</code>.
         */
        int getNewIntValue();

        /**
         * Returns the old value of the notifier's feature, if it is of type <code>long</code>. 
         * @return the old value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>long</code>.
         */
        long getOldLongValue();

        /**
         * Returns the new value of the notifier's feature, if it is of type <code>long</code>. 
         * @return the new value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>long</code>.
         */
        long getNewLongValue();

        /**
         * Returns the old value of the notifier's feature, if it is of type <code>short</code>. 
         * @return the old value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>short</code>.
         */
        short getOldShortValue();

        /**
         * Returns the new value of the notifier's feature, if it is of type <code>short</code>. 
         * @return the new value of the notifier's feature.
         * @exception IllegalStateException if the feature isn't <code>short</code>.
         */
        short getNewShortValue();

        /**
         * Returns the old value of the notifier's feature as a String.
         * @return the old value of the notifier's feature.
         */
        String getOldStringValue();

        /**
         * Returns the new value of the notifier's feature as a String.
         * @return the new value of the notifier's feature.
         */
        String getNewStringValue();
    }
}
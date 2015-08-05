using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace rtc.plain.net.api.extras.emf.ecore
{
    public abstract class EMap<K, V> : EList<KeyValuePair<K, V>>
    {
        /**
       * Returns the value associated with the key.
       * The key, the value, or both may be <code>null</code>.
       * @param key the key of the value.
       * @return the value associated with the key.
       */
        public abstract V get(Object key);

        /**
         * Associates the key with the value
         * and returns the value previously associated with the key, or <code>null</code>.
         * The key, the value, or both may be <code>null</code>.
         * Either the existing entry is updated, 
         * or a new entry is added to the end of the list.
         * @param key the key of the value.
         * @param value the value associated with the key.
         * @return the value formerly associated with the key, or <code>null</code>.
         */
        public abstract V put(K key, V value);

        /**
         * Puts each {@link java.util.Map.Entry Map.Entry} of the given map into this one.
         * @param map the map of entries.
         * @see #put
         */
        public abstract void putAll<K1, V1>(Dictionary<K1, V1> map) where K1 : K where V1 : V;

        /**
         * Puts each {@link java.util.Map.Entry Map.Entry} of the given map into this one.
         * @param map the map of entries.
         * @see #put
         */
        public abstract void putAll<K1, V1>(EMap<K1, V1> map) where K1 : K where V1 : V;

        /**
         * Returns the index in the list of the entry with the given key, 
         * or <code>-1</code>, if there is no such entry.
         * @param key a key.
         * @return the index of the entry with the given key.
         */
        public abstract int indexOfKey(Object key);

        /**
         * Returns whether the key is associated with a value.
         * @param key a key associated with a value.
         * @return whether the key is associated with a value.
         */
        public abstract bool containsKey(Object key);

        /**
         * Returns whether the value is associated with a key.
         * @param value a value associated with a key.
         * @return whether the value is associated with a key.
         */
        public abstract bool containsValue(Object value);

        /**
         * Disassociates the key from its value,
         * and returns the value formerly associated with the key.
         * An entry is removed from the list, if the key is found.
         * @param key the key of a value.
         * @return the value formerly associated with the key.
         * 
         */
        public abstract V removeKey(Object key);

        /**
         * Returns a map view.
         * @return a map view.
         */
        public abstract Dictionary<K, V> map();

        /**
         * Returns a set view of the entries.
         * @return a set view of the entries.
         */
        public abstract HashSet<KeyValuePair<K, V>> entrySet();

        /**
         * Returns a set view of the keys of the entries.
         * @return a set view of the keys of the entries.
         */
        public abstract HashSet<K> keySet();

        /**
         * Returns a collection view the values of the entries.
         * @return a collection view the values of the entries.
         */
        public abstract Collection<V> values();

        public abstract void move(int newPosition, KeyValuePair<K, V> targetObject);

        public abstract KeyValuePair<K, V> move(int newPosition, int oldPosition);

        /**
         * An internal interface implemented by the {@link #map() map view}.
         * It provides access to the EMap view.
         */
        public abstract class InternalMapView<K, V> : Dictionary<K, V>
        {
            /**
             * Returns the EMap view of the map.
             * @return the EMap view of the map.
             */
            public abstract EMap<K, V> eMap();
        }
    }
}
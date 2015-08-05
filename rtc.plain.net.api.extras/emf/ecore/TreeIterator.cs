using System.Collections.Generic;

namespace rtc.plain.net.api.extras.emf.ecore
{
    /**
 * A mechanism for iterating over all the nodes of a tree;
 * it provides the capability to {@link #prune prune} the iteration so that all descendants of a particular node are skipped.
 */
    public interface TreeIterator<E> : IEnumerator<E>
    {
        /**
         * Prunes the iterator so that it skips over all the nodes below the most recent result of calling {@link #next() next()}.
         */
        void prune();
    }
}
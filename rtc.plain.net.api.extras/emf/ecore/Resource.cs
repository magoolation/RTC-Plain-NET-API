using System;
using System.Collections.Generic;
using System.IO;

namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface Resource
    {
        /**
   * Returns the containing resource set.
   * A resource is contained by a resource set
   * if it appears in the {@link ResourceSet#getResources resources}, i.e., the contents, of that resource set.
   * This reference can only be modified by altering the contents of the resource set directly.
   * </p>
   * @return the containing resource set, or <code>null</code> if there isn't one.
   * @see EObject#eContainer
   * @see EObject#eResource
   * @see ResourceSet#getResources
   */
        ResourceSet getResourceSet();

        /**
         * Returns the URI of this resource.
         * The URI is normally expected to be {@link URI#isRelative absolute} and {@link URI#isHierarchical hierarchical};
         * document-relative references will not be serialized and will not be {@link URI#resolve(URI) resolved},
         * if this is not the case.
         * @return the URI of this resource, or <code>null</code> if there isn't one.
         * @see #setURI(URI)
         * @see URI#isRelative
         * @see URI#isHierarchical
         */
        Uri getURI();

        /**
         * Sets the URI of this resource.
         * @param uri the new URI.
         * @see #getURI
         */
        void setURI(Uri uri);

        /**
         * Returns the cached value of the {@link URIConverter#ATTRIBUTE_TIME_STAMP time stamp}
         * when this resource was last {@link #load(Map) loaded} or {@link #save(Map) saved},
         * or {@link URIConverter#NULL_TIME_STAMP NULL_TIME_STAMP} 
         * if the resource is not {@link #isLoaded() loaded} 
         * and the time stamp has not been {@link #setTimeStamp(long) set}.
         * The return value is represented as the number of milliseconds 
         * since the epoch (00:00:00 GMT, January 1, 1970).
         * The returned value may not be the same as the {@link URIConverter#ATTRIBUTE_TIME_STAMP actual time stamp}
         * if the resource has been modified via external means since the last load or save.
         * @since 2.4
         * @see #setTimeStamp(long)
         */
        long getTimeStamp();

        /**
         * Sets the value of the {@link #getTimeStamp() time stamp}.
         * The time stamp is typically set indirectly via other operations on the resource 
         * such as {@link #load(Map) loading} and {@link #save(Map) saving}.
         * @param timeStamp the new value of the time stamp.
         * @since 2.4
         * @see #getTimeStamp()
         * @see #RESOURCE__TIME_STAMP
         */
        void setTimeStamp(long timeStamp);

        /**
         * Returns the list of the direct content objects;
         * each is of type {@link EObject}.
         * <p>
         * The contents may be directly modified.
         * Removing an object will have the same effect as
         * {@link org.eclipse.emf.ecore.util.EcoreUtil#remove(EObject) EcoreUtil.remove(EObject)}.
         * Adding an object will remove it from the previous container;
         * it's {@link EObject#eContainer container} will be <code>null</code>
         * and it's {@link EObject#eResource resource} will the <code>this</code>.
         * </p>
         * @return the direct content objects.
         */
        EList<EObject> getContents();

        /**
         * Returns a tree iterator that iterates over all the {@link #getContents direct contents} and indirect contents of this resource.
         * @return a tree iterator that iterates over all contents.
         * @see EObject#eAllContents
         * @see ResourceSet#getAllContents
         * @see org.eclipse.emf.ecore.util.EcoreUtil#getAllContents(Resource, bool)
         */
        TreeIterator<EObject> getAllContents();

        /**
         * Returns the URI {@link URI#fragment fragment} that,
         * when passed to {@link #getEObject getEObject} will return the given object.
         * <p>
         * In other words,
         * the following is <code>true</code> for any object contained by a resource:
         *<pre>
         *   Resource resource = eObject.eResource();
         *   eObject == resource.getEObject(resource.getURIFragment(eObject))
         *</pre>
         * An implementation may choose to use IDs
         * or to use structured URI fragments, as supported by
         * {@link org.eclipse.emf.ecore.InternalEObject#eURIFragmentSegment eURIFragmentSegment}.
         * </p>
         * @param eObject the object to identify.
         * @return the URI {@link URI#fragment fragment} for the object.
         * @see #getEObject(String)
         * @see org.eclipse.emf.ecore.InternalEObject#eURIFragmentSegment(org.eclipse.emf.ecore.EStructuralFeature, EObject)
         */
        String getURIFragment(EObject eObject);


        /**
         * Returns the resolved object for the given URI {@link URI#fragment fragment}.
         * <p>
         * The fragment encoding will typically be that produced by {@link #getURIFragment getURIFragment}.
         * </p>
         * @param uriFragment the fragment to resolve.
         * @return the resolved object for the given fragment, or <code>null</code> if it can't be resolved.
         * @see #getURIFragment(EObject)
         * @see ResourceSet#getEObject(URI, bool)
         * @see org.eclipse.emf.ecore.util.EcoreUtil#resolve(EObject, ResourceSet)
         * @see org.eclipse.emf.ecore.InternalEObject#eObjectForURIFragmentSegment(String)
         * @throws org.eclipse.emf.common.util.WrappedException if a problem occurs navigating the fragment.
         */
        EObject getEObject(String uriFragment);

        /**
         * Saves the resource using the specified options.
         * <p>
         * Options are handled generically as feature-to-setting entries;
         * the resource will ignore options it doesn't recognize.
         * The options could even include things like an Eclipse progress monitor...
         * </p>
         * <p>
         * An implementation typically uses the {@link ResourceSet#getURIConverter URI converter}
         * of the {@link #getResourceSet containing} resource set
         * to {@link URIConverter#createOutputStream(URI, Map) create} an output stream,
         * and then delegates to {@link #save(OutputStream, Map) save(OutputStream, Map)}.
         * </p>
         * @param options the save options.
         * @see #save(OutputStream, Map)
         */
        void save<K, V>(Dictionary<K,V> options);

        /**
         * Loads the resource using the specified options.
         * <p>
         * Options are handled generically as feature-to-setting entries;
         * the resource will ignore options it doesn't recognize.
         * The options could even include things like an Eclipse progress monitor...
         * </p>
         * <p>
         * An implementation typically uses the {@link ResourceSet#getURIConverter URI converter}
         * of the {@link #getResourceSet containing} resource set
         * to {@link URIConverter#createInputStream(URI, Map) create} an input stream,
         * and then delegates to {@link #load(InputStream, Map) load(InputStream, Map)}.
         * </p>
         * <p>
         * When the load completes, the {@link #getErrors errors} and {@link #getWarnings warnings} can be consulted.
         * An implementation will typically deserialize as much of a document as possible
         * while producing diagnostics for any problems that are encountered.
         * </p>
         * @param options the load options.
         * @see #load(InputStream, Map)
         */
        void load<K, V>(Dictionary<K, V> options);

        /**
         * Saves the resource to the output stream using the specified options.
         * <p>
         * Usually, {@link #save(Map) save(Map)} is called directly and it calls this.
         * </p>
         * @param outputStream the stream
         * @param options the save options.
         * @see #save(Map)
         * @see #load(InputStream, Map)
         */
        void save<K, V>(StreamWriter outputStream, Dictionary<K, V> options);

        /**
         * Loads the resource from the input stream using the specified options.
         * <p>
         * Usually, {@link #load(Map) load(Map)} is called directly and it calls this.
         * </p>
         * @param inputStream the stream
         * @param options the load options.
         * @see #load(Map)
         * @see #save(OutputStream, Map)
         */
        void load<K, V>(StreamReader inputStream, Dictionary<K, V> options);

        /**
         * Returns whether modification tracking is enabled.
         * <p>
         * If modification tracking is enabled,
         * each object of the resource must be adapted in order to listen for changes.
         * This will make the processing of {@link Resource.Internal#attached attached} 
         * and {@link Resource.Internal#detached detached } significantly more expensive.
         * as well as all model editing, in general.
         * </p>
         * @return whether modification tracking is enabled.
         */
        bool isTrackingModification();

        /**
         * Sets whether modification tracking is enabled.
         * <p>
         * Calling this method is expensive because it walks the content {@link #getAllContents tree} to add or remove adapters.
         * </p>
         * @param isTrackingModification whether modification tracking is to be enabled.
         */
        void setTrackingModification(bool isTrackingModification);

        /**
         * Returns whether this resource has been modified.
         * <p>
         * A resource is set to be unmodified after it is loaded or saved.
         * {@link #isTrackingModification Automatic} modification tracking is supported, but it is expensive.
         * Moreover, it is a poor fit for a model that supports undoable commands,
         * since an undo looks like a change when it's really exactly the opposite.
         * </p>
         * @return whether this resource has been modified.
         * @see #setModified(bool)
         */
        bool isModified();

        /**
         * Sets whether this resource has been modified.
         * <p>
         * A resource is automatically set to be unmodified after it is loaded or saved.
         * {@link #isTrackingModification Automatic} modification tracking typically calls this directly.
         * </p>
         * @param isModified whether this resource has been modified.
         * @see #isModified
         */
        void setModified(bool isModified);

        /**
         * Returns whether the resource is loaded.
         * <p>
         * This will be <code>false</code> when the resource is first {@link ResourceSet#createResource(URI) created}
         * and will be set to <code>false</code>, when the resource is {@link #unload unloaded}.
         * It will be set to <code>true</code> when the resource is {@link #load(Map) loaded}
         * and when {@link #getContents contents} are first added to a resource that isn't loaded.
         * Calling {@link org.eclipse.emf.common.util.BasicEList#clear clear}
         * for the {@link #getContents contents} of a resource that isn't loaded,
         * will set the resource to be loaded;
         * this is the simplest way to create an empty resource that's considered loaded.
         * </p>
         * @return whether the resource is loaded.
         */
        bool isLoaded();

        /**
         * Clears the {@link #getContents contents},
         * {@link #getErrors errors},
         * and {@link #getWarnings warnings} of the resource
         * and {@link #isLoaded marks} it as unloaded.
         * <p>
         * It walks the content {@link #getAllContents tree},
         * and {@link org.eclipse.emf.ecore.InternalEObject#eSetProxyURI sets} each content object to be a proxy.
         * The resource will remain in the {@link #getResourceSet resource set},
         * and can be subsequently reloaded.
         * </p>
         */
        void unload();

        /**
         * {@link URIConverter#delete(URI, Map) deletes} the resource using the specified options,
         * {@link #unload() unloads} it,
         * and then removes it from the {@link #getResourceSet() containing} resource set.
         * <p>
         * Options are handled generically as feature-to-setting entries;
         * the resource will ignore options it doesn't recognize.
         * The options could even include things like an Eclipse progress monitor...
         * </p>
         * <p>
         * An implementation typically uses the {@link ResourceSet#getURIConverter URI converter}
         * of the {@link #getResourceSet containing} resource set
         * to {@link URIConverter#delete(URI, Map)}  the resource's {@link #getURI() URI}.
         * </p>
         */
        void delete<K, V>(Dictionary<K, V> options);

        /**
         * Returns a list of the errors in the resource;
         * each error will be of type {@link org.eclipse.emf.ecore.resource.Resource.Diagnostic}.
         * <p>
         * These will typically be produced as the resource is {@link #load(Map) loaded}.
         * </p>
         * @return a list of the errors in the resource.
         * @see #load(Map)
         */
        EList<Diagnostic> getErrors();

        /**
         * Returns a list of the warnings and informational messages in the resource;
         * each warning will be of type {@link org.eclipse.emf.ecore.resource.Resource.Diagnostic}.
         * <p>
         * These will typically be produced as the resource is {@link #load(Map) loaded}.
         * </p>
         * @return a list of the warnings in the resource.
         * @see #load(Map)
         */
        EList<Diagnostic> getWarnings();
    }
}
using System;
using System.Collections.Generic;
using rtc.plain.net.api.extras.emf.ecore.impl;

namespace rtc.plain.net.api.extras.emf.ecore
{
    public abstract class EPackage : ENamedElement
    {

        public abstract String getNsURI();


        public abstract void setNsURI(String paramString);


        public abstract String getNsPrefix();


        public abstract void setNsPrefix(String paramString);


        public abstract EFactory getEFactoryInstance();


        public abstract void setEFactoryInstance(EFactory paramEFactory);


        public abstract EList<EClassifier> getEClassifiers();


        public abstract EList<EPackage> getESubpackages();


        public abstract EPackage getESuperPackage();


        public abstract EClassifier getEClassifier(String paramString);
        public abstract string getName();
        public abstract void setName(string value);
        public abstract EList<EAnnotation> getEAnnotations();
        public abstract EAnnotation getEAnnotation(string source);
        public abstract EClass eClass();
        public abstract Resource eResource();
        public abstract EObject eContainer();
        public abstract EStructuralFeature eContainingFeature();
        public abstract EReference eContainmentFeature();
        public abstract EList<EObject> eContents();
        public abstract TreeIterator<EObject> eAllContents();
        public abstract bool eIsProxy();
        public abstract EList<EObject> eCrossReferences();
        public abstract object eGet(EStructuralFeature paramEStructuralFeature);
        public abstract object eGet(EStructuralFeature paramEStructuralFeature, bool parambool);
        public abstract void eSet(EStructuralFeature paramEStructuralFeature, object paramObject);
        public abstract bool eIsSet(EStructuralFeature paramEStructuralFeature);
        public abstract void eUnset(EStructuralFeature paramEStructuralFeature);
        public abstract object eInvoke(EOperation paramEOperation, EList<object> paramEList);

        interface Descriptor
        {
            EPackage getEPackage();
            EFactory getEFactory();

        }

        public abstract class Registry : Dictionary<string, object>
        {

            public static readonly Registry INSTANCE = rtc.plain.net.api.extras.emf.ecore.impl.EPackageRegistryImpl.createGlobalRegistry();


            public abstract EPackage getEPackage(String paramString);


            public abstract EFactory getEFactory(String paramString);

        }
    }
}

/* Location:           C:\RTC40Dev\installs\PlainJavaAPI\org.eclipse.emf.ecore_2.6.1.v20100914-1218.jar
 * Qualified Name:     org.eclipse.emf.ecore.EPackage
 * Java Class Version: 5 (49.0)
 * JD-Core Version:    0.7.1
 */

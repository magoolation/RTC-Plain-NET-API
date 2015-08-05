using System;

namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface EObject
    {
        EClass eClass();

        Resource eResource();

        EObject eContainer();

        EStructuralFeature eContainingFeature();

        EReference eContainmentFeature();

        EList<EObject> eContents();

        TreeIterator<EObject> eAllContents();

        bool eIsProxy();

        EList<EObject> eCrossReferences();

        Object eGet(EStructuralFeature paramEStructuralFeature);

        Object eGet(EStructuralFeature paramEStructuralFeature, bool parambool);

        void eSet(EStructuralFeature paramEStructuralFeature, Object paramObject);

        bool eIsSet(EStructuralFeature paramEStructuralFeature);

        void eUnset(EStructuralFeature paramEStructuralFeature);

        Object eInvoke(EOperation paramEOperation, EList<Object> paramEList);
    }
}
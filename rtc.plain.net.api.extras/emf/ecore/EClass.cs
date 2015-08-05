using System;

namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface EClass
  : EClassifier
{
  bool isAbstract();

    void setAbstract(bool parambool);

    bool isInterface();

    void setInterface(bool parambool);

    EList<EClass> getESuperTypes();

    EList<EClass> getEAllSuperTypes();

    EAttribute getEIDAttribute();

    EList<EStructuralFeature> getEStructuralFeatures();

    EList<EGenericType> getEGenericSuperTypes();

    EList<EGenericType> getEAllGenericSuperTypes();

    EList<EAttribute> getEAttributes();

    EList<EAttribute> getEAllAttributes();

    EList<EReference> getEReferences();

    EList<EReference> getEAllReferences();

    EList<EReference> getEAllContainments();

    EList<EStructuralFeature> getEAllStructuralFeatures();

    EList<EOperation> getEOperations();

    EList<EOperation> getEAllOperations();

    bool isSuperTypeOf(EClass paramEClass);

    int getFeatureCount();

    EStructuralFeature getEStructuralFeature(int paramInt);

    EStructuralFeature getEStructuralFeature(String paramString);

    int getOperationCount();

    EOperation getEOperation(int paramInt);

    int getOperationID(EOperation paramEOperation);

    EOperation getOverride(EOperation paramEOperation);

    int getFeatureID(EStructuralFeature paramEStructuralFeature);
}
}

/* Location:           C:\RTC40Dev\installs\PlainJavaAPI\org.eclipse.emf.ecore_2.6.1.v20100914-1218.jar
 * Qualified Name:     org.eclipse.emf.ecore.EClass
 * Java Class Version: 5 (49.0)
 * JD-Core Version:    0.7.1
 */

using System;

namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface EFactory  : EModelElement
    {
        EPackage getEPackage();

        void setEPackage(EPackage paramEPackage);

        EObject create(EClass paramEClass);

        Object createFromString(EDataType paramEDataType, String paramString);

        String convertToString(EDataType paramEDataType, Object paramObject);
    }
}
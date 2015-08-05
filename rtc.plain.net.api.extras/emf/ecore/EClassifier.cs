using System;

namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface EClassifier
    {

        String getInstanceClassName();

        void setInstanceClassName(String paramString);

        Type getInstanceClass();

        void setInstanceClass(Type paramClass);

        Object getDefaultValue();

        String getInstanceTypeName();

        void setInstanceTypeName(String paramString);

        EPackage getEPackage();

        EList<ETypeParameter> getETypeParameters();

        bool isInstance(Object paramObject);

        int getClassifierID();
    }
}
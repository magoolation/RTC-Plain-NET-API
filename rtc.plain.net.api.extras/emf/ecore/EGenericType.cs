namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface EGenericType: EObject
    {
        EGenericType getEUpperBound();

        void setEUpperBound(EGenericType paramEGenericType);

        EList<EGenericType> getETypeArguments();

        EClassifier getERawType();

        EGenericType getELowerBound();

        void setELowerBound(EGenericType paramEGenericType);

        ETypeParameter getETypeParameter();

        void setETypeParameter(ETypeParameter paramETypeParameter);

        EClassifier getEClassifier();

        void setEClassifier(EClassifier paramEClassifier);
    }
}
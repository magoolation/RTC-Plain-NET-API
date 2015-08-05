namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface ETypeParameter: ENamedElement
    {
        EList<EGenericType> getEBounds();
    }
}
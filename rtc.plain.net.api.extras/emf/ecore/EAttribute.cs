namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface EAttribute : EStructuralFeature
    {
        bool isID();

        void setID(bool parambool);

        EDataType getEAttributeType();
        string getName();
    }
}
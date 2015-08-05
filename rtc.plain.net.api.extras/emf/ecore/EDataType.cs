namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface EDataType : EClassifier
    {

        bool isSerializable();

        void setSerializable(bool paramBoolean);
    }
}
namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface EList<T>
    {
        
        void move(int newPosition, T targetObject);

        
        T move(int newPosition, int oldPosition);
    }
}
using System;

namespace rtc.plain.net.api.extras.emf.ecore
{
    public interface EAnnotation : EModelElement
    {
        String getSource();
        void setSource(String value);
        EMap<String, String> getDetails();
        EModelElement getEModelElement();
        void setEModelElement(EModelElement value);
        EList<EObject> getContents();
        EList<EObject> getReferences();

    }
}
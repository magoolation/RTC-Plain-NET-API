using System;

namespace rtc.plain.net.api.extras.emf.ecore
{
    /// <summary>
    /// <!-- begin-user-doc -->
    /// A representation of the model object '<em><b>ENamed Element</b></em>'.
    /// <!-- end-user-doc -->
    ///
    /// <p>
    /// The following features are supported:
    /// <ul>
    ///   <li>{@link rtc.plain.net.api.extras.emf.ecore.ENamedElement#getName <em>Name</em>}</li>
    /// </ul>
    /// </p>
    /// </summary>
    public interface ENamedElement : EModelElement
    {
        /// <summary>
        /// Returns the value of the '<em><b>Name</b></em>' attribute.
        /// <!-- begin-user-doc -->
        /// <p>
        /// It represents the name of the element.
        /// </p>
        /// <!-- end-user-doc -->
        /// </summary>
        /// <returns>the value of the '<em>Name</em>' attribute.</returns>
        String getName();

        /// <summary>
        /// Sets the value of the '{@link org.eclipse.emf.ecore.ENamedElement#getName <em>Name</em>}' attribute.
        /// <!-- begin-user-doc -->
        /// <!-- end-user-doc -->
        /// </summary>
        /// <param name="value">the new value of the '<em>Name</em>' attribute.</param>
        void setName(String value);
    }
}
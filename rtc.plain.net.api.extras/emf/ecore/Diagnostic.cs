using System;
using System.Collections.Generic;

namespace rtc.plain.net.api.extras.emf.ecore
{
    public abstract class Diagnostic
    {
        /**
         * The bit mask value <code>0x0</code> for a {@link #getSeverity severity} indicating everything is okay.
         */
        int OK = 0x0;

        /**
         * The bit mask value <code>0x1</code> for a {@link #getSeverity severity} indicating there is an informational message.
         */
        int INFO = 0x1;

        /**
         * The bit mask value <code>0x2</code> for a {@link #getSeverity severity} indicating there is warning message.
         */
        int WARNING = 0x2;

        /**
         * The bit mask value <code>0x1</code> for a {@link #getSeverity severity} indicating there is an error message.
         */
        int ERROR = 0x4;

        /**
         * The bit mask value <code>0x1</code> for a {@link #getSeverity severity} indicating that the diagnosis was canceled.
         */
        int CANCEL = 0x8;

        /**
         * Returns an indicator of the severity of the problem.
         */
        public abstract int getSeverity();

        /**
         * Returns a message describing the situation.
         */
        public abstract String getMessage();

        /**
         * Returns the unique identifier of the source.
         */
        public abstract String getSource();

        /**
         * Returns {@link #getSource source-specific} identity code.
         */
        public abstract int getCode();

        /**
         * Returns the relevant low-level exception, or <code>null</code> if none. 
         */
        public abstract Exception getException();

        /**
         * Returns the arbitrary associated list of data.
         * The first element is typically the object that is the primary source of the problem;
         * the second element is typically some object describing the problematic feature or aspect of the primary source,
         * and the remaining elements are additional objects associated with or describing the problem.
         */
        public abstract List<V> getData<V>();

        /**
         * Returns the list of child {@link Diagnostic diagnostics}.
         */
        public abstract List<Diagnostic> getChildren();

        /**
         * A diagnostic indicating that everything is okay.
         */
        //public static readonly Diagnostic OK_INSTANCE =
        //  new BasicDiagnostic
        //    (OK, "org.eclipse.emf.common", 0, org.eclipse.emf.common.CommonPlugin.INSTANCE.getString("_UI_OK_diagnostic_0"), null);

        /**
         * A diagnostic indicating that the diagnosis was canceled.
         */
        //public static readonly Diagnostic CANCEL_INSTANCE =
        //  new BasicDiagnostic
        //    (CANCEL, "org.eclipse.emf.common", 0, org.eclipse.emf.common.CommonPlugin.INSTANCE.getString("_UI_Cancel_diagnostic_0"), null);
    }
}
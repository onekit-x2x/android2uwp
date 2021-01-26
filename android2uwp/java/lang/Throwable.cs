namespace java.lang
{
    using static androidx.annotation.RecentlyNonNull;
    using static androidx.annotation.RecentlyNullable;
    using static java.io.PrintStream;
    using static java.io.PrintWriter;
    using static java.io.Serializable;
    public class Throwable : Serializable
    {
        public Throwable()
        {
            throw new RuntimeException("Stub!");
        }
        public Throwable(String message)
        {
            throw new RuntimeException("Stub!");
        }
        public Throwable(String message, Throwable cause)
        {
            throw new RuntimeException("Stub!");
        }
        public Throwable(Throwable cause)
        {
            throw new RuntimeException("Stub!");
        }
        protected Throwable(String message, Throwable cause, boolean enableSuppression, boolean writableStackTrace)
        {
            throw new RuntimeException("Stub!");
        }

        public String getMessage()
        {
            throw new RuntimeException("Stub!")
        }

        public String getLocalizedMessage()
        {
            throw new RuntimeException("Stub!")
        }

        public Throwable getCause()
        {
            throw new RuntimeException("Stub!")
        }

        public Throwable initCause(Throwable cause)
        {
            throw new RuntimeException("Stub!")
        }

        public String toString()
        {
            throw new RuntimeException("Stub!")
        }
        public void printStackTrace()
        {
            throw new RuntimeException("Stub!")
        }
        public void printStackTrace(PrintStream s)
        {
            throw new RuntimeException("Stub!")
        }
        public void printStackTrace(PrintWriter s)
        {
            throw new RuntimeException("Stub!")
        }

        public Throwable fillInStackTrace()
        {
            throw new RuntimeException("Stub!")
        }

        public StackTraceElement[] getStackTrace()
        {
            throw new RuntimeException("Stub!")
        }
        public void setStackTrace(StackTraceElement[] stackTrace)
        {
            throw new RuntimeException("Stub!")
        }
        public void addSuppressed(Throwable exception)
        {
            throw new RuntimeException("Stub!")
        }

        public Throwable[] getSuppressed()
        {
            throw new RuntimeException("Stub!")
        }
    }

}
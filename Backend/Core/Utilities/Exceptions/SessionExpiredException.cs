namespace Core.Utilities.Exceptions
{
    public class SessionExpiredException: Exception
    {
        public SessionExpiredException(string message) : base(message)
        {

        }
        public SessionExpiredException() : base()
        {

        }
    }
}

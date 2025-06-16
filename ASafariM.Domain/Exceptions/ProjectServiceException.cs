namespace ASafariM.Domain.Exceptions
{
    public class ProjectServiceException : Exception
    {
        public ProjectServiceException(string message)
            : base(message) { }

        public ProjectServiceException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    public class NotFoundException : Exception
    {
        public NotFoundException(string message)
            : base(message) { }
    }
}

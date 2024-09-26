namespace SchoolClassManagmentProject.Models.AppException
{
    [Serializable]
    internal class EmailIsSameAsOldException : Exception
    {
        public EmailIsSameAsOldException()
        {
        }

        public EmailIsSameAsOldException(string? message) : base(message)
        {
        }

        public EmailIsSameAsOldException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
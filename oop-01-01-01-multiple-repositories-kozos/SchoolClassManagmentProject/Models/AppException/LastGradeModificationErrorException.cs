namespace SchoolClassManagmentProject.Models.AppException
{
    [Serializable]
    internal class LastGradeModificationErrorException : ArgumentException
    {
        public LastGradeModificationErrorException()
        {
        }

        public LastGradeModificationErrorException(string? message) : base(message)
        {
        }

        public LastGradeModificationErrorException(string? message, string? parameterName, Exception? innerException) : base(message, parameterName, innerException)
        {
        }
    }
}
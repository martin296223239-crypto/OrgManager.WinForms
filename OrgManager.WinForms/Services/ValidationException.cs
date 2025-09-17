using System;


namespace OrgManager.WinForms.Services
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }
}
using System;

namespace Recaptcha.Verify.Net.Exceptions
{
    /// <summary>
    /// This exception is thrown when the action passed in function is empty.
    /// </summary>
    [Serializable]
    public class EmptyActionException : RecaptchaServiceException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyActionException"/> class.
        /// </summary>
        public EmptyActionException() : base("Provided action is empty.") { }
    }
}

using System;

namespace Recaptcha.Verify.Net.Exceptions
{
    /// <summary>
    /// This exception is thrown when captcha answer is empty.
    /// </summary>
    [Serializable]
    public class EmptyCaptchaAnswerException : RecaptchaServiceException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyCaptchaAnswerException"/> class.
        /// </summary>
        public EmptyCaptchaAnswerException() : base("Received captcha answer is empty.") { }
    }
}

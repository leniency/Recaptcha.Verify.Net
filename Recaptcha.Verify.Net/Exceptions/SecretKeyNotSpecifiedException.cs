using System;

namespace Recaptcha.Verify.Net.Exceptions
{
    /// <summary>
    /// This exception is thrown when secret key was not specified in options or request params.
    /// </summary>
    [Serializable]
    public class SecretKeyNotSpecifiedException : RecaptchaServiceException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecretKeyNotSpecifiedException"/> class.
        /// </summary>
        public SecretKeyNotSpecifiedException() : base("Secret key was not provided.") { }
    }
}

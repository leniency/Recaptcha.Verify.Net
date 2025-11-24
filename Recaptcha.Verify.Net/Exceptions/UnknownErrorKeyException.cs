using System;

namespace Recaptcha.Verify.Net.Exceptions
{
    /// <summary>
    /// This exception is thrown when verification response error key is unknown.
    /// </summary>
    [Serializable]
    public class UnknownErrorKeyException : RecaptchaServiceException
    {
        /// <summary>
        /// The key of the error.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnknownErrorKeyException"/> class.
        /// </summary>
        /// <param name="key">The key of the error.</param>
        public UnknownErrorKeyException(string key) : base($"Unknown error key: {key}.")
        {
            Key = key;
        }
    }
}

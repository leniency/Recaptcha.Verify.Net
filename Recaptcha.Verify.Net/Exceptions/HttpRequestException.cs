using Refit;
using System;

namespace Recaptcha.Verify.Net.Exceptions
{
    /// <summary>
    /// This exception is thrown when http request failed.
    /// Stores <see cref="ApiException"/> as inner exception.
    /// </summary>
    [Serializable]
    public class HttpRequestException : RecaptchaServiceException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestException"/> class 
        /// with referense to the <see cref="ApiException"/>.
        /// </summary>
        public HttpRequestException(ApiException inner) : base(inner.Message, inner) { }
    }
}

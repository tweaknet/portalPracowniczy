using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portalPracowniczy.ApplicationServices.API.ErrorHandling
{
    public static class ErrorType
    {
        public const string InternalServerError = "Internal_server_error";
        public const string ValidationError = "Validation_Error";
        public const string NotAuthenticated = "not_authenticated";
        public const string Unauthorized = "unaut";
        public const string NotFound = "nf";
        public const string UnsuportedMediaType = "umt";
        public const string UnsuportedMethod = "um";
        public const string RequestTooLarge = "Rtl";
        public const string TooManyRequests = "tmr";

    }
}

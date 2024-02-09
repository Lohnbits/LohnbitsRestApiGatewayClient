using System.Text.Json.Serialization;

#nullable enable

namespace LohnbitsRestApiGateway.Data
{
    public class BaseResult 
    {
        public BaseResult() 
        {
            ErrorCode = eErrorCode.None;
        }

        public BaseResult Error(eErrorCode errorCode)
        {
            ErrorCode = errorCode;
            return this;
        }

        public eErrorCode ErrorCode { get; set; }

        internal int StatusCode
        {
            get
            {
                switch (ErrorCode)
                {
                    case eErrorCode.None:
                        return 200;
                    case eErrorCode.InvalidLogin:
                        return 401;
                    default:
                        return 500;
                }
            }
        }

        /// <summary>
        /// Liste der Fehlercodes
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum eErrorCode
        {
            None,
            UnknownError,
            InvalidLogin,
            NoLohnbitsServerConnection,
            InvalidBeaer,
            LohnbitsServerError,
            InvalidSessionId,
            AccessDenied,
            InvalidParameter,
            InvalidCustomer,
            InvalidContent,
            InvalidEmployee,
            InvalidDocumentType,
            DocumentUploadError
        }
    }
}

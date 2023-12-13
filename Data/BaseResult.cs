namespace LohnbitsRestApiGateway.Data
{
    public class BaseResult
    {
        public BaseResult()
        {
            ErrorCode = eErrorCode.None;
        }

        public eErrorCode ErrorCode { get; set; }

        public enum eErrorCode
        {
            None,
            InvalidLogin,
        }
    }
}

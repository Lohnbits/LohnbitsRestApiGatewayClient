#nullable enable

namespace LohnbitsRestApiGateway.Data.Documents
{
    public class InsertDocumentInboxResult : BaseResult
    {
        public new InsertDocumentInboxResult Error(eErrorCode errorCode)
        {
            ErrorCode = errorCode;
            return this;
        }
    }
}

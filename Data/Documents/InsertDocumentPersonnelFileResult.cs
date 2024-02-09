#nullable enable

namespace LohnbitsRestApiGateway.Data.Documents
{
    public class InsertDocumentPersonnelFileResult : BaseResult
    {
        public new InsertDocumentPersonnelFileResult Error(eErrorCode errorCode)
        {
            ErrorCode = errorCode;
            return this;
        }
    }
}

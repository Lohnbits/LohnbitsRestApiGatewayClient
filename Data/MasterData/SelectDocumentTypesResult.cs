#nullable enable

namespace LohnbitsRestApiGateway.Data.MasterData
{
    public class SelectDocumentTypesResult : BaseResult
    {

        public SelectDocumentTypesResult()
        {
            DocumentTypes = new List<DataDocumentType>();
        }

        public List<DataDocumentType> DocumentTypes { set; get; }
    }
}

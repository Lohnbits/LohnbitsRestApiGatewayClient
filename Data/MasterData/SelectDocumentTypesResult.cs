#nullable enable

namespace LohnbitsRestApiGateway.Data.MasterData
{
    public class SelectDocumentTypesResult : BaseResult
    {
        public class DataDocumentType
        {
            public DataDocumentType()
            {
                LohnbitsDokumenttypLfdNr = 0;
                BezeichnungGlobal = string.Empty;
            }

            public int LohnbitsDokumenttypLfdNr { set; get; }

            public string BezeichnungGlobal { set; get; }
        }

        public SelectDocumentTypesResult()
        {
            DocumentTypes = new List<DataDocumentType>();
        }

        public List<DataDocumentType> DocumentTypes { set; get; }
    }
}

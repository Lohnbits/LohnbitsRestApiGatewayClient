#nullable enable

namespace LohnbitsRestApiGateway.Data.MasterData
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
}

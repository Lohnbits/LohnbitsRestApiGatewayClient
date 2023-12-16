#nullable enable

namespace LohnbitsRestApiGateway.Data.MasterData
{
    public class SelectDocumentTypesRequest 
    {
        public SelectDocumentTypesRequest() 
        {
            MandantLfdNr = 0;
            SpecialFunction = null;
        }

        public int MandantLfdNr { set; get; }

        public string? SpecialFunction { set; get;}
    }
}

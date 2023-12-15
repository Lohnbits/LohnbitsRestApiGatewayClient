namespace LohnbitsRestApiGateway.Data.MasterData
{
    public class SelectDocumentTypesRequest
    {
        public SelectDocumentTypesRequest()
        {
            FkMandantLfdNr = 0;
            Personalnummer = null;
            InternetMandantLohnMitarbeiterLfdNr = null;
            SpecialFunction = null;
        }

        public int FkMandantLfdNr { set; get; }

        public int? Personalnummer { set; get; }

        public int? InternetMandantLohnMitarbeiterLfdNr { set; get; }

        public string SpecialFunction { set; get;}
    }
}

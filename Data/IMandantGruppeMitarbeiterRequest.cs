namespace LohnbitsRestApiGateway.Data
{
    public interface IMandantGruppeMitarbeiterRequest
    {
        public int? MandantLfdNr { set; get; }

        public int? MandantGruppeLfdNr { set; get; }

        public int? Personalnummer { set; get; }

        public int? MandantMitarbeiterLfdNr { set; get; }
    }
}

#nullable enable

namespace LohnbitsRestApiGateway.Data
{
    public interface IMandantMitarbeiterMultiRequest
    {
        public int? MandantLfdNr { set; get; }

        public int? MandantGruppeLfdNr { set; get; }

        public int? Mandantennummer { set; get; }
    }
}

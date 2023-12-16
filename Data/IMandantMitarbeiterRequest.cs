#nullable enable

namespace LohnbitsRestApiGateway.Data
{
    public interface IMandantMitarbeiterRequest
    {
        public int? Mandantennummer { set; get; }

        public int? Personalnummer { set; get; }

        public string? BetrieblichePersonalnummer { set; get; }

        public string? PersonalnummerZeiterfassung { set; get; }

        public int? MandantMitarbeiterLfdNr { set; get; }
    }
}

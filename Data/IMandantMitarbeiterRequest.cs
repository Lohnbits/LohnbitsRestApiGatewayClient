﻿#nullable enable

namespace LohnbitsRestApiGateway.Data
{
    public interface IMandantMitarbeiterRequest
    {
        public int? Mandantennummer { set; get; }

        public int? MandantLfdNr { set; get; }

        public int? MandantGruppeLfdNr { set; get; }

        public int? Personalnummer { set; get; }

        public string? PersonalnummerBetrieblich { set; get; }

        public string? PersonalnummerZeiterfassung { set; get; }

        public int? MandantMitarbeiterLfdNr { set; get; }
    }
}

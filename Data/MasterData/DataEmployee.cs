#nullable enable

namespace LohnbitsRestApiGateway.Data.MasterData
{
    public class DataEmployee
    {
        public DataEmployee()
        {
            MandantLfdNr = 0;
            MandantMitarbeiterLfdNr = 0;
            Mandantennummer = 0;
            Vorname = "";
            Familienname = "";
            Personalnummer = 0;
            BezeichnungBetrieb = "";
            PersonalnummerBetrieblich = "";
            PersonalnummerZeiterfassung = "";
            Eintritt = DateTime.MinValue;
            Austritt = DateTime.MinValue;
            StatusMitarbeiter = "";
            Kurzname = "";
            Kurzname2 = "";
        }

        public int MandantLfdNr { get; set; }

        public int MandantMitarbeiterLfdNr { get; set; }

        public int Mandantennummer { get; set; }

        public string Vorname { get; set; }

        public string Familienname { get; set; }

        public int Personalnummer { get; set; }

        public string BezeichnungBetrieb { get; set; }

        public string PersonalnummerBetrieblich { get; set; }

        public string PersonalnummerZeiterfassung { set; get; }

        /// <summary>
        /// Familienname, Vorname (Personalnummer)
        /// </summary>
        public string Kurzname { set; get; }

        /// <summary>
        /// Famlienname, Vorname
        /// </summary>
        public string Kurzname2 { set; get; }

        public DateTime Eintritt { get; set; }

        public DateTime Austritt { get; set; }

        public string StatusMitarbeiter { get; set; }
    }
}

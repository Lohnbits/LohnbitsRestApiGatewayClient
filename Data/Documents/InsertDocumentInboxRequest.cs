#nullable enable

namespace LohnbitsRestApiGateway.Data.Documents
{
    public class InsertDocumentInboxRequest : IMandantMitarbeiterRequest
    {
        public InsertDocumentInboxRequest()
        {
            Mandantennummer = null;
            MandantLfdNr = null;
            MandantGruppeLfdNr = null;
            Personalnummer = null;
            PersonalnummerBetrieblich = null;
            PersonalnummerZeiterfassung = null;
            MandantMitarbeiterLfdNr = null;
            DatumDokument = DateTime.MinValue;
            Dateiname = null;
            Bemerkung = "";
            Dateiformat = null;
            Content = null;
        }

        public int? Mandantennummer { set; get; }

        public int? MandantLfdNr { set; get; }

        public int? MandantGruppeLfdNr { set; get; }

        public int? Personalnummer { set; get; }

        public string? PersonalnummerBetrieblich { set; get; }

        public string? PersonalnummerZeiterfassung { set; get; }

        public int? MandantMitarbeiterLfdNr { set; get; }

        public string Bemerkung { set; get; }

        /// <summary>
        /// der optionale Dateiname des Dokuments
        /// </summary>
        public string? Dateiname { set; get; }

        /// <summary>
        /// Folgende Dateiformate sind zulässig:
        /// 
        /// - PDF
        /// - TIFF
        /// - JPG
        /// - PNG
        /// 
        /// Das präferierte Dateiformat ist PDF.
        /// </summary>
        public string? Dateiformat { set; get; }

        /// <summary>
        /// das Belegdatum des Dokuments
        /// </summary>
        public DateTime? DatumDokument { set; get; }

        /// <summary>
        /// der Inhalt des Dokuments als Byte-Array
        /// </summary>
        public byte[]? Content { set; get; }
    }
}

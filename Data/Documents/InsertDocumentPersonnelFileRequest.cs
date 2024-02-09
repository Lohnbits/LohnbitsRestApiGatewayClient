#nullable enable

namespace LohnbitsRestApiGateway.Data.Documents
{
    public class InsertDocumentPersonnelFileRequest : IMandantMitarbeiterRequest
    {
        public InsertDocumentPersonnelFileRequest()
        {
            Mandantennummer = null;
            MandantLfdNr = null;
            MandantGruppeLfdNr = null;
            Personalnummer = null;
            PersonalnummerBetrieblich = null;
            PersonalnummerZeiterfassung = null;
            MandantMitarbeiterLfdNr = null;
            Bemerkung = "";
            Content = null;
            Dateiformat = null;
            Dateiname = null;
            DatumDokument = DateTime.MinValue;
            IsAlteVersion = false;
            IsNichtFuerMonatserfassung = false;
            IsSchnellstmoeglichBearbeiten = false;
            LohnbitsDokumenttypLfdNr = 0;
            ZeitraumMonatserfassung = null;
            ZeitraumZuordnung = null;
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
        public DateTime DatumDokument { set; get; }

        /// <summary>
        /// in diesem Abrechnungszeitraum soll das Dokument berücksichtigt werden
        /// </summary>
        public DateTime? ZeitraumMonatserfassung { set; get; }

        /// <summary>
        /// zu diesem Zeitraum soll das Dokument zugeordnet werden
        /// Beispiel: ein Arbeitsvertrag, der ab dem 1. Januar 2024 gültig ist, wird am 15. Dezember 2023 unterschrieben
        /// Dann ist DatumDokument der 15. Dezember 2023 und ZeitraumZuordnung der 1. Januar 2024
        /// </summary>
        public DateTime? ZeitraumZuordnung { set; get; }

        /// <summary>
        /// Der Dokumenttyp ist anzugeben. Gültige Dokumenttypen können mit SelectDocumentTypes abgefragt werden.
        /// </summary>
        public int LohnbitsDokumenttypLfdNr { set; get; }

        /// <summary>
        /// Handelt es sich um eine alte Version des Dokuments, die nur zu Archivierungszwecken hochgeladen wird?
        /// </summary>
        public bool IsAlteVersion { set; get; }

        /// <summary>
        /// dieses Dokument soll nicht bei den Monatsdaten erfasst werden, sondern ist nur für die Personalakte bestimmt
        /// </summary>
        public bool IsNichtFuerMonatserfassung { set; get; }

        /// <summary>
        /// dieses Dokument soll außerhalb der normalen Lohnabrechnung schnellstmöglich bearbeitet werden
        /// </summary>
        public bool IsSchnellstmoeglichBearbeiten { set; get; }

        /// <summary>
        /// der Inhalt des Dokuments als Byte-Array
        /// </summary>
        public byte[]? Content { set; get; }
    }
}

#nullable enable

namespace LohnbitsRestApiGateway.Data.MasterData
{
    public class SelectEmployeesRequest : IMandantMitarbeiterMultiRequest
    {
        public int? MandantLfdNr { set; get; }

        public int? MandantGruppeLfdNr { set; get; }

        public int? Mandantennummer { set; get; }

        /// <summary>
        /// sollen nur aktive Mitarbeiter zurückgegeben werden?
        /// </summary>
        public bool? IsActiveEmployees { get; set; }
    }
}

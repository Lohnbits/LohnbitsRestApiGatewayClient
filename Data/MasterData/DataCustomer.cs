#nullable enable

namespace LohnbitsRestApiGateway.Data.MasterData
{
    public class DataCustomer
    {
        public DataCustomer()
        {
            MandantLfdNr = 0;
            MandantGruppeLfdNr = 0;
            Mandantennummer = 0;
            BezeichnungBetrieb = "";
        }

        public int MandantLfdNr { set; get; }

        public int MandantGruppeLfdNr { set; get; }

        public int Mandantennummer { set; get; }

        public string BezeichnungBetrieb { set; get; }
    }
}

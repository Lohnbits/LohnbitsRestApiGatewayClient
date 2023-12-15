namespace LohnbitsRestApiGateway.Data.MasterData
{
    public class SelectCustomersResult : BaseResult
    {
        public class DataCustomer
        {
            public DataCustomer()
            {
                MandantLfdNr = 0;
                Mandantennummer = 0;
                BezeichnungBetrieb = "";
            }

            public int MandantLfdNr { set; get; }

            public int Mandantennummer { set; get; }

            public string BezeichnungBetrieb { set; get; }

        }

        public SelectCustomersResult()
        {
            Customers = new List<DataCustomer>();
        }

        public List<DataCustomer> Customers { set; get; }
    }
}

#nullable enable

namespace LohnbitsRestApiGateway.Data.MasterData
{
    public class SelectCustomersResult : BaseResult
    {
        public SelectCustomersResult()
        {
            Customers = new List<DataCustomer>();
        }

        public List<DataCustomer> Customers { set; get; }
    }
}

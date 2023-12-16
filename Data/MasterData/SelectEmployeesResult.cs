#nullable enable

namespace LohnbitsRestApiGateway.Data.MasterData
{
    public class SelectEmployeesResult : BaseResult
    {
        public SelectEmployeesResult()
        {
            Employees = new List<DataEmployee>();
        }

        public List<DataEmployee> Employees { set; get; }
    }
}

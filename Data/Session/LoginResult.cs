namespace LohnbitsRestApiGateway.Data.Session
{
    public class LoginResult : BaseResult
    {
        public LoginResult()
        {
            Token = string.Empty;
        }

        public string Token { get; set; }
    }
}

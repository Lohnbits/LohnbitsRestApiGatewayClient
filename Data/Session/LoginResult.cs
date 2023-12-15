namespace LohnbitsRestApiGateway.Data.Session
{
    /// <summary>
    /// Die Struktur für einen Login-Response. Sie enthält das Bearertoken, das für die weiteren Anfragen verwendet werden kann.
    /// </summary>
    public class LoginResult : BaseResult
    {
        public LoginResult()
        {
            Token = string.Empty;
        }

        /// <summary>
        /// das Bearertoken, das für die weiteren Anfragen verwendet werden kann.
        /// </summary>
        public string Token { get; set; }
    }
}

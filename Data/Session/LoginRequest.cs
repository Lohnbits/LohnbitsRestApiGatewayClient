namespace LohnbitsRestApiGateway.Data.Session
{
    /// <summary>
    /// Die Struktur für einen Login-Request.
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Standardkonstruktor, dem Benutzername und Passwort übergeben werden.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public LoginRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { set; get; }

        public string Password { set; get; }
    }
}

/*namespace Service
{
    public class JWTManagerRepository
    {
       

        private readonly IConfiguration _iconfiguration;
        public JWTManagerRepository(IConfiguration iconfiguration)
        {
            _iconfiguration = iconfiguration;
        }
        public Tokens Athenticate(Users user)
        {
            if(!UserRecords.Any(x=>.Key == users.Name && x.Value == users.Password))
                return null;
        }

        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["JWT:Key"]);
        var tokenDescription = new SecurityTokenDescription
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimType.Name, user.Name)
            }),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCreadentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey),SecurityAlgorith)
        }
    }
}
*/
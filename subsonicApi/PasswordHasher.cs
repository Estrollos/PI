using Microsoft.AspNetCore.Identity;

namespace subsonicApi
{
    public class PasswordHasher
    {
        private readonly PasswordHasher<ClientDTO> _hasher = new();   

        public string HashPassword(ClientDTO client, string password)
        {
            return _hasher.HashPassword(client, password);
        }

        public bool VerifyPassword(ClientDTO client, string password)
        {
            var result = _hasher.VerifyHashedPassword(client, client.Contrasena, password);
            
            return result == PasswordVerificationResult.Success;
        }
    }
}
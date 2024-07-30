using Google.Authenticator;

namespace Services.Auth.GoogleAuth.Api.Services
{
    public class TwoFactorAuthService
    {

        private const string Issuer = "TwoFactorAuthDemo";

        public string GenerateSecretKey()
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
        }

        public string GenerateQrCodeUri(string userEmail, string secretKey)
        {
            var tfa = new TwoFactorAuthenticator();
            var setupInfo = tfa.GenerateSetupCode(Issuer, userEmail, secretKey, false, 3);
            return setupInfo.QrCodeSetupImageUrl;
        }

        public bool ValidateTwoFactorPin(string secretKey, string code)
        {
            var tfa = new TwoFactorAuthenticator();
            return tfa.ValidateTwoFactorPIN(secretKey, code);
        }

    }
}

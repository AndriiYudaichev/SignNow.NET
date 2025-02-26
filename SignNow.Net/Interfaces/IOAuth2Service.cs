using SignNow.Net.Model;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SignNow.Net.Interfaces
{
    public interface IOAuth2Service
    {
        /// <summary>
        /// Retrieve Access token by user's login and passwor
        /// </summary>
        /// <param name="login">User's login</param>
        /// <param name="password">User's password</param>
        /// <param name="scope">Specify a scope for token request</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled</param>
        /// <returns>Token-object</returns>
        Task<Token> GetTokenAsync(string login, string password, Scope scope, CancellationToken cancellationToken = default);

        Task<Token> GetTokenAsync(string code, Scope scope, CancellationToken cancellationToken = default);

        Task<Token> RefreshTokenAsync(Token token, CancellationToken cancellationToken = default);

        Uri GetAuthorizationUrl(Uri redirectUrl);

        Task<bool> ValidateTokenAsync(Token token, CancellationToken cancellationToken = default);
    }
}
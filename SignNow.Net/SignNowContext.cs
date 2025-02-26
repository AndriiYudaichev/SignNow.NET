using SignNow.Net.Internal.Constants;
using SignNow.Net.Interfaces;
using SignNow.Net.Model;
using SignNow.Net.Service;
using System;

namespace SignNow.Net
{
    public class SignNowContext : AuthorizedWebClientBase, ISignNowContext
    {
        public SignNowContext(Token token) : this(ApiUrl.ApiBaseUrl, token)
        {

        }
        public SignNowContext(Uri baseApiUrl, Token token) : this(baseApiUrl, token, null)
        {
        }

        protected SignNowContext(Uri baseApiUrl, Token token, ISignNowClient signNowClient) : base(baseApiUrl, token, signNowClient)
        {
            Documents = new DocumentService(baseApiUrl, token, signNowClient);
        }

        public IDocumentService Documents { get; protected set; }

        public IUserService Users { get; protected set; }
    }
}

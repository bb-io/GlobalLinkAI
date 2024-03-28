using Apps.GlobalLinkNow.Api;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Common.Connections;
using RestSharp;

namespace Apps.GlobalLinkNow.Connections;

public class ConnectionValidator: IConnectionValidator
{
    public async ValueTask<ConnectionValidationResponse> ValidateConnection(
        IEnumerable<AuthenticationCredentialsProvider> authenticationCredentialsProviders,
        CancellationToken cancellationToken)
    {
        var creds = authenticationCredentialsProviders.ToArray();
        
        var request = new AppRequest("/apigateway/mtengine/organization/information/all", Method.Get, creds);
        await new AppClient(creds).ExecuteWithErrorHandling(request);
        
        return new()
        {
            IsValid = true
        };
    }
}
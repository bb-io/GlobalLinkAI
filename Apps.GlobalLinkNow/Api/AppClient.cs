using Apps.GlobalLinkNow.Constants;
using Apps.GlobalLinkNow.Models.Response;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Utils.Extensions.Sdk;
using Blackbird.Applications.Sdk.Utils.Extensions.String;
using Blackbird.Applications.Sdk.Utils.RestSharp;
using Newtonsoft.Json;
using RestSharp;

namespace Apps.GlobalLinkNow.Api;

public class AppClient : BlackBirdRestClient
{
    public AppClient(AuthenticationCredentialsProvider[] creds) : base(new()
    {
        BaseUrl = creds.Get(CredsNames.Host).Value.ToUri()
    })
    {
    }

    protected override Exception ConfigureErrorException(RestResponse response)
    {
        var error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
        return new(error.Message);
    }
}
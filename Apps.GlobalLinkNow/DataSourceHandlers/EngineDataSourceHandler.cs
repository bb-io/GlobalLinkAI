using Apps.GlobalLinkNow.Api;
using Apps.GlobalLinkNow.Invocables;
using Apps.GlobalLinkNow.Models.Response.Engines;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.GlobalLinkNow.DataSourceHandlers;

public class EngineDataSourceHandler : AppInvocable, IAsyncDataSourceHandler
{
    public EngineDataSourceHandler(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new AppRequest("/apigateway/mtengine/organization/information/all", Method.Get, Creds);
        var response = await Client.ExecuteWithErrorHandling<ListEnginesResponse>(request);

        return response.Engines
            .Where(x => context.SearchString is null ||
                        x.Alias.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .ToDictionary(x => x.Id, x => x.Alias);
    }
}
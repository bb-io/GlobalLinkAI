using Blackbird.Applications.Sdk.Utils.Sdk.DataSourceHandlers;

namespace Apps.GlobalLinkNow.DataSourceHandlers.StaticDataSourceHandlers;

public class TextTypeDataHandler : EnumDataHandler
{
    protected override Dictionary<string, string> EnumValues => new()
    {
        ["text"] = "Text",
        ["html"] = "HTML",
    };
}
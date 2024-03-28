using Apps.GlobalLinkNow.DataSourceHandlers;
using Apps.GlobalLinkNow.DataSourceHandlers.StaticDataSourceHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Newtonsoft.Json;

namespace Apps.GlobalLinkNow.Models.Request.Translation;

public class TranslateTextRequest
{
    [Display("Target language")]
    [JsonProperty("to")]
    [DataSource(typeof(LanguageDataSourceHandler))]
    public string To { get; set; }
    
    [Display("Source language")]
    [JsonProperty("from")]
    [DataSource(typeof(LanguageDataSourceHandler))]
    public string? From { get; set; }

    [Display("Text type")]
    [JsonProperty("textType")]
    [DataSource(typeof(TextTypeDataHandler))]
    public string? TextType { get; set; }
    
    [JsonProperty("domain")]
    public string? Domain { get; set; }
    
    [Display("Engine ID")]
    [JsonProperty("engineId")]
    [DataSource(typeof(EngineDataSourceHandler))]
    public string? EngineId { get; set; }
}
using Apps.GlobalLinkNow.DataSourceHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Newtonsoft.Json;

namespace Apps.GlobalLinkNow.Models.Request.Translation;

public class TranslateDocumentRequest
{
    [Display("Target language")]
    [JsonProperty("to")]
    [DataSource(typeof(LanguageDataSourceHandler))]
    public string To { get; set; }
    
    [Display("Source language")]
    [JsonProperty("from")]
    [DataSource(typeof(LanguageDataSourceHandler))]
    public string? From { get; set; }
    
    [Display("OCR")]
    [JsonProperty("ocr")]
    public bool? Ocr { get; set; }

    [JsonProperty("domain")]
    public string? Domain { get; set; }
    
    [Display("Engine ID")]
    [JsonProperty("engineId")]
    [DataSource(typeof(EngineDataSourceHandler))]
    public string? EngineId { get; set; }
}
namespace Apps.GlobalLinkAI.Models.Response.Translation;

public class TextTranslationResponse
{
    public IEnumerable<TranslationMessageResponse> Message { get; set; }
}
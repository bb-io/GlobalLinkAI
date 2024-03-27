namespace Apps.GlobalLinkAI.Models.Response.Translation;

public class TranslateDocumentResponse
{
    public IEnumerable<TranslateFileResponse> FileIds { get; set; }
}
namespace Apps.GlobalLinkNow.Models.Entities;

public class EngineEntity
{
    public string Id { get; set; }
    
    public string Alias { get; set; }
    
    public IEnumerable<string> SupportedLanguages { get; set; }
}
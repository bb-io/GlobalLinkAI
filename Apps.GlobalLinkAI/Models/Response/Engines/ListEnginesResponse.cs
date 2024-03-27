using Apps.GlobalLinkAI.Models.Entities;

namespace Apps.GlobalLinkAI.Models.Response.Engines;

public class ListEnginesResponse
{
    public IEnumerable<EngineEntity> Engines { get; set; }
}
using Apps.GlobalLinkNow.Models.Entities;

namespace Apps.GlobalLinkNow.Models.Response.Engines;

public class ListEnginesResponse
{
    public IEnumerable<EngineEntity> Engines { get; set; }
}
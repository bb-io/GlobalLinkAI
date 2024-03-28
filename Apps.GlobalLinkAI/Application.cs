using Blackbird.Applications.Sdk.Common;

namespace Apps.GlobalLinkAI;

public class Application : IApplication
{
    public string Name
    {
        get => "GlobalLink AI";
        set { }
    }

    public T GetInstance<T>()
    {
        throw new NotImplementedException();
    }
}
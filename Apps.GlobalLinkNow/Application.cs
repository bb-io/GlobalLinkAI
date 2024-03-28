using Blackbird.Applications.Sdk.Common;

namespace Apps.GlobalLinkNow;

public class Application : IApplication
{
    public string Name
    {
        get => "GlobalLink Now";
        set { }
    }

    public T GetInstance<T>()
    {
        throw new NotImplementedException();
    }
}
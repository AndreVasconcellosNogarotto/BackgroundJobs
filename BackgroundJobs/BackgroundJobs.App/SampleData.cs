using System.Collections.Concurrent;

namespace BackgroundJobs.App;

public class SampleData
{
    public ConcurrentBag<string> Data { get; set; } = new ();
}

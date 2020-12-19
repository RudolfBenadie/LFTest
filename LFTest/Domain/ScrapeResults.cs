using System;

namespace LFTest.Domain
{
  public class ScrapeResults
  {
    public string Name { get; set; }
    public string Website { get; set; }
    public bool HasGoogle { get; set; }
    public TimeSpan ScanDuration { get; set; }
  }
}

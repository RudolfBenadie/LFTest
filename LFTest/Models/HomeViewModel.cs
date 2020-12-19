using LFTest.Domain;
using System;
using System.Collections.Generic;

namespace LFTest.Models
{
  public class HomeViewModel
  {
    public List<ScrapeSource> ScrapeSourcesList { get; set; }
    public List<ScrapeResults> ScrapeResultsList { get; set; }
    public TimeSpan ScrapeDuration { get; set; }
  }
}

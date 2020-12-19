using CsvHelper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LFTest.Domain
{
    //
    // Summary:
    //     The ScraperEntity provides the implementation of data structures and functions to manage the scraping of a list of websites.
    //
    public class ScraperEntity
    {
        private List<ScrapeSource> _scrapeSources;
        private List<ScrapeResults> _scrapeResults;
        private TimeSpan _scrapeDuration;

        //
        // Summary:
        //  Instantiate and return a new ScraperEntity object
        //
        public ScraperEntity()
        {
            _scrapeSources = new List<ScrapeSource>();
            _scrapeResults = new List<ScrapeResults>();
        }

        //
        // Summary:
        //  Instantiate and return a new ScraperEntity object with scrape sources being injected
        //
        public ScraperEntity(List<ScrapeSource> scrapeSources)
        {
            _scrapeSources = scrapeSources;
            _scrapeResults = new List<ScrapeResults>();
        }

        //
        // Summary:
        //  Remove an entry from the scraping sources list using the index
        //
        // Parameters:
        //  int:
        //    The index of the item to be removed from the scraping source list
        //
        public void RemoveWebsiteFromScrapeSourcesAt(int index)
        {
            _scrapeSources.RemoveAt(index);
        }


        //
        // Summary:
        //  Remove an entry from the scraping sources list using the name of an entry
        //
        // Parameters:
        //  string:
        //    The name of the entry to be removed from the scraping source list
        //
        public void RemoveWebsiteFromScrapeSourcesByName(string name)
        {
            RemoveWebsiteFromScrapeSourcesAt(_scrapeSources.FindIndex(item => item.Name == name));
        }

        //
        // Summary:
        //  Remove all entries from the scraping sources list
        //
        public void ClearScrapeSources()
        {
            _scrapeSources.Clear();
        }

        //
        // Summary:
        //     Retrieve the list of scraping sources
        //
        // Result type:
        //   List<ScrapeSource>:
        //     A list of scraping sources.
        public List<ScrapeSource> GetScrapeSources()
        {
            return _scrapeSources;
        }

        //
        // Summary:
        //     Retrieve the list of scraping results
        //
        // Result type:
        //   List<ScrapeResults>:
        //     A list of scraping results.
        public List<ScrapeResults> GetScrapeResults()
        {
            return _scrapeResults;
        }

        //
        // Summary:
        //     Retrieve duration of latest scraping process
        //
        // Result type:
        //   TimeSpan:
        //     The duration of the last scraping process
        public TimeSpan GetScrapeDuration()
        {
            return _scrapeDuration;
        }

        //
        // Summary:
        //     Populate the scraping sources list from a file
        //
        // Parameters:
        //   IFormFile:
        //     The CSV file to populate the scraping sources list
        //
        public void ParseFile(IFormFile file)
        {
            TextReader reader = new StreamReader(file.OpenReadStream());
            var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            {
                TrimOptions = CsvHelper.Configuration.TrimOptions.Trim
            };
            CsvReader csvReader = new CsvReader(reader, config);
            _scrapeSources = csvReader.GetRecords<ScrapeSource>().ToList();
        }

        //
        // Summary:
        //    Retrieve HTML source of each website in the scraping sources list
        //    Populate the scraping results list with the relevant responses
        //
        public async Task GoScrapeTheWebAsync()
        {
            HttpClient client = new HttpClient();
            Stopwatch scrapeTimer = Stopwatch.StartNew();

            // Build a list of tasks to fetch the markup for each URL
            var requests = _scrapeSources.Select(item =>
            {
                return Task.Run(async () => {
                  var stopWatch = Stopwatch.StartNew();
                  HttpResponseMessage result;
                  try
                  {
                      result = await client.GetAsync(String.Concat(Constants.HTTP_PRESCRIPT, item.Website));
                  }
                  catch (Exception err)
                  {
                    Console.WriteLine(err.ToString());
                    result = new HttpResponseMessage();
                  }
                  return new Tuple<string, string, HttpResponseMessage, TimeSpan>(item.Name, item.Website, result, stopWatch.Elapsed);
              });
            }).ToList();

            // Wait for all the requests to finish
            await Task.WhenAll(requests);

            // Get the responses
            var responses = requests.Select
                (
                    task => task.Result
                );

            // Populate scraping result list 
            _scrapeResults = new List<ScrapeResults>();
            foreach (var r in responses)
            {
                // Extract the message body as text
                var s = await r.Item3.Content.ReadAsStringAsync();
                _scrapeResults.Add(new ScrapeResults()
                {
                    Name = r.Item1,
                    Website = r.Item2,
                    HasGoogle = s.Contains(Constants.GOOGLE_SEARCH_STRING),
                    ScanDuration = r.Item4
                });
            }
            _scrapeDuration = scrapeTimer.Elapsed;
        }
    }
}

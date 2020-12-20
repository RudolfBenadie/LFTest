using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace LFTest.Domain
{
    //
    // Summary:
    //     The ScraperEntity provides the implementation of data structures and functions to manage the scraping of a list of websites.
    //
    public interface IScraperEntity
    {
        //
        // Summary:
        //  Remove an entry from the scraping sources list using the index
        //
        // Parameters:
        //  int:
        //    The index of the item to be removed from the scraping source list
        //
        void RemoveWebsiteFromScrapeSourcesAt(int index);


        //
        // Summary:
        //  Remove an entry from the scraping sources list using the name of an entry
        //
        // Parameters:
        //  string:
        //    The name of the entry to be removed from the scraping source list
        //
        void RemoveWebsiteFromScrapeSourcesByName(string name);

        //
        // Summary:
        //  Remove all entries from the scraping sources list
        //
        void ClearScrapeSources();

        //
        // Summary:
        //     Retrieve the list of scraping sources
        //
        // Result type:
        //   List<ScrapeSource>:
        //     A list of scraping sources.
        List<ScrapeSource> GetScrapeSources();

        
        void SetScrapeSources(List<ScrapeSource> scrapeSources);

        //
        // Summary:
        //     Retrieve the list of scraping results
        //
        // Result type:
        //   List<ScrapeResults>:
        //     A list of scraping results.
        List<ScrapeResults> GetScrapeResults();

        //
        // Summary:
        //     Retrieve duration of latest scraping process
        //
        // Result type:
        //   TimeSpan:
        //     The duration of the last scraping process
        TimeSpan GetScrapeDuration();

        //
        // Summary:
        //     Populate the scraping sources list from a file
        //
        // Parameters:
        //   IFormFile:
        //     The CSV file to populate the scraping sources list
        //
        void ParseFile(IFormFile file);

        //
        // Summary:
        //    Retrieve HTML source of each website in the scraping sources list
        //    Populate the scraping results list with the relevant responses
        //
        Task GoScrapeTheWebAsync();
    }
}

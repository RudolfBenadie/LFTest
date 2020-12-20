using LFTest.Domain;
using LFTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace LFTest.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private IScraperEntity _scraper;

    public HomeController(ILogger<HomeController> logger, IScraperEntity scraper)
    {
      _logger = logger;
      _scraper = scraper;
    }

    //
    // Summary:
    //  Default handler for incoming GET requests
    //
    // Returns
    //  IActionResult
    //    Response with home view model
    //
    public IActionResult Index()
    {
      HomeViewModel homeViewModel = new HomeViewModel();
      return View(homeViewModel);
    }

    //
    // Summary:
    //  Handler for all incoming POST requests
    //
    // Parameters:
    //  IFormCollection: Form data sent in request body of POST method
    //
    // Returns
    //  Task<IActionResult>
    //    Response with updated homr view model
    //
    [HttpPost]
    public async Task<IActionResult> IndexAsync(IFormCollection form)
    {
      // Initialise view model and scraper entity
      HomeViewModel homeViewModel = new HomeViewModel();
      string scraperString = HttpContext.Session.GetString(Constants.SESSION_KEY_SCRAPER);
      if (!String.IsNullOrEmpty(scraperString)) {
        _scraper.SetScrapeSources(JsonSerializer.Deserialize<List<ScrapeSource>>(scraperString));
      }
      
      // Get and evaluate the action from the button that was pressed on the web page
      var action = form.ToList()[0];
      switch (action.Value)
      {
        case Constants.FORM_ACTION_DELETE:
          _scraper.RemoveWebsiteFromScrapeSourcesAt(int.Parse(action.Key));
          break;

        case Constants.FORM_ACTION_DELETE_ALL:
          _scraper.ClearScrapeSources();
          break;

        case Constants.FORM_ACTION_PROCESS:
          await _scraper.GoScrapeTheWebAsync();
          break;

        default:
          break;
      }

      // Process the file received in the request if any file has been uploaded
      if (form.Files.Count > 0)
      {
        _scraper.ParseFile(form.Files[0]);
      }

      //Update current state of the view model and session
      HttpContext.Session.SetString(Constants.SESSION_KEY_SCRAPER, JsonSerializer.Serialize(_scraper.GetScrapeSources()));
      homeViewModel.ScrapeSourcesList = _scraper.GetScrapeSources();
      homeViewModel.ScrapeResultsList = _scraper.GetScrapeResults();
      homeViewModel.ScrapeDuration = _scraper.GetScrapeDuration();

      return View(homeViewModel);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using leagueChampionStats.DataAccessLayer;
using leagueChampionStats.Models;

namespace leagueChampionStats.Controllers
{
    public class ChampionsController:Controller
    {
        public ChampionsController ()
        {
        }

        public IActionResult Champions()
        {
            championContext context = new championContext();
           
            return View(context);
        }

         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
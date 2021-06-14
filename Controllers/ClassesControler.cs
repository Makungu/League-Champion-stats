using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using leagueChampionStats.Models;


namespace leagueChampionStats.Controllers
{
    public class ClassesController: Controller
    {
        
        public ClassesController()
        {

        }
        public IActionResult Classes()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
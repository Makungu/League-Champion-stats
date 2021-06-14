using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using leagueChampionStats.DataAccessLayer;
using leagueChampionStats.Models;


namespace leagueChampionStats.Controllers
{
    public class AddChampionController: Controller
    {
        
        public AddChampionController()
        {

        }

        public IActionResult Submit(string name, string role, string type, string region)
        {
            championContext context = new championContext();
            champion champ = new champion()
            {
                name = name,
                role = role,
                type = type,
                region = region
            };
            context.champions.Add(champ);
            context.SaveChanges();
            return View("AddChampion");
        }
        public IActionResult AddChampion()
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
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using leagueChampionStats.DataAccessLayer;
using leagueChampionStats.Models;
using System.Collections.Generic;

namespace leagueChampionStats.Controllers
{
    public class ChampionsController:Controller
    {
        public championContext context = new championContext();
        public List<champion> champs = new List<champion>{};
        public ChampionsController ()
        {
        }
        public IActionResult Submit(string search)
        {
             
            foreach(champion c in context.champions){
                if (c.type == search){
                    champs.Add(c);
                }
            }
            return View(champs);
        }
        public IActionResult Champions()
        {
            foreach(champion c in context.champions){
                champs.Add(c);
            }
            return View(champs);
        }

         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
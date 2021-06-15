using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using leagueChampionStats.DataAccessLayer;
using leagueChampionStats.Models;
using System;
using System.ComponentModel.DataAnnotations;


namespace leagueChampionStats.Controllers
{
    public class AddChampionController: Controller
    {
        
        public AddChampionController()
        {

        }

        public IActionResult Submit(champion champ)
        {
            if(ModelState.IsValid){
                championContext context = new championContext();
                context.champions.Add(champ);
                context.SaveChanges();
                
            }
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
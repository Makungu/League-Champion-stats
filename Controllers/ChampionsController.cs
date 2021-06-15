using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using leagueChampionStats.DataAccessLayer;
using leagueChampionStats.Models;
using System.Collections.Generic;
using System;

namespace leagueChampionStats.Controllers
{
    public class ChampionsController:Controller
    {
        championContext context = new championContext();
        List<champion> champs = new List<champion>();

        public ChampionsController ()
        {
        }
        public IActionResult Submit(string search)
        {
            champs.Clear();
            foreach(champion c in context.champions){
                if (c.type == search)
                {
                    champs.Add(c);
                }
                
            }
            return View("Champions", champs);
        }

        public IActionResult Champions()
        {  
            champs.Clear();
            foreach(champion c in context.champions){
                champs.Add(c);                
            }
            return View("Champions", champs);
        }

         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
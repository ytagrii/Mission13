using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission13.Models;

namespace Mission13.Controllers
{
    public class HomeController : Controller
    {
        //bring in repositories for bowler and team
        private IBowlerRepository repoBowler { get; set; }
        private ITeamRepo repoTeam { get; }

        public HomeController(IBowlerRepository temp, ITeamRepo temp1)
        {
            repoBowler = temp;
            repoTeam = temp1;
        }

        //index page
        public IActionResult Index(int team = 0)
        {
            ViewBag.Teams = repoTeam.Teams.ToList();
            if (team == 0)
            {
                ViewBag.Team = null;
                var bowlers = repoBowler.Bowlers.ToList();
                return View(bowlers);
            }
            else
            {
                var temp = repoTeam.Teams.FirstOrDefault(x => x.TeamID == team);
                ViewBag.Team = temp.TeamName;
                var bowlers = repoBowler.GetAll(team);
                return View(bowlers);
            }  
            
        }

        //edit pages below
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Teams = repoTeam.Teams.ToList();
            var bowler = repoBowler.Bowlers.FirstOrDefault(x => x.BowlerID == id);
            return View(bowler);
        }

        [HttpPost]
        public IActionResult Edit(Bowler b)
        {
            if (ModelState.IsValid)
            {
                repoBowler.UpdateBowler(b);
                return RedirectToAction("Index");
            }
            ViewBag.Teams = repoTeam.Teams.ToList();
            return View(b);
        }

        //add pages below
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Teams = repoTeam.Teams.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Bowler b)
        {
            if (ModelState.IsValid)
            {
                repoBowler.AddBowler(b);
                return RedirectToAction("Index");
            }

            ViewBag.Teams = repoTeam.Teams.ToList();
            return View(b);
        }

        //delte pages below
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var bowler = repoBowler.Bowlers.FirstOrDefault(x => x.BowlerID == id);
            return View(bowler);
        }

        [HttpPost]
        public IActionResult Delete(Bowler b)
        {
            repoBowler.DeleteBowler(b);
            return RedirectToAction("Index");
        }

    }
}

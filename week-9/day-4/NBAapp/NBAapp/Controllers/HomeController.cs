﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NBAapp.Models;
using NBAapp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NBAapp.Controllers
{
    public class HomeController : Controller
    {
        Team team;
        NBARepository NBARepository;

        public HomeController(Team team, NBARepository nBARepository)
        {
            NBARepository = nBARepository;
            this.team = team;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            var team = new Team()
            {
                Name = "Green Foxes",
                Fundation = 2015
            };

            return View(team);
        }

        [HttpPost]
        [Route("teaminfo")]
        public IActionResult TeamInfo()
        {
            return RedirectToAction("teaminfo");
        }

        [HttpGet]
        [Route("teaminfo")]
        public IActionResult TeamInformation()
        {
            return View(NBARepository.GetTeam());
        }

        [Route("/teaminfo/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View(new Player());
        }

        [Route("/teaminfo/add")]
        [HttpPost]
        public IActionResult Add(Player player)
        {
            NBARepository.AddPlayer(player);
            return RedirectToAction("TeamInformation");
        }

        [Route("/{name}/delete")]
        [HttpPost]
        public IActionResult Delete(string name)
        {
            NBARepository.DeletePlayer(name);
            return RedirectToAction("TeamInformation");
        }
    }
}

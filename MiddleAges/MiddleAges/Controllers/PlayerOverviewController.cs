﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiddleAges.Data;
using MiddleAges.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleAges.Controllers
{
    public class PlayerOverviewController : Controller
    {
        private readonly ILogger<PlayerOverviewController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Player> _userManager;
        public PlayerOverviewController(ILogger<PlayerOverviewController> logger,
                                        ApplicationDbContext context,
                                        UserManager<Player> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }
        // GET: PlayerOverviewController
        public ActionResult Index()
        {
            Player player = _userManager.GetUserAsync(HttpContext.User).Result;
            return View("_PlayerOverviewPartial", player);
        }
        // GET: PlayerOverviewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: PlayerOverviewController/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: PlayerOverviewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: PlayerOverviewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        // POST: PlayerOverviewController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: PlayerOverviewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        // POST: PlayerOverviewController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

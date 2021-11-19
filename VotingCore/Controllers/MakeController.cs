using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingCore.AppDbContext;
using VotingCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace VotingCore.Controllers
{
    [Authorize(Roles = "Admin")]
   
    public class MakeController : Controller
    {
        public readonly UserManager<ApplicationUser> userManager;
        private readonly EVotingDbContext _db;
       
        public MakeController(EVotingDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            this.userManager = userManager;
        }
        public IActionResult Index()

        {
            var users = userManager.Users;

            return View(_db.Users.ToList());
           
        }
        //get mothod
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Voters make)
        {
            if (ModelState.IsValid)
            {
                _db.Add(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);

        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var v = _db.Voters.Find(id);
            if (v == null)
            {
                return NotFound();
            }
            _db.Voters.Remove(v);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var v = _db.Voters.Find(id);
            if (v == null)
            {
                return NotFound();
            }
           
            return View(v);
        }
        [HttpPost]
        public IActionResult Edit(Voters make)
        {
            if (ModelState.IsValid)
            {
                _db.Update(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);

        }


    }
}

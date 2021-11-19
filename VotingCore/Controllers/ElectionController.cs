using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingCore.AppDbContext;
using VotingCore.Models;
namespace VotingCore.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ElectionController : Controller
    {
        private readonly EVotingDbContext _db1;
        public ElectionController(EVotingDbContext db)
        {
            _db1 = db;
        }
        public IActionResult Index()
        {
            return View(_db1.Elections.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Elections make)
        {
            if (ModelState.IsValid)
            {
                _db1.Add(make);
                _db1.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);

        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var v = _db1.Elections.Find(id);
            if (v == null)
            {
                return NotFound();
            }
            _db1.Elections.Remove(v);
            _db1.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var v = _db1.Elections.Find(id);
            if (v == null)
            {
                return NotFound();
            }

            return View(v);
        }
        [HttpPost]
        public IActionResult Edit(Elections make)
        {
            if (ModelState.IsValid)
            {
                _db1.Update(make);
                _db1.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);

        }
    }
}

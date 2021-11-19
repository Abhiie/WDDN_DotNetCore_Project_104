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
    [Authorize(Roles ="Admin")]
    public class CandidateController : Controller
    {
        private readonly EVotingDbContext _db2;
        public CandidateController(EVotingDbContext db)
        {
            _db2 = db;
        }
        public IActionResult Index()
        {
            return View(_db2.Candidates.ToList());
        }
        [HttpGet]
       
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Candidate make)
        {
            if (ModelState.IsValid)
            {
                _db2.Add(make);
                _db2.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);

        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var v = _db2.Candidates.Find(id);
            if (v == null)
            {
                return NotFound();
            }
            _db2.Candidates.Remove(v);
            _db2.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var v = _db2.Candidates.Find(id);
            if (v == null)
            {
                return NotFound();
            }

            return View(v);
        }
        [HttpPost]
        public IActionResult Edit(Candidate make)
        {
            if (ModelState.IsValid)
            {
                _db2.Update(make);
                _db2.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(make);

        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingCore.AppDbContext;
using VotingCore.Models;

namespace VotingCore.Controllers
{
    [Authorize]
    public class ElectionCandidateController : Controller
    {
        private readonly EVotingDbContext _db;
        public ElectionCandidateController(EVotingDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            return View(_db.Candidates.ToList());

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(VotedInfo result,int id)
        {
            if(ModelState.IsValid)
            {
                string data = TempData["mydata"] as string;
                int i = 1;
                var v = _db.Candidates.Find(id);
                if (v == null)
                {
                    return NotFound();
                }
                result.VoterEmailId = data;
                result.CandidateId = v.Id;
                result.CandidateName = v.CandidateName;
                result.CandidateNumber = v.CandidateNumber;
                result.Id = i;
                ViewBag.IsSuccess1 = true;
                _db.VotedInfos.Add(result);



                _db.SaveChanges();

            }


          return View(result);
           // return RedirectToAction("Index", "Home");

        }
        
       
    }
}

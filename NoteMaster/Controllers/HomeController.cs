using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteMaster.Data;
using NoteMaster.Models;
using NoteMaster.ViewModels;

namespace NoteMaster.Controllers
{
    public class HomeController : Controller
    {


        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext dbContext)
        {
            this.context = dbContext;
        }

        public IActionResult Index()
        {
            IndexViewModel indexViewModel = new IndexViewModel();

            return View(indexViewModel);
        }

        public IActionResult Error()
        {

            return View();
        }

        public IActionResult Result()
        {
            ResultViewModel resultViewModel = new ResultViewModel();

            resultViewModel.Error = "To add a new note, please return to the 'Add' page.";

            List<Note> TheList = context.Notes.ToList();

            List<Note> OrdList = TheList.OrderByDescending(o => o.Rating).ToList();

            resultViewModel.Noteslist = OrdList;

            return View(resultViewModel);
        }

        [HttpPost]
        public IActionResult Result(ResultViewModel resultViewModel)



        {
            if (ModelState.IsValid)
            {

                if ((resultViewModel.Rating > 0) & (resultViewModel.Rating < 6)){ 


                List<Note> TheList = context.Notes.ToList();

                Note Note = new Note(resultViewModel.Thenote, resultViewModel.Rating);

                context.Notes.Add(Note);
                TheList.Add(Note);

                context.SaveChanges();

                List<Note> OrdList = TheList.OrderByDescending(o => o.Rating).ToList();

                    resultViewModel.Noteslist = OrdList;

                return View(resultViewModel);

            }
            }

            return Redirect("/Home/Error");

        }

        public IActionResult Delete() { 
        

            List<Note> TheList = context.Notes.ToList();
            foreach (Note elem in TheList)
            {
                context.Remove(elem);

            }

            context.SaveChanges();

            return Redirect("/");
        }

        [HttpGet]
        public IActionResult Remove()
        {
            List<Note> TheList = context.Notes.ToList();

            if (TheList.Count > 0)
            {
                RemoveViewModel removeViewModel = new RemoveViewModel();

                removeViewModel.TheList = TheList;

                return View(removeViewModel);
            }

            else
            {
                return Redirect("/");
            }
        }

        [HttpPost]
        public IActionResult Remove(RemoveViewModel removeViewModel)

        {
            List<Note> TheList = context.Notes.ToList();

            if (ModelState.IsValid)
            {

                Note remelem = context.Notes.Single(c => c.ID == removeViewModel.NewElement1);
                context.Notes.Remove(remelem);
                context.SaveChanges();

                return Redirect("/Home/Result");
            }

            return Redirect("/Home/Error");

        }





    }



}

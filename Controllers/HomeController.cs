using Microsoft.AspNetCore.Mvc;
using Odev.Models;
using System.Collections.Generic;



namespace Odev.Controllers
{
     public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //using var db = new TodoAppContext();
            return View(); 
        
        
        } 
        public IActionResult Listele()
        {
            var db = new TodoAppContext();
            List<Todo> todos = db.Todos.ToList(); 
            ViewBag.Todo = todos;
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Todo t)
        {
            var db = new TodoAppContext();
            db.Todos.Add(t);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
        [HttpPost]
        public IActionResult Duzenle(Todo D)
        {
            var db = new TodoAppContext();
            Todo KL = db.Todos.FirstOrDefault(x => x.Id == D.Id);
            KL.Title = D.Title;
            KL.Description = D.Description;
            db.SaveChanges();
            return RedirectToAction("Listele");
        }



        public ActionResult Sil(int Id)
        {
            using var db = new TodoAppContext();
            Todo silinecek = db.Todos.FirstOrDefault(x => x.Id == Id);
            db.Todos.Remove(silinecek);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }

    }
    }


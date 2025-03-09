using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demirler.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            var values = bm.GetList();
            return View(values);
        }


        public IActionResult BlogDetails(int id)
        {
            var value = bm.GetBlogById(id); // Tek bir blog döndürmeli
            return View(value);
        }

        [HttpGet]
        public IActionResult Admin()
        {
            var values = bm.GetList();
            return View(values);
            return View();
        }

        [HttpPost]
        public IActionResult Admin(Blog model)
        {
            
             bm.BlogAdd(model);  // Blog verisini ekleme işlemi yapılıyor
            return RedirectToAction("Admin");
            ;// return RedirectToAction("Index"); // Başarılıysa anasayfaya yönlendir
        }


    

        public IActionResult Delete(int id)
        {
            var blog = bm.GetBlogById(id);
            bm.BlogDelete(blog);
            return RedirectToAction("Admin");
        }

        public IActionResult Deneme()
        {
            
            return View();
        }

    }
}


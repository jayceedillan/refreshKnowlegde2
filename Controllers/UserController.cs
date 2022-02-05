using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using core.Models;

namespace core.Controllers;

public class UserController : Controller
{

    private readonly ApplicationDBContext dbContext;
    public UserController(ApplicationDBContext db)
    {
        dbContext = db;
    }
    public IActionResult Index()
    {

        var user = new UserViewModel { id = 1, Name = "jessie" };

        // var user = new UserViewModel(
        //     {
        //         new UserViewModel {
        //             id = 1,
        //             Name= "xxx"
        //         }
        //     }
        // )
        return View(user);
    }

    [HttpPost]
    public IActionResult Create(UserViewModel userViewModel)
    {
        Console.WriteLine("test");
        if (ModelState.IsValid)
        {
            // schoolContext.Teacher.Add(teacher);  
            // schoolContext.SaveChanges();  
            Console.WriteLine("test");
            return RedirectToAction("Index");
        }
        else
            return View();
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using core.Models;
using core.IRepository;

namespace core.Controllers;

public class ProfileController : Controller
{

    readonly IProfileRepository iProfileRepository;

    public ProfileController(IProfileRepository _iProfileRepository)
    {
        iProfileRepository = _iProfileRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
    public IActionResult List()
    {
        var profileList = iProfileRepository.getAll();
        return View(profileList);
    }

    public IActionResult Edit(int id)
    {
        var profile = iProfileRepository.get(id);
        return View(profile);
    }

    public IActionResult Delete(int id)
    {
        var profile = iProfileRepository.delete(id);
        return RedirectToAction("List");
    }


    [HttpPost]
    public IActionResult Create(ProfileViewModel ProfileViewModel)
    {
        if (ModelState.IsValid)
        {
            iProfileRepository.addOrUpdae(ProfileViewModel);
            return RedirectToAction("List");
        }
        else
            return View();
    }
}

using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController: Controller{    
    //parametre olan int id program.cs de route tipinde yazan id'dir. id yerine key olsaydı burada da prmtre olarak key yazardık.
    public IActionResult Details(int? id){
        
        if(id==null){
            return RedirectToAction("List","Course");
        }
        var kurs = Repository.GetById(id);
        return View(kurs);
    }
    public IActionResult List(){

        return View("List", Repository.Courses);
    }

}
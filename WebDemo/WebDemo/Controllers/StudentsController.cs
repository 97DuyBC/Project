using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDemo.Business.Students;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        new StudentsDAO StDao = new StudentsDAO(); 

        [HttpPost]
        public ActionResult jsonListStudent()
        {

            return Json(new {
                Data = StDao.getAllStudents(),
        });
        }

        public ActionResult jsonSaveStudent(Student st)
        {
            String mes;
            if(StDao.saveStudent(st)== true)
            {
                mes = "Success";
            }
            else{
                mes = "Fall";
            }
            return Json(new{ mes = mes});
        }
    }
}
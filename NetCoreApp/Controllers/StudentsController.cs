using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreBusiness;

namespace NetCoreApp.Controllers
{
    public class StudentsController : Controller
    {
        private StudentBusiness _studentBusiness;
        public StudentsController(StudentBusiness studentBusiness)
        {
            _studentBusiness = studentBusiness;
        }
        //GET: /Students/
        public IActionResult Index()
        {
            var students = _studentBusiness.GetStudents();
            return View(students);
        }
        //GET: /Students/detail/1
        public IActionResult Details(int id)
        {
            var student = _studentBusiness.GetStudentById(id);
            return View(student);
        }
    }
}
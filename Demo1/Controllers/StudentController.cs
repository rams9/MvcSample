using Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            var studentList = new List<Student>
            {
                new Student() { StudentId=1,StudentName="Ram",Age=22  },
                new Student() { StudentId=2,StudentName="Surya",Age=29 },
                new Student() { StudentId=3,StudentName="Ashesh",Age=28},
                new Student() { StudentId=4,StudentName="Ravi",Age=23},
                new Student() { StudentId=5,StudentName="Ravi",Age=29 },
                new Student() { StudentId=6,StudentName="Ashesh",Age=28},
                new Student() { StudentId=7,StudentName="Ravi",Age=23}
            };

            return View(studentList);
        }

  
   
    }
}
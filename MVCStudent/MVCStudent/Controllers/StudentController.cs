using MVCStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStudent.Controllers
{
    public class StudentController : Controller
    {
        List<Student> studentList;
        // GET: Student
        public ActionResult Index()
        {
             studentList = new List<Student>()
            {
                new Student{StudentId=1, StudentName="John", Age=18},
                new Student{StudentId=1, StudentName="Steve", Age=21},
                new Student{StudentId=1, StudentName="Bill", Age=25},
                new Student{StudentId=1, StudentName="Ram", Age=20},
                new Student{StudentId=1, StudentName="Ron", Age=31},
                new Student{StudentId=1, StudentName="Chirs", Age=17},
                new Student{StudentId=1, StudentName="Rob", Age=19},
                new Student{StudentId=1, StudentName="Mary", Age=18}


            };
            return View(studentList);
        }

        [HttpGet]
        public ActionResult Edit (int id)
        {
            studentList = new List<Student>()
            {
                new Student{StudentId=1, StudentName="John", Age=18},
                new Student{StudentId=1, StudentName="Steve", Age=21},
                new Student{StudentId=1, StudentName="Bill", Age=25},
                new Student{StudentId=1, StudentName="Ram", Age=20},
                new Student{StudentId=1, StudentName="Ron", Age=31},
                new Student{StudentId=1, StudentName="Chirs", Age=17},
                new Student{StudentId=1, StudentName="Rob", Age=19},
                new Student{StudentId=1, StudentName="Mary", Age=18}


            };
            var std = (from a in studentList
                      where a.StudentId == id
                      select a).FirstOrDefault();
            //var std1 = studentList.Where(x => x.StudentId == id).FirstOrDefault();
            return View(std);
        }
        [HttpPost]
        public ActionResult Edit (Student std)
        {
            if (ModelState.IsValid)
                //napiši kodo za update baze
                return RedirectToAction("Index");
            else
                return View(std);
        }
        public ActionResult TestRazorja()
        {
            Student s = new Student();
            s.Age = 19;
            s.StudentId = 9;
            s.StudentName = "Miha Kovač";
            return View(s);
        }
    }
}
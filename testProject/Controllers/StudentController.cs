using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testProject.Controllers
{
    using testProject.BusinessLogic.Core;
    using testProject.Models;

    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        //
        // GET: /Student/

        public ActionResult Index()
        {
            var studentsList = studentRepository.GetAllStudents();
            var model = studentsList.Select(student => new IndexStudentModel { Id = student.Id, Name = student.Name, AverageMark = student.AverageMark }).ToList();
            return View(model);
        }
       
    }
}

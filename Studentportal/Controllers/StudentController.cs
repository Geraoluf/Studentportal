using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studentportal.Data;
using Studentportal.Models;
using Studentportal.Models.Entities;

namespace Studentportal.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        



        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student  //student-entity
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed,
            };
                
            await dbContext.Students.AddAsync(student);
            dbContext.SaveChanges();
            return View();
        }


        [HttpGet]
       public async Task <IActionResult> StudentListe()
        {
            var students = await dbContext.Students.ToListAsync();

            return View(students);

        }
    }
}

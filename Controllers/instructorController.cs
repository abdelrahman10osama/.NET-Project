using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models; 

namespace WebApplication2.Controllers
{
    [Authorize]
    public class instructorController : Controller
    {
        private readonly company Company;

        public instructorController(company company)
        {
            Company = company;
        }
        public IActionResult Index()
        {
            List<instructor> list = Company.Instructors.ToList();
            return View("ShowAll", list);
        }

        public IActionResult Detail(int Id)
        {
            List<instructor> list = Company.Instructors.Where(e => e.Id == Id).ToList();
            return View("detail", list);
        }
        public IActionResult New()
        {
            InstructorWithDept vm = new InstructorWithDept();

            vm.DepartmentList = Company.Departments.ToList();
            vm.courseList = Company.Courses.ToList();

            return View(vm);
        }

        [HttpPost]
        public IActionResult SaveNew(InstructorWithDept vm)
        {
            if (vm.EmpName != null)
            {
                instructor inst = new instructor();

                inst.Name = vm.EmpName;
                inst.Image = vm.Image;
                inst.Salary = vm.EmpSalary;
                inst.Adress = vm.Adress;
                inst.dept_id = vm.DepartmentId;
                inst.crs_id = vm.CourseId;

                Company.Instructors.Add(inst);
                Company.SaveChanges();

                return RedirectToAction("Index");
            }

            vm.DepartmentList = Company.Departments.ToList();
            vm.courseList = Company.Courses.ToList();

            return View("New", vm);
        }

    }
    
}
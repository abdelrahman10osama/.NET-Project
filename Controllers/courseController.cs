using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Models.Repository;

namespace WebApplication2.Controllers
{
    [Authorize]
    public class courseController : Controller
    {
        //company Company = new company();
        ICourseRepo crsRepo;
        IDepartmentRepo DeptRepo;

        public courseController(ICourseRepo crsRepo, IDepartmentRepo DeptRepo)
        {
            this.crsRepo = crsRepo;
            this.DeptRepo = DeptRepo;
        }

        public IActionResult Index()
        {
            return View("ShowAllcrs", crsRepo.GetAll());
        }

        public IActionResult Detail(int Id)
        {
            List<string> DeptList = DeptRepo.GetAll().Select(d => d.Name ).ToList();
            return View("detail", DeptList);
        }
        public IActionResult New()
        {
            coursewithDept vm = new coursewithDept();

            vm.DepartmentList = DeptRepo.GetAll();
            return View("New", vm);
        }

        [HttpPost]
        public IActionResult SaveNew(coursewithDept vm)
        {
            if (ModelState.IsValid == true)
            {
                course crs = new course()
                {
                    Name = vm.Name,
                    Degree = vm.Degree,
                    MinDegree = vm.MinDegree,
                    Hours = vm.Hours,
                    dept_id = vm.dept_id
                };

                crsRepo.Add(crs);
                crsRepo.Save();
                return RedirectToAction("Index");
            }

            return View("New", vm);
        }

        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("Name", "ITI Student");

            return Content("Session Saved");
        }

        public IActionResult GetSession()
        {
            string? name = HttpContext.Session.GetString("Name");

            return Content(name ?? "No Data");
        }
    }
}

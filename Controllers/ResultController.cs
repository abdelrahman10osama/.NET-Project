using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Authorize]
    public class ResultController : Controller
    {

        company context;

        public ResultController(company db)
        {
            context = db;
        }
        public IActionResult ViewResult(int tid,int cid)
        {
            crsResult result = context.CrsResult
                           .FirstOrDefault(r => r.trainee_id == tid && r.crs_id == cid);

            if (result == null)
            {
                return Content("Result Not Found");
            }

            trainee trainee = context.Trainees
                .FirstOrDefault(t => t.Id == tid);

            course course = context.Courses
                .FirstOrDefault(c => c.Id == cid);

            ResultVM vm = new ResultVM();

            vm.TraineeName = trainee.Name;
            vm.CourseName = course.Name;
            vm.Degree = result.Degree;

            if (result.Degree >= course.MinDegree)
            {
                vm.Status = "Success";
                vm.Color = "green";
            }
            else
            {
                vm.Status = "Fail";
                vm.Color = "red";
            }

            return View(vm);
        }
    }
}

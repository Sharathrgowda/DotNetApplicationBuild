using Microsoft.AspNetCore.Mvc;
using MVCCoreDemo.Data;
using MVCCoreDemo.Models;
using MVCCoreDemo.Service;

namespace MVCCoreDemo.Controllers
{
   /* [Route("sample")]*/
    public class EmployeeController : Controller
    {

        ApplicationDbContext dbContext;
        Login login;

        public EmployeeController(ApplicationDbContext dbcontext,Login _login)
        {

            dbContext = dbcontext;
            login = _login;
        }

        public IActionResult Index()
        {
            List<EmployeeData> employees = dbContext.EmployeeData.ToList();
            return View(employees);
        }

        public ActionResult Add()
        {
            List<DepartmentData> departments = dbContext.DepartmentData.ToList();
            ViewBag.Department = departments;
            return View();
        }
        [HttpPost]
        public ActionResult Add(EmployeeData emp)
        {
            dbContext.EmployeeData.Add(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            List<DepartmentData> department = dbContext.DepartmentData.ToList();
            ViewBag.Department = department;

            EmployeeData wmployee = dbContext.EmployeeData.Where(e => e.Employee_id == id).SingleOrDefault();
            return View(wmployee);
        }

        [HttpPost]
        public ActionResult update(EmployeeData emp)
        {
            EmployeeData employee = dbContext.EmployeeData.Find(emp.Employee_id);
            employee.Employee_id = emp.Employee_id;
            employee.Employee_Name = emp.Employee_Name;
            employee.Employee_Address = emp.Employee_Address;
            employee.Qualification = emp.Qualification;
            employee.Department_Id = emp.Department_Id;
            employee.SkillsSet = emp.SkillsSet;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult remove(int id)
        {
            EmployeeData employee = dbContext.EmployeeData.Find(id);
            dbContext.EmployeeData.Remove(employee);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Login()
        {
            return View();
        }


      /*  [HttpPost]
        public ActionResult Login(User user)
        {
            bool isvalidUser = login.validateUser(user.Email, user.Password);
            if(isvalidUser)
            {

                return RedirectToAction("Index", "Employee");

            }
            else
            {
                ViewBag.Message = "Authentication Failed";
                return RedirectToAction("Index", "Home");
            }
           
        }*/


    }

}

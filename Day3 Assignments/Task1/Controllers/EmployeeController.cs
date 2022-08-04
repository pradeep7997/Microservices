Using Microsoft.AspNetCore.Mvc;
Using WebApplication3.Repository;
Using WebApplication3.Models;
Namespace WebApplication3.Controllers
{
    Public Class EmployeeController :  Controller
    {
        IEmployeeRepo _repo;
        Public EmployeeController(IEmployeeRepo repo)
        {
            _repo = repo;
        }

        Public IActionResult Index()
        {
            List<Employee> Elist=_repo.GetAllDetails();
            
            Return View(Elist);
        }
        [HttpGet]
        Public IActionResult Create()
        {

            Return View();
        }

        [HttpPost]
        Public IActionResult Create(Employee obj)
        {
            _repo.AddEmp(obj);
            Return RedirectToAction("Index");
        }

        Public IActionResult Details(int id)
        {
            Employee obj = _repo.GetDetailsByID(id);
            Return View(obj);
        }


        [HttpGet]
        Public IActionResult Edit(int id)
        {
            Employee obj = _repo.GetDetailsByID(id);
            Return View(obj);
        }

        [HttpPost]
        Public IActionResult Edit(Employee obj)
        {
            _repo.UpdateEmp(obj);
            Return RedirectToAction("Index");
        }


        [HttpGet]
        Public IActionResult Delete(int id)
        {
            Employee obj = _repo.GetDetailsByID(id);
            Return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        Public IActionResult DeleteConfirm(int id)
        {
            _repo.DeleteEmp(id);
            Return RedirectToAction("Index");
        }

    }
}
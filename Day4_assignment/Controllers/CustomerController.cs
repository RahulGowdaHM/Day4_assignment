using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day4_assignment.Entities;
using Day4_assignment.Repositories;

namespace Day4_assignment.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository _repo = new CustomerRepository();
        [Route("GetAll")]
        public IActionResult Index()
        {
            List<Customer> list = _repo.GetAll();
            return View(list);
        }
        public IActionResult Details(string cid)
        {
            Customer c = _repo.GetEmployeeByID(cid);
            return View(c);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer c)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _repo.Add(c);
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Customer c)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _repo.Modify(c);
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Customer c)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _repo.Delete(c);
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }
    }
}

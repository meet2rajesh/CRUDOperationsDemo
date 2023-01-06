using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUDOperationsDemoApp.BO;
using CRUDOperationsDemoApp.Models;

namespace CRUDOperationsDemoApp.Controllers
{
    public class EmployeesController : Controller
    {

        EmployeeBO boEmp = new EmployeeBO();
        DepartmentBO boDept = new DepartmentBO();

        // GET: Employees
        public ActionResult Index()
        {
            return View(boEmp.GetAll());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee =boEmp.GetbyID(id.Value);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.DeptId = new SelectList(boDept.GetAll(), "DeptId", "DeptName");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Salary,DeptId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                boEmp.Add(employee);
                return RedirectToAction("Index");
            }

            ViewBag.DeptId = new SelectList(boDept.GetAll(), "DeptId", "DeptName", employee.DeptId);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = boEmp.GetbyID(id.Value);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.DeptId = new SelectList(boDept.GetAll(), "DeptId", "DeptName", employee.DeptId);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpId,Name,Salary,DeptId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                boEmp.Update(employee);
                return RedirectToAction("Index");
            }
            ViewBag.DeptId = new SelectList(boDept.GetAll(), "DeptId", "DeptName", employee.DeptId);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = boEmp.GetbyID(id.Value);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = boEmp.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                boEmp.Dispose();
                boDept.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

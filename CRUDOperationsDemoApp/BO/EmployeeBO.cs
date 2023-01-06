using CRUDOperationsDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace CRUDOperationsDemoApp.BO
{
    public class EmployeeBO: GenericBO<Employee>
    {

        //public getAllActiveEmplpoyee()
        //{
        //    return dbContext.Employees.Where(emp => emp.isActive == true);

        //}

        public IEnumerable<Employee> getAllActiveEmplpoyee(int deptId)
        {
            return dbContext.Employees.Where(emp => emp.DeptId == deptId);

        }

        //private EFDemoDbEntities db = new EFDemoDbEntities();

        //public IEnumerable<Employee> GetAll()
        //{
        //    var employees = db.Employees.Include(e => e.Department);
        //    return employees.ToList();

        //}

        //public Employee GetbyID(int id)
        //{
        //   Employee employee = db.Employees.Find(id);
        //   return employee;

        //}
        //public Employee Add(Employee emp)
        //{
        //    db.Employees.Add(emp);
        //    db.SaveChanges();
        //    return emp;
        //}

        //public void Update(Employee emp)
        //{
        //    db.Entry(emp).State = EntityState.Modified;
        //    db.SaveChanges();
        //}

        //public Employee Delete(int id)
        //{
        //    Employee emp = db.Employees.Find(id);
        //    if(emp== null)
        //    {
        //        return null;

        //    }
        //    db.Employees.Remove(emp);
        //    db.SaveChanges();
        //    return emp;

        //}
        //public Employee Delete(Employee emp)
        //{
        //    db.Employees.Remove(emp);
        //    db.SaveChanges();
        //    return emp;
        //}

        //public void Dispose()
        //{
        //    db.Dispose();
        //}





    }
}
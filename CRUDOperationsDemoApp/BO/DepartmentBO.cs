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
    public class DepartmentBO: GenericBO<Department>
    {
        //private EFDemoDbEntities db = new EFDemoDbEntities();

        //public IEnumerable<Department> GetAll()
        //{
        //    return db.Departments.ToList();
            
        //}

        //public Department GetbyID(int id)
        //{
        //    Department department = db.Departments.Find(id);
        //    return department;

        //}
        //public Department Add(Department dept)
        //{
        //    db.Departments.Add(dept);
        //    db.SaveChanges();
        //    return dept;
        //}

        //public void Update(Department dept)
        //{
        //    db.Entry(dept).State = EntityState.Modified;
        //    db.SaveChanges();
        //}

        //public Department Delete(int id)
        //{
        //    Department dept = db.Departments.Find(id);
        //    if (dept == null)
        //    {
        //        return null;

        //    }
        //    db.Departments.Remove(dept);
        //    db.SaveChanges();
        //    return dept;

        //}
        //public Department Delete(Department dept)
        //{
        //    db.Departments.Remove(dept);
        //    db.SaveChanges();
        //    return dept;
        //}

        //public void Dispose()
        //{
        //    db.Dispose();
        //}

     
    }
}
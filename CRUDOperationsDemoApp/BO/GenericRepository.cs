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
    public class GenericBO<T> : IDisposable where T:class
    {

        protected EFDemoDbEntities dbContext = new EFDemoDbEntities();

        DbSet<T> dbset;

        public GenericBO()
        {
            dbset = dbContext.Set<T>();

        }
        public virtual IEnumerable<T> GetAll()
        {
           return dbset.ToList();

        }

        public virtual T GetbyID(int id)
        {
            T employee = dbset.Find(id);
            return employee;

        }
        public virtual T Add(T emp)
        {
            dbset.Add(emp);
            dbContext.SaveChanges();
            return emp;
        }

        public virtual void Update(T emp)
        {
            dbContext.Entry(emp).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public virtual T Delete(int id)
        {
            T emp = dbset.Find(id);
            if (emp == null)
            {
                return null;

            }
            dbset.Remove(emp);
            //dbContext.Employees.Remove(emp);
            dbContext.SaveChanges();
            return emp;

        }
        public virtual T Delete(T emp)
        {
            dbset.Remove(emp);
            dbContext.SaveChanges();
            return emp;
        }

        public void Dispose()
        {
            //DbContext.Dispose();
        }
    }
}
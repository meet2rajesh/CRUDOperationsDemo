using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDOperationsDemoApp.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }


    }

    public class EFDemoDbEntities : DbContext
    {
       public DbSet<Employee> Employees { get; set; }
      

    }

}

        
    

    

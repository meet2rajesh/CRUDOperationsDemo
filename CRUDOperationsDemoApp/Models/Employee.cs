using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public int DeptId { get; set; }
         
        [ForeignKey("DeptId")]
        public virtual Department Department { get; set; }

    }

    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }

    }

    public class EFDemoDbEntities : DbContext
    {
       public DbSet<Employee> Employees { get; set; }
       
       public DbSet<Department> Departments { get; set; }


    }

}

        
    

    

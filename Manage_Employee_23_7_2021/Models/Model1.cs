namespace Manage_Employee_23_7_2021.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public System.Data.Entity.DbSet<Models.Project> Projects { get; set; }

        public System.Data.Entity.DbSet<Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<Models.AssignTask> AssignTasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

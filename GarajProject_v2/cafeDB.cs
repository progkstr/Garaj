namespace GarajProject_v2
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class cafeDB : DbContext
    {
        
        public cafeDB()
            : base("name=cafeDB")
        {
        }

        //public virtual DbSet<Change> Changes { get; set; }
        //public virtual DbSet<Client> Clients { get; set; }
        //public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        //public virtual DbSet<Table> Tables { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }    
}
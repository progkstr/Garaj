using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;


namespace GarajProject_v2
{
    public class ContextInitializer : DropCreateDatabaseAlways<cafeDB>
    {
        protected override void Seed(cafeDB db)
        {
            Person ad = new Person { Name = "Koleskin Mihail Aleksandrovich", Adres = "kostroma, dimitrova 1|2", Phone = "79977782211", ClientID = null, EmployeeID = null }; //добавляем человека 
            Employee ad_e = new Employee { PersonID = ad.ID, Position = "Host", ChngeID = null, Person = ad };
            db.Persons.Add(ad);
            db.Employees.Add(ad_e);
            db.SaveChanges();
            
        }
    }
}

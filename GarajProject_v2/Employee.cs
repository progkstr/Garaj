using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace GarajProject_v2
{
    public class Employee : BaseEntity
    {
        public string Position { get; set; }
        public Person person { get; set; }

        public Change change { get; set; }

        public Employee()
        { }

        //public Change c_host { get; set; }
        //public Change c_adminisstrator { get; set; }
        //public Change c_barista { get; set; }
        //public Change c_povar { get; set; }
        //public Change c_oficiant1 { get; set; }
        //public Change c_oficiant2 { get; set; }
        //public Change c_hostes { get; set; }
    }
}

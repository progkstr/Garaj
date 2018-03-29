using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace GarajProject_v2
{
    public class Change : BaseEntity
    {
        
        public string Adres { get; set; }
        public Nullable<System.DateTime> Date_in { get; set; }
        public Nullable<System.DateTime> Date_out { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Table> Tables { get; set; }

        public Change()
        {
            Tables = new List<Table>();
            Employees = new List<Employee>();
        }
    }
}

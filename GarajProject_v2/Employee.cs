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
        public int? PersonID { get; set; }
        public int? ChngeID { get; set; }

        public virtual Person Person { get; set; }
        public virtual Change Change { get; set; }

        public Employee()
        {
        }
    }
}

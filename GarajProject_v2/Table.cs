using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace GarajProject_v2
{
    public class Table : BaseEntity
    {
        public int? Number_table { get; set; }
        public Nullable<System.DateTime> Date_in { get; set; }
        public Nullable<System.DateTime> Date_out { get; set; }
        public int? Number_seat { get; set; }
        
        public int? ClientID { get; set; }
        public int? ChangeID { get; set; }

        public virtual Change Change { get; set; }
        public virtual Client Client { get; set; }
    }
}

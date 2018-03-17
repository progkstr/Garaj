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

        public int Client { get; set; }
        public int Number_table { get; set; }
        public System.DateTime Date_in { get; set; }
        public Nullable<System.DateTime> Date_out { get; set; }
        public int Number_seat { get; set; }
        public int Id_Change { get; set; }

        public Change change { get; set; }
        public Client client { get; set; }
    }
}

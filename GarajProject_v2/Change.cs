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

        [ForeignKey("Employee")]
        public Nullable<int> Host { get; set; }
        [ForeignKey("Employee")]
        public Nullable<int> Administrator { get; set; }
        [ForeignKey("Employee")]
        public Nullable<int> Barista { get; set; }
        [ForeignKey("Employee")]
        public Nullable<int> Povar { get; set; }
        [ForeignKey("Employee")]
        public Nullable<int> Oficiant1 { get; set; }
        [ForeignKey("Employee")]
        public Nullable<int> Oficiant2 { get; set; }
        [ForeignKey("Employee")]
        public Nullable<int> Hostes { get; set; }

        public Employee host { get; set; }
        public Employee adminisstrator { get; set; }
        public Employee barista { get; set; }
        public Employee povar { get; set; }
        public Employee oficiant1 { get; set; }
        public Employee oficiant2 { get; set; }
        public Employee hostes { get; set; }

        public ICollection<Table> tables { get; set; }

        public Change()
        {
            tables = new List<Table>();
        }
    }
}

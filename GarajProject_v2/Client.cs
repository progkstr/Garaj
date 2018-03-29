using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace GarajProject_v2
{
    public class Client : BaseEntity
    {

        public string Number_card { get; set; }
        [ForeignKey ("Person")]
        public int? PersonID { get; set; }
        public virtual Person Person { get; set; }

        public virtual ICollection<Table> Tables { get; set; }
        public Client()
        {
            Tables = new List<Table>();
        }
    }
}

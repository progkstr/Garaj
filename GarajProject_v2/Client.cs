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
        //public Person person { get; set; }

        public ICollection<Table> tables { get; set; }
        public Client()
        {
            tables = new List<Table>();
        }
        public virtual Person Person { get; set; }
    }
}

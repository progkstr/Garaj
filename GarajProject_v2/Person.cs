using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace GarajProject_v2
{
    public class Person : BaseEntity
    {
        public Person()
        {

        }


        public string Name { get; set; }
        public string Adres { get; set; }
        public string Phone { get; set; }

        //public Employee employee { get; set; }
        //public Client client { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarajProject_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (cafeDB db = new cafeDB())
            {
                foreach (var r in db.Persons.ToList())
                {
                    MessageBox.Show(r.ID.ToString()+ r.Name.ToString()+ r.Adres.ToString()+ r.Phone.ToString());
                }
            }
        }
    }
}

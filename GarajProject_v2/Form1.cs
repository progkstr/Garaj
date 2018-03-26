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

            using (cafeDB new_connect = new cafeDB())
            {

                Person ad = new Person { Name = "Koleskin Mihail Aleksandrovich", Adres = "kostroma, dimitrova 1|2", Phone = "79977782211" }; //добавляем человека 
                //new_connect.Persons.Add(ad);
                //new_connect.SaveChanges();
            }
            using (cafeDB new_connect = new cafeDB())
            {
                foreach (var r in new_connect.Persons)
                {
                    MessageBox.Show(r.ID.ToString()+ r.Name.ToString()+ r.Adres.ToString()+ r.Phone.ToString());
                }
            }
        }
    }
}

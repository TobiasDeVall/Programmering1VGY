using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Datum
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }

        DateTime age = new DateTime(Datum.year, month, day);
        DateTime dateNow = DateTime.Now;

        DateTime date18 = dateNow.AddYears(-18);

        if (age.Date >= date18.Date)
	    {
         public bool confirm { get { return true; } }   
	    }
    }
}

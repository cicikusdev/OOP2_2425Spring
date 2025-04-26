using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstract sınıf olacak

namespace OOP2_2425Spring_Grp13
{
    public abstract class Reminder
    {
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }

        public abstract void Notify();
    }
}

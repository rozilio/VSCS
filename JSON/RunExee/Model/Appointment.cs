using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunExe.Model
{
    class Appointment
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }

        //public string GetDate{ get => Date; set => Date = value; }
        //public string GetDescription { get => Description; set => Description = value; }
        //public string GetSubject { get => Subject; set => Subject = value; }
    }
}

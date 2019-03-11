using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS586_Train_Database
{
    class Train
    {
        public string Destination;
        public string Destination_code;
        public double Lat;
        public double Lon;
        public string Name;
        public short Number;
        public string Origin;
        public string Origin_Code;
        public string Or_Date;
        public float Speed;
        public string Sch_arr;
        public string Sch_dep;
        public string Local_date;
        public int Miles;
        public string Heading;


        public override string ToString()
        {
            return Local_date + " " + (Sch_arr ?? Sch_dep);
        }
    }
}

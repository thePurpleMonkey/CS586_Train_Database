using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS586_Train_Database
{
    class Train
    {
        public string destination;
        public string destination_code;
        public double lat;
        public double lon;
        public string Name;
        public short Number;
        public string origin;
        public string origin_code;
        public string or_date;
        public float speed;
        public string sch_arr;
        public string sch_dep;
        public string local_date;


        public override string ToString()
        {
            return local_date + " " + (sch_arr ?? sch_dep);
        }
    }
}

using System;
using System.Globalization;

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
        public double Speed;
        public string Sch_arr;
        public string Sch_dep;
        public string Local_date;
        public int Miles;
        public string Heading;
        public string Est_arr;
        public string Est_dep;
        public string Act_arr;
        public string Act_dep;
        public bool Is_enroute;


        public override string ToString()
        {
            return Local_date + " " + (Sch_arr ?? Sch_dep);
        }
    }
}

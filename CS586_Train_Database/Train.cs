using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS586_Train_Database
{
    class Train
    {
        string destination;
        string destination_code;
        double lat;
        double lon;
        string name;
        short number;
        string origin;
        string origin_code;
        string or_date;
        float speed;

        public override string ToString()
        {
            return number + " " + name + " -> " + destination;
        }
    }
}

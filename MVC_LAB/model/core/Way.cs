using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_LAB.model.core
{
    class Way
    {
        public Way(Point endP, int cost)
        {
            this.endPoint = endP;
            this.Cost = cost;
        }

        public Point endPoint
        {
            get; set;
        }

        public int Cost
        {
            get; set;
        }
    }
}

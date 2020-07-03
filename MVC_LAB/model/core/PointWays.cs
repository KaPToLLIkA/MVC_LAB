using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_LAB.model.core
{
    class PointWays
    {
        private List<Way> _ways = new List<Way>();

        public PointWays() { }

        public PointWays(Point startP)
        {
            this.startPoint = startP;
        }

        public Point startPoint
        {
            get; set;
        }

        public List<Way> Ways
        {
            get { return _ways; }
            set { _ways = value; }
        }
    }
}

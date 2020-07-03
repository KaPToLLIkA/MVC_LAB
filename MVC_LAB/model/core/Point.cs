using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_LAB.model.core
{
    class Point
    {
        public Point(int index, string name)
        {
            this.Index = index;
            this.Name = name;
        }

        public int Index
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public override bool Equals(object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point p = (Point)obj;
                return (Index == p.Index);
            }
        }
    }
}

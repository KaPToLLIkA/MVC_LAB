using MVC_LAB.model.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_LAB.model.intefaces
{
    interface ISolution
    {
        void findSolution(IModel model);
        List<Point> getLastBestWay();

        int getLastBestCost();
    }
}

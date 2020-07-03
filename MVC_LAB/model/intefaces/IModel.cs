using MVC_LAB.model.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_LAB.model.intefaces
{
    interface IModel
    {
        int countOfPoints
        {
            get; set;
        }

        int[,] CostsMatrix
        {
            get;
        }

        void resizeCostsMatrix(int newCountOfPoints);
        void randFillCostsMatrix(int min, int max);
        void setCostsMatrixValue(int row, int col, int value);
        void setCostsMatrixValues(int[,] matrix);
        void setPointsName(int index, string newName);
        List<String> getPointsNames();
        void setPointsNames(string[] newNames);
        List<Point> getPointsList();
        List<PointWays> getPointWaysList();
    }
}

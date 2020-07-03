using MVC_LAB.model.core;
using MVC_LAB.model.intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_LAB.model
{
    class Model : IModel
    {
        private int[,] costsMatrix;
        public int countOfPoints
        {
            get; set;
        }

        public int[,] CostsMatrix
        {
            get { return this.costsMatrix; }
        }

        public void resizeCostsMatrix(int newCountOfPoints)
        {
            this.costsMatrix = new int[newCountOfPoints, newCountOfPoints];
            this.countOfPoints = newCountOfPoints;
            for (int row = 0; row < this.countOfPoints; ++row)
            {
                for (int col = 0; col < this.countOfPoints; ++col)
                {
                    this.costsMatrix[row, col] = 0;
                }
            }
            this.countOfPoints = newCountOfPoints;
        }

        public void randFillCostsMatrix(int min, int max)
        {
            Random rand = new Random();
            for (int row = 0; row < this.countOfPoints; ++row)
            {
                for (int col = row; col < this.countOfPoints; ++col)
                {
                    if (row != col)
                    {
                        this.costsMatrix[row, col] = rand.Next(min, max);
                        this.costsMatrix[col, row] = this.costsMatrix[row, col];
                    } else
                    {
                        this.costsMatrix[row, col] = 0;
                    }
                }
            }
        }

        public void setCostsMatrixValue(int row, int col, int value)
        {

            if (row != col)
            {
                this.costsMatrix[row, col] = value;
                this.costsMatrix[col, row] = value;
            }
            
        }

        public void setCostsMatrixValues(int[,] matrix)
        {
            for (int row = 0; row < matrix.Length; ++row)
            {
                for (int col = 0; col < matrix.Length; ++col)
                {
                    this.costsMatrix[row, col] = matrix[row, col];
                }
            }
        }


        public void setPointsName(int index, string newName)
        {
            throw new NotImplementedException();
        }


        public List<String> getPointsNames()
        {
            List<String> names = new List<String>();

            for (int i = 0; i < countOfPoints; ++i)
            {
                names.Add("P" + i);
            }

            return names;
        }

        public void setPointsNames(string[] newNames)
        {
            throw new NotImplementedException();
        }

        public List<Point> getPointsList()
        {
            List<Point> points = new List<Point>();

            for(int i = 0; i < countOfPoints; ++i)
            {
                points.Add(new Point(i, "P" + i));
            }

            return points;
        }

        public List<PointWays> getPointWaysList()
        {
            List<Point> points = getPointsList();
            List<PointWays> newList = new List<PointWays>();

            for (int r = 0; r < countOfPoints; ++r)
            {
                newList.Add(new PointWays(points[r]));

                for (int c = 0; c < countOfPoints; ++c)
                {
                    if (costsMatrix[r,c] != 0)
                    {
                        newList[r].Ways.Add(new Way(points[c], costsMatrix[r, c]));
                    }
                }
            }

            return newList;
        }
    }
}

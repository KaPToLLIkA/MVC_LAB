using MVC_LAB.model.core;
using MVC_LAB.model.intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_LAB.model.solutions
{
    class NearestNeighborMethod : ISolution
    {
        private List<Point> bestWay = new List<Point>();
        private int bestCost = 0;

        public void findSolution(IModel model)
        {
            bestWay.Clear();
            bestCost = 0;

            List<List<Point>> allBestWays = new List<List<Point>>();
            List<int> bestTotalCosts = new List<int>();


            List<Point> points = model.getPointsList();
            List<Point> availablePoints;

            List<PointWays> allWays = model.getPointWaysList();


            for (int loop = 0; loop < points.Count; ++loop)
            {

                List<Point> tmpBestWay = new List<Point>();

                Point start = points[loop];
                Point curP = points[loop];
                int totalCost = 0;
                availablePoints = new List<Point>(points);
                availablePoints.Remove(start);
                tmpBestWay.Add(start);

                for (int waysListIdx = 0; waysListIdx < allWays.Count; ++waysListIdx)
                {
                    if (allWays[waysListIdx].startPoint.Equals(curP))
                    {
                        int minCost = int.MaxValue;
                        foreach (Way curWay in allWays[waysListIdx].Ways)
                        {         
                            if (curWay.Cost < minCost
                                && availablePoints.Contains(curWay.endPoint))
                            {
                                minCost = curWay.Cost;
                                curP = curWay.endPoint;
                            }
                        }
                        totalCost += minCost;
                        availablePoints.Remove(curP);
                        waysListIdx = -1;
                        tmpBestWay.Add(curP);


                        if (curP.Equals(start))
                        {
                            bestTotalCosts.Add(totalCost);
                            allBestWays.Add(tmpBestWay);
                            break;
                        }
                    }

                    if (availablePoints.Count == 0)
                    {
                        availablePoints.Add(start);
                    }
                }

               
            }


            int bestOfTheBestCost = int.MaxValue;
            int index = 0;
            for (int i = 0; i < bestTotalCosts.Count; ++i)
            {
                if (bestOfTheBestCost > bestTotalCosts[i])
                {
                    index = i;
                    bestOfTheBestCost = bestTotalCosts[i];
                }
            }

            this.bestCost = bestTotalCosts[index];
            this.bestWay = allBestWays[index];
        }

        public int getLastBestCost()
        {
            return this.bestCost;
        }

        public List<Point> getLastBestWay()
        {
            return this.bestWay;
        }

        
    }
}

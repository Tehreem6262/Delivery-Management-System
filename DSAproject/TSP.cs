using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAproject
{
    public static class TSP
    {
        public static int CalculateRouteDistance(List<int> route, int[,] distances)
        {
            int totalDistance = 0;
            for (int i = 0; i < route.Count - 1; i++)
            {
                totalDistance += distances[route[i], route[i + 1]];
            }

            int lastCity = route[route.Count - 1];
            int startCity = route[0];
            totalDistance += distances[lastCity, startCity];
            return totalDistance;
        }
        public static (List<int> ShortestRoute, int MinDistance) SolveBruteForce(int[,] distances)
        {
            int n = distances.GetLength(0);
            List<int> citiesToVisit = new List<int>();
            for (int i = 1; i < n; i++)
            {
                citiesToVisit.Add(i);
            }

            List<int> shortestRoute = new List<int>();
            int minDistance = int.MaxValue;

            var allPermutations = GeneratePermutations(citiesToVisit);

            foreach (var perm in allPermutations)
            {
                List<int> currentRoute = new List<int>();
                currentRoute.Add(0);
                currentRoute.AddRange(perm);

                int currentDistance = CalculateRouteDistance(currentRoute, distances);

                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                    shortestRoute = new List<int>(currentRoute);
                }
            }

            return (shortestRoute, minDistance);
        }
        private static List<List<int>> GeneratePermutations(List<int> list)
        {
            if (list.Count == 0)
            {
                return new List<List<int>> { new List<int>() };
            }

            List<List<int>> result = new List<List<int>>();

            int firstElement = list[0];
            List<int> remainingList = list.Skip(1).ToList();

            var recursiveReturn = GeneratePermutations(remainingList);

            foreach (var li in recursiveReturn)
            {
                for (int i = 0; i <= li.Count; i++)
                {
                    List<int> temp = new List<int>(li);
                    temp.Insert(i, firstElement);
                    result.Add(temp);
                }
            }
            return result;
        }
    }

}
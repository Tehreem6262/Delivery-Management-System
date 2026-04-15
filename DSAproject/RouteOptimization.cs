using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DSAproject
{
    public partial class RouteOptimization : Form
    {
        private Rider currentRider;
        string filePath = "deliveries.txt";

        Dictionary<string, int> locationIndex = new Dictionary<string, int>()
        {
            { "Dispatch Center", 0 },
            { "Bahria University", 1 },
            { "Dalmia", 2 },
            { "Millennium Mall", 3 },
            { "Gulshan-e-Iqbal", 4 },
            { "Clifton", 5 },
            { "Saddar", 6 },
            { "Baldia Town", 7 }
        };

        int[,] distances =
        {
            { 0, 6, 5, 7, 4, 10, 11, 18 },
            { 6, 0, 3, 4, 5, 9, 10, 17 },
            { 5, 3, 0, 2, 4, 8, 9, 16 },
            { 7, 4, 2, 0, 5, 7, 8, 15 },
            { 4, 5, 4, 5, 0, 9, 10, 17 },
            { 10, 9, 8, 7, 9, 0, 3, 12 },
            { 11, 10, 9, 8, 10, 3, 0, 11 },
            { 18, 17, 16, 15, 17, 12, 11, 0 }
        };

        public RouteOptimization(Rider rider)
        {
            InitializeComponent();
            currentRider = rider;
        }

        private void RouteOptimization_Load(object sender, EventArgs e)
        {
            lblRiderName.Text = "Rider: " + currentRider.Name;

            dgvRoute.Columns.Clear();
            dgvRoute.Columns.Add("Step", "Step");
            dgvRoute.Columns.Add("Route", "Route");
            dgvRoute.Columns.Add("Distance", "Distance (km)");
        }

        private void btnOptimize_Click(object sender, EventArgs e)
        {
            dgvRoute.Rows.Clear();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No deliveries file found.");
                return;
            }

            var lines = File.ReadAllLines(filePath);

            var myDeliveries = lines
                .Select(l => l.Split('|'))
                .Where(d => d.Length == 5 &&
                            d[2] == currentRider.Name &&
                            d[4] != "Completed")
                .ToList();

            if (myDeliveries.Count == 0)
            {
                MessageBox.Show("No pending deliveries for this rider.");
                return;
            }

            List<string> tspLocations = new List<string> { "Dispatch Center" };
            foreach (var d in myDeliveries)
                tspLocations.Add(d[3]);

            int n = tspLocations.Count;
            int[,] tspDistances = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int idx1 = locationIndex[tspLocations[i]];
                    int idx2 = locationIndex[tspLocations[j]];
                    tspDistances[i, j] = distances[idx1, idx2];
                }
            }

            List<int> normalRouteIndices = Enumerable.Range(0, n).ToList();
            int normalDistance = TSP.CalculateRouteDistance(normalRouteIndices, tspDistances);
            string normalRoute = string.Join(" -> ", tspLocations) + " -> " + tspLocations[0];

            var result = TSP.SolveBruteForce(tspDistances);
            List<int> optimizedRouteIndices = result.ShortestRoute;
            int optimizedDistance = result.MinDistance;
            string optimizedRoute = string.Join(" -> ", optimizedRouteIndices.Select(i => tspLocations[i]))
                                    + " -> " + tspLocations[0];

            MessageBox.Show(
                "Before Optimization:\n" +
                normalRoute + "\nDistance: " + normalDistance + " km\n\n" +
                "After Optimization:\n" +
                optimizedRoute + "\nDistance: " + optimizedDistance + " km",
                "Route Optimization Result"
            );

            for (int i = 0; i < optimizedRouteIndices.Count; i++)
            {
                int from = optimizedRouteIndices[i];
                int to = (i == optimizedRouteIndices.Count - 1) ? optimizedRouteIndices[0] : optimizedRouteIndices[i + 1];
                int dist = tspDistances[from, to];

                dgvRoute.Rows.Add(
                    i + 1,
                    tspLocations[from] + " → " + tspLocations[to],
                    dist
                );
            }

            lblTotalDistance.Text = "Optimized Distance: " + optimizedDistance + " km";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvRoute.Rows.Clear();
            lblTotalDistance.Text = "Optimized Distance: 0 km";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RiderForm rf = new RiderForm(currentRider);
            rf.Show();
            this.Hide();
        }
    }
}

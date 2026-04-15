using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAproject
{

    public class AdminProg : User
    {
        public AdminProg()
        {
            Role = "Admin";
        }
    }

    public class AdminService
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Rider> Riders { get; set; } = new List<Rider>();
        public List<DeliveryRequest> Deliveries { get; set; } = new List<DeliveryRequest>();
        public Dictionary<string, double> DeliveryRates { get; set; } = new Dictionary<string, double>();

        public bool Login(string username, string password)
        {
            return username == "admin" && password == "admin123";
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void UpdateCustomer(int customerId, string name, string username, string password)
        {
            var customer = Customers.FirstOrDefault(c => c.Id == customerId);
            if (customer != null)
            {
                customer.Name = name;
                customer.Username = username;
                customer.PasswordHash = password;
            }
        }

        public void RemoveCustomer(int customerId)
        {
            var customer = Customers.FirstOrDefault(c => c.Id == customerId);
            if (customer != null)
                Customers.Remove(customer);
        }

        public void AddRider(Rider rider)
        {
            Riders.Add(rider);
        }

        public void UpdateRider(int riderId, string name, string username, string password)
        {
            var rider = Riders.FirstOrDefault(r => r.Id == riderId);
            if (rider != null)
            {
                rider.Name = name;
                rider.Username = username;
                rider.PasswordHash = password;
            }
        }

        public void RemoveRider(int riderId)
        {
            var rider = Riders.FirstOrDefault(r => r.Id == riderId);
            if (rider != null)
                Riders.Remove(rider);
        }

        public void CreateDelivery(DeliveryRequest delivery)
        {
            delivery.Status = "Pending";
            Deliveries.Add(delivery);
        }

        public void AssignRider(int orderId, int riderId)
        {
            var delivery = Deliveries.FirstOrDefault(d => d.OrderId == orderId);
            var rider = Riders.FirstOrDefault(r => r.Id == riderId);
            if (delivery != null && rider != null)
            {
                delivery.RiderId = riderId;
                delivery.Status = "Assigned";
            }
        }

        public void UpdateDeliveryStatus(int orderId, string status)
        {
            var delivery = Deliveries.FirstOrDefault(d => d.OrderId == orderId);
            if (delivery != null)
                delivery.Status = status;
        }

        public void GenerateOptimizedRoute(int orderId, int[,] distanceMatrix)
        {
            var delivery = Deliveries.FirstOrDefault(d => d.OrderId == orderId);
            if (delivery != null)
            {
                var result = TSP.SolveBruteForce(distanceMatrix);
                delivery.OptimizedRoute = result.ShortestRoute;
                delivery.Distance = result.MinDistance;
            }
        }

        public void UpdateRiderSalary(int riderId, double salary)
        {
            var rider = Riders.FirstOrDefault(r => r.Id == riderId);
            if (rider != null)
                rider.Salary = salary;
        }

        public void IncrementDeliveriesCompleted(int riderId)
        {
            var rider = Riders.FirstOrDefault(r => r.Id == riderId);
            if (rider != null)
                rider.DeliveriesCompleted += 1;
        }

        public void SetDeliveryRate(string rateType, double rate)
        {
            DeliveryRates[rateType] = rate;
        }

        public double GetDeliveryRate(string rateType)
        {
            return DeliveryRates.ContainsKey(rateType) ? DeliveryRates[rateType] : 0;
        }

        public List<DeliveryRequest> GetAllDeliveries()
        {
            return Deliveries;
        }

        public List<Rider> GetAllRiders()
        {
            return Riders;
        }

        public List<Customer> GetAllCustomers()
        {
            return Customers;
        }
    }
}



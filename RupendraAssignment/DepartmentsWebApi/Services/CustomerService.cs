using DepartmentsWebApi.Database;
using DepartmentsWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentsWebApi.Services
{
    public class CustomerService : ICustomerService
    {
        private int _totalDistanceTravelled = 0;
        private IList<string> _customers = new List<string>();
        private ICustomerDB customerDB = new CustomerDB();

        public int TotalDistanceTravelled
        {
            get
            {
                return _totalDistanceTravelled;
            }
        }

        public IList<string> FilteredCustomers
        {
            get
            {
                return _customers;
            }
        }

        public void FindCustomersShortetRoute(int x, int y)
        {
            IList<Customer> customers = customerDB.Customers;

            GetNearestCustomer(customers, x, y);            
        }        

        private void GetNearestCustomer(IList<Customer> customers, int x, int y)
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;
            int distance = 0;
            Dictionary<string, int> distanceList = new Dictionary<string, int>();

            foreach (Customer customer in customers)
            {
                x1 = customer.X;
                y1 = customer.Y;
                x2 = x;
                y2 = y;
                distance = 0;

                distance = (int)Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
                distanceList.Add(customer.Name, distance);
            }

            var shortestCustomer = distanceList.First(d => d.Value == distanceList.Min(d => d.Value));
            _customers.Add(shortestCustomer.Key);
            _totalDistanceTravelled += shortestCustomer.Value;

            Customer nearestCustomer = customers.Single(c => c.Name == shortestCustomer.Key);
            x1 = nearestCustomer.X;
            y1 = nearestCustomer.Y;
            customers.Remove(nearestCustomer);
            if(customers.Count > 1)
            {
                GetNearestCustomer(customers, x1, y1);
            }
            else
            {
                x1 = customers[0].X;
                y1 = customers[0].Y;
                x2 = x;
                y2 = y;
                distance = 0;

                distance = (int)Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
                _customers.Add(customers[0].Name);
                _totalDistanceTravelled += distance;
            }            
        }
    }
}

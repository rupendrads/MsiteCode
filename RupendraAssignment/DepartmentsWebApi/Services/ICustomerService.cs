using DepartmentsWebApi.Models;
using System.Collections.Generic;

namespace DepartmentsWebApi.Services
{
    public interface ICustomerService
    {
        int TotalDistanceTravelled { get; }
        IList<string> FilteredCustomers { get; }

        void FindCustomersShortetRoute(int x, int y);
    }
}
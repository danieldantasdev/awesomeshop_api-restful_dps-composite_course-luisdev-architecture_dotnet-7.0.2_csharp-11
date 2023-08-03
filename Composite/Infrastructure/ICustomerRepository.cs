using Composite.Core.Entities;

namespace Composite.Infrastructure;

public interface ICustomerRepository
{
    List<Customer> GetBlockedCustomers();
}
using Composite.Application.Models;

namespace Composite.Infrastructure.Deliveries;

public interface IDeliveryService
{
    void Deliver(OrderInputModel model);
}
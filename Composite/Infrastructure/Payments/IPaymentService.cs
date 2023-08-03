using Composite.Application.Models;

namespace Composite.Infrastructure.Payments;

public interface IPaymentService
{
    object Process(OrderInputModel model);
}
using Composite.Core.Enums;
using Composite.Infrastructure.Deliveries;
using Composite.Infrastructure.Payments;

namespace Composite.Infrastructure;

public interface IOrderAbstractFactory
{
    IPaymentService GetPaymentService(PaymentMethod method);
    IDeliveryService GetDeliveryService();
}
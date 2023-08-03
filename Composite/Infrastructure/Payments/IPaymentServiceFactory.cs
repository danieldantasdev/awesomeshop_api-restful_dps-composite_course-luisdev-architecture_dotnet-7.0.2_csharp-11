using Composite.Core.Enums;

namespace Composite.Infrastructure.Payments;

public interface IPaymentServiceFactory
{
    IPaymentService GetService(PaymentMethod paymentMethod);
}
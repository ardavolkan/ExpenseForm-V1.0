using Core.DataAccess.Databases;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IPaymentDal : IEntityRepository<Payment>
    {
        PaymentCountDto GetCount();
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;

namespace Business
{
    public interface IPaymentTestBusiness
    {
        Task<PaymentsLog> Insert(PaymentsLog paymentRequest);
        Task<IEnumerable<PaymentsLog>> GetAll();
        Task<PaymentsLog> GetItem(long? item);
        Task<PaymentsLog> Update(PaymentsLog request);
    }
}

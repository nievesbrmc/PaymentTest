using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data
{
    public interface IPaymentTestData
    {
        Task<PaymentsLog> Insert(PaymentsLog paymentRequest);
        Task<IEnumerable<PaymentsLog>> GetAll();
        Task<PaymentsLog> Update(PaymentsLog paymentRequest);
    }
}

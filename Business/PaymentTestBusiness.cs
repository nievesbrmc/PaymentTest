using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Entity;

namespace Business
{
    public class PaymentTestBusiness:IPaymentTestBusiness
    {
        private readonly IPaymentTestData _data;
        public PaymentTestBusiness(IPaymentTestData data)
        {
            _data = data;
        }

        /// <summary>
        /// Insert a item 
        /// </summary>
        /// <param name="paymentRequest">Object to inserted</param>
        /// <returns></returns>
        public async Task<PaymentsLog> Insert(PaymentsLog paymentRequest)
        {
            IEnumerable<PaymentsLog> list = await _data.GetAll();
            PaymentsLog newItem = paymentRequest;
            newItem.PaymentId = list.Any() ? list.OrderByDescending(x => x.PaymentId).FirstOrDefault().PaymentId + 1 : 1;
             return await _data.Insert(newItem);
        }

        /// <summary>
        /// Get all items
        /// </summary>
        /// <returns>All items from PaymentsLog</returns>
        public async Task<IEnumerable<PaymentsLog>> GetAll()
        {
            return await _data.GetAll();
        }

        /// <summary>
        /// Get a item from id
        /// </summary>
        /// <param name="item">Item to find</param>
        /// <returns>Item paymentlog</returns>
        public async Task<PaymentsLog> GetItem(long? item)
        {
            IEnumerable<PaymentsLog> list = await _data.GetAll();
            PaymentsLog response = list.FirstOrDefault(x => x.PaymentId == item);
            return response;
        }

        /// <summary>
        /// Update a item 
        /// </summary>
        /// <param name="request">data to update</param>
        /// <returns>data updated</returns>
        public async Task<PaymentsLog> Update(PaymentsLog request)
        {
            return await _data.Update(request);
        }
    }
}
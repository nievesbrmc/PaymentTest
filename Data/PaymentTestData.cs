using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using DbContextLaye;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data
{
    public class PaymentTestData : IPaymentTestData
    {
        private readonly DbContextData _context;
        public PaymentTestData(DbContextData context)
        {
            _context = context;
        }

        /// <summary>
        /// Insert a item to paymentlog
        /// </summary>
        /// <param name="paymentRequest">Dato to insert</param>
        /// <returns>the item inserted</returns>
        public async Task<PaymentsLog> Insert(PaymentsLog paymentRequest)
        {
            PaymentsLog response = new();
            if (paymentRequest != null)
            {
                EntityEntry<PaymentsLog> inserted = await _context.PaymentsLogs.AddAsync(paymentRequest);
                await _context.SaveChangesAsync();
                return inserted.Entity;
            }
            return response;
        }

        /// <summary>
        /// Get all items
        /// </summary>
        /// <returns>List of items</returns>
        public async Task<IEnumerable<PaymentsLog>> GetAll()
        {
            IEnumerable<PaymentsLog> data = _context.PaymentsLogs.ToList();
            return data;
        }

        /// <summary>
        /// Update a item 
        /// </summary>
        /// <param name="PaymentsLog">Object to update</param>
        /// <returns>object updated</returns>
        public async Task<PaymentsLog> Update(PaymentsLog paymentRequest)
        {
            EntityEntry<PaymentsLog> modified = _context.PaymentsLogs.Update(paymentRequest);
            await _context.SaveChangesAsync();
            return modified.Entity;
        }
    }
}
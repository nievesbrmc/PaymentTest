using Business;
using Data;
using Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace API_PaymentTest_Test
{
    [TestClass]
    public class PaymentTesting
    {
        private Mock<IPaymentTestData> dataLayer;
        private IPaymentTestBusiness _business;

        [TestInitialize]
        public void Starting()
        {
            this.dataLayer = new Mock<IPaymentTestData>();
        }
        [TestMethod]
        public async Task InsertPayment()
        {
            PaymentsLog response = new PaymentsLog
            {
                Amount=10,
                 PaymentConcept="",
                 PaymentId=1,
                 PaymentStatusId=2,
                 PaymentTo="",
                 ProuctQuantity=1,
                 Pymentfrom=""
            };

            List<PaymentsLog> list = new List<PaymentsLog>
            {
                new PaymentsLog
                {
                    Amount=10,
                 PaymentConcept="",
                 PaymentId=1,
                 PaymentStatusId=1,
                 PaymentTo="",
                 ProuctQuantity=1,
                 Pymentfrom=""
                }
            };

            dataLayer.Setup(x => x.GetAll()).ReturnsAsync(list);
            dataLayer.Setup(x => x.Insert(It.IsAny<PaymentsLog>())).ReturnsAsync(response);
            _business = new PaymentTestBusiness(dataLayer.Object);
            response =await _business.Insert(response);
            Assert.IsTrue(response.PaymentId > 1);
        }
    }
}
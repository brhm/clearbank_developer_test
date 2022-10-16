using ClearBank.DeveloperTest.Services;
using ClearBank.DeveloperTest.Types;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClearBank.DeveloperTest.Tests
{
    
    public class PaymentTest
    {
        private IPaymentService _paymentService;
        private Mock<IPaymentService> _paymentServiceMock;
      
        public PaymentTest()
        {
           // _paymentService = new PaymentService();
             _paymentServiceMock = new Mock<IPaymentService>();
            _paymentService= _paymentServiceMock.Object;
        }

        [Fact]
        public void MakePayment_Test_With_Null()
        {
            MakePaymentResult result = new MakePaymentResult() { Success = false };

            _paymentServiceMock.Setup(x => x.MakePayment(null)).Returns(result);

            var actualResult = _paymentService.MakePayment(null);

            Assert.Equal(actualResult.Success, result.Success);

        }
       
    }
}

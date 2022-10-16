using ClearBank.DeveloperTest.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearBank.DeveloperTest.AccountPaymentShceme
{
    public interface ICheckPaymentScheme
    {
        MakePaymentResult CheckAccountPayment(Account account, MakePaymentRequest request);
    }
}

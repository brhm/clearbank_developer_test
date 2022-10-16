using ClearBank.DeveloperTest.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearBank.DeveloperTest.AccountPaymentShceme
{
    public class CheckAccountPaymentBacs : ICheckPaymentScheme
    {
        public MakePaymentResult CheckAccountPayment(Account account, MakePaymentRequest request = null)
        {
            MakePaymentResult result = new MakePaymentResult();
            result.Success = true;
            if (!account.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.Bacs))
            {
                result.Success = false;
            }

            return result;
        }
    }
}

using ClearBank.DeveloperTest.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearBank.DeveloperTest.AccountPaymentShceme
{
    public class CheckAccountPaymentFasterPayments : ICheckPaymentScheme
    {
        public MakePaymentResult CheckAccountPayment(Account account, MakePaymentRequest request)
        {
            MakePaymentResult result = new MakePaymentResult();
            result.Success = true;
            if (!account.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.FasterPayments))
            {
                result.Success = false;
            }
            else if (account.Balance < request.Amount)
            {
                result.Success = false;
            }

            return result;
        }
    }
}

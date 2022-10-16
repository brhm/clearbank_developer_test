using ClearBank.DeveloperTest.Data;
using ClearBank.DeveloperTest.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearBank.DeveloperTest.AccountPaymentShceme
{
    public static class CheckAccountPaymentFactory
    {
        public static ICheckPaymentScheme CreateCheckAccountPayment(PaymentScheme type)
        {
            switch (type)
            {
                case PaymentScheme.Bacs:
                    return new CheckAccountPaymentBacs();                    

                case PaymentScheme.FasterPayments:
                    return new CheckAccountPaymentFasterPayments();
                   

                case PaymentScheme.Chaps:
                    return new CheckAccountPaymentChaps();
                   
            }
            return new CheckAccountPaymentBacs();

        }
    }

}

using ClearBank.DeveloperTest.AccountPaymentShceme;
using ClearBank.DeveloperTest.Data;
using ClearBank.DeveloperTest.Types;
using System.Configuration;

namespace ClearBank.DeveloperTest.Services
{
    public class PaymentService : IPaymentService
    {
        public MakePaymentResult MakePayment(MakePaymentRequest request)
        {
            var result = new MakePaymentResult();
            result.Success = true;
            if (request == null)            {
                result.Success = false;
                return result;
            }
            var dataStoreType = ConfigurationManager.AppSettings["DataStoreType"];
            
            IDataStore dataStore = DataStoreFactory.CreateDataStore(dataStoreType);           

            Account account = dataStore.GetAccount(request.DebtorAccountNumber);           


            if (account == null)
            {
                result.Success = false;
                return result;
            }

            ICheckPaymentScheme checkPaymentScheme = CheckAccountPaymentFactory.CreateCheckAccountPayment(request.PaymentScheme);
            result = checkPaymentScheme.CheckAccountPayment(account, request);

            if (result.Success)
            {
                account.Balance -= request.Amount;
                dataStore.UpdateAccount(account);
            }

            return result;
        }

    }
}

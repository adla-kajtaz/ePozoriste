using Braintree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Services
{
    public class PayPalService
    {
        BraintreeGateway gateway;

        public PayPalService()
        {
            gateway = new BraintreeGateway
            {
                Environment = Braintree.Environment.SANDBOX,
                MerchantId = "y7hkg4jk49g723dx",
                PublicKey = "nsjbdp9j2qwmks34",
                PrivateKey = "3f6c1f2d7e8c37d456622379e9c35839"
            };
        }
        public async Task<string>GetClientToken()
        {

            var clientToken = await gateway.ClientToken.GenerateAsync();
            return clientToken;

        }

        public Result<Transaction>? MakeTransaction(int iznos, string nonce)
        {

            var request = new TransactionRequest
            {
                Amount = Convert.ToDecimal(iznos),
                PaymentMethodNonce = nonce,
                Options = new TransactionOptionsRequest
                {
                SubmitForSettlement = true,
                }
            };
            var result = gateway.Transaction.Sale(request);
            if (result.Target.ProcessorResponseText.Equals("Approved"))
                return result;
            return null;

        }

    }
}

using System;

namespace ConsoleApplication {
    public class Program {
        public static void Main(string[] args) {
            var paymentType = args[3];
            if(paymentType == "p"){
                var payPal = new PayPalPayment{
                    Email = args[0],
                    Password = args[1],
                    Amount = Convert.ToDecimal(args[2])
                };

                Console.WriteLine(payPal.MakePayment());
            }

            if(paymentType == "c"){
                var creditPayment = new CreditCardPayment{
                    cardNumber = args[1],
                    Amount = Convert.ToDecimal(args[2])
                };
                
                Console.WriteLine(creditPayment.MakePayment());
            }
        }
    }
}

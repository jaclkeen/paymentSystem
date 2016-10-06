using System;

namespace ConsoleApplication{
    public class CreditCardPayment:Payment{
        public string cardNumber{get;set;}
        public override string MakePayment(){
            string message = string.Empty;
            if(this.Amount > 0 && this.cardNumber != null){
                message = $"Your payment of {this.Amount} has been processed by Visa!";
            }
            return message;
        }
    }
}
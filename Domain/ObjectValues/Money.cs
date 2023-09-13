namespace Domain.ObjectValues
{
    public record Money
    {
        public string Currency { get; private set; }
        public double Amount { get; private set; }
        public Money(string currency,double amount) { 
            Currency = currency;
            if(amount > 0)
            {
                Amount = amount;
            }
        }
    }
}
namespace TomSoft
{
    class Payment
    {
        public string paymentTypeId { get; }
        public string name { get; set; }
        public double amount { get; set; }

        public Payment(string paymentTypeId, string name, double amount)
        {
            this.paymentTypeId = paymentTypeId;
            this.name = name;
            this.amount = amount;
        }
    }
}

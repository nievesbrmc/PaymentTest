namespace Entity
{
    public class PaymentsLog
    {
        public long PaymentId { get; set; }
        public string PaymentConcept { get; set; }
        public int ProuctQuantity { get; set; }
        public string Pymentfrom { get; set; }
        public string PaymentTo { get; set; }
        public decimal Amount { get; set; }
        public long PaymentStatusId { get; set; }
    }
}
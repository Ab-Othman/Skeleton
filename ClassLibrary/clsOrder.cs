using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public String OrderNo { get; set; }
        public String CustomerUserId { get; set; }
        public DateTime OrderDate { get; set; }
        public String ShippingAddress { get; set; }
        public String PaymentMethod { get; set; }
        public Boolean PaymentReceived { get; set; }
        public String OrderStatus { get; set; }
    }
}
using System;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        public int OrderLineId { get; set; } 
        public String OrderNo { get; set; }
        public int PhoneNo { get; set; }
        public int Quantity { get; set; }
        public Decimal PricePaid { get; set; }
    }
}
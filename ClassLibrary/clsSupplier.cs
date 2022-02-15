using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool Active { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public int SupplierID { get; set; }
        public string PhoneNumber { get; set; }
        public string ShippingFromAddress { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
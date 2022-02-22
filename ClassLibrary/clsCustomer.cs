using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string CustomerUserId { get; set; }
        public string CustomerFullName { get; set; }
        public int CustomerPhoneNumber { get; set; }
        public string CustomerEmailId { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public bool SubscribedToReceiveMail { get; set; }
        public DateTime CustomerAccountCreated { get; set; }
    }
}
using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerUserId { get; set; }
        public string CustomerFullName { get; set; }
        public String CustomerPhoneNumber { get; set; }
        public string CustomerEmailId { get; set; }
        public string CustomerAddress { get; set; }
        public bool SubscribedToReceiveMail { get; set; }
        public DateTime CustomerAccountCreated { get; set; }
    }
}
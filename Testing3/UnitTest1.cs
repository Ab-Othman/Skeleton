using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //test to see tha it exists 
            Assert.IsNotNull(ACustomer);
        }
    }
}

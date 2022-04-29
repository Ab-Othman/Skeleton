using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStaff Anstaff = new clsStaff();
            //test to see that exists
            Assert.IsNotNull(Anstaff);
        }
    }
}

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrderViewer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create insatnce of class want to create
            clsOrderViewer anOrderViewer = new clsOrderViewer();
            //test to see that it exists
            Assert.IsNotNull(anOrderViewer);
        }
    }
}

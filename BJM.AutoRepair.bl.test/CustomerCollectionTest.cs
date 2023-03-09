using BJM.AutoReapir.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJM.AutoRepair.BL.test
{
    [TestClass]
    public class CustomerCollectionTest
    {
        [TestMethod]
        public void CustomerCollectionLoadTest()
        {
            CustomerCollection customerCollection = new CustomerCollection();
            customerCollection.LoadTestCustomers();
            Assert.IsTrue(customerCollection.Count > 0);
            if (customerCollection.Count == 0) Assert.Fail();
            // Thread.Sleep(2000); // WAITS 2000
        }
    }
}

using BJM.AutoReapir.BL;

namespace BJM.AutoRepair.BL.test
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void EptyConstructorTest()
        {
            Person person = new Person();
            Assert.IsNotNull(person);
        }
    }
}
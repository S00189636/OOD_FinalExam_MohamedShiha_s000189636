using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MohamadShiha_S00189636;
namespace PhoneApp_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        // this will make test if the phone priced at 100 will increase by 10 
        //if i used the method giving 10 as a parameter
        [TestMethod]
        public void Test_Phone_IncreasePrice()
        {
            // Arrange 
            Phone testPhone = new Phone()
            {
                Price = 100
            };
            decimal expected = 110;
            // Act
            testPhone.IncreasePrice(10);
            decimal actual = testPhone.Price;

            Assert.AreEqual(expected, actual);
        }
    }
}

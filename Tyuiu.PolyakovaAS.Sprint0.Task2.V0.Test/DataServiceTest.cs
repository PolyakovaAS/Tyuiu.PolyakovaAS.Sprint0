using Tyuiu.PolyakovaAS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PolyakovaAS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = "Валентин";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Валентин", res);
        }
    }
}

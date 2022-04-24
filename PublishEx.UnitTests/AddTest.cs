using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PublishEx.UnitTests
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void Add_Test()
        {
            AddClass addObj = new AddClass();

            var result=addObj.Addition(5, 3);

            Assert.IsTrue(result == 8);
        }
    }
}

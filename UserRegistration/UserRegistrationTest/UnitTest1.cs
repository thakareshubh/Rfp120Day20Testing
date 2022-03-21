using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly UserRegistration.Program program;
        public UnitTest1()
        {
            program = new UserRegistration.Program();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int age = 20;
            string email = "shubhamthakare721@gmail.com";
            string password = "123456789";
            var result=program.UserChecker(email, password);
            var result1=program.AgeChecker(age);
            Assert.AreEqual("welcome", result1);
            

        }
    }
}

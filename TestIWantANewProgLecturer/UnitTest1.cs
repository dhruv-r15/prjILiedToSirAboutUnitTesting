using prjILiedToSirAboutUnitTesting;

namespace TestIWantANewProgLecturer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetName()
        {
            DoWhatEver doWhat = new DoWhatEver();

            String Actual = doWhat.getName();

            String Expected = "Jeff";

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestGetEmail()
        {
            DoWhatEver doWhat = new DoWhatEver();

            String Actual = doWhat.getEmail();

            String Expected = "jess@gmail.com";

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestGetDate()
        {
            DoWhatEver doWhat = new DoWhatEver();

            String Actual = doWhat.getDate();

            String Expected = "2024/04/04";

            Assert.AreEqual(Expected, Actual);
        }
    }
}
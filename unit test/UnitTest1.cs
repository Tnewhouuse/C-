using C_;

namespace unit_test
{
    public class Tests
    {
        Calulator mycalculator;
        [SetUp]
        public void Setup()
        {
            mycalculator = new Calulator();
        }

        [Test]
        public void Test1()
        {
            Assert.That(mycalculator.add(2,2).Equals(4));
        }
        [Test]
        public void Test2()
        {
            Assert.That(mycalculator.add(2, 2).Equals(4));
        }
        [Test]
        public void Test3()
        {
            Assert.That(mycalculator.add(2, 2).Equals(4));
        }
        [Test]
        public void Test4()
        {
            Assert.That(mycalculator.add(2, 2).Equals(4));

        }
    }
}
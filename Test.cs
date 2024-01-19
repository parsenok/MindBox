using MindBox;
using NUnit;
using NUnit.Allure.Attributes;
namespace TestMindBox
{
    public class Tests
    {

        [Test]
        public void Circle()
        {
            var circle = new Circle { radius = 5 };
            double area = circle.CalculateArea();
            Assert.AreEqual(Math.PI * Math.Pow(5, 2), area);
        }
        [Test]
        public void Triangle()
        {
            var triangle = new Circle { radius = 5 };
            double area = triangle.CalculateArea();
            Assert.AreEqual(Math.PI * Math.Pow(5, 2), area);
        }
    }
}
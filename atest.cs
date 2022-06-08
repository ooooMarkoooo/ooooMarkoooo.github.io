using NUnit.Framework;
namespace StringCalculatorKata.Test {
    public class StringCalculatorTest {
        [Test]
        public void Add_EmptyStringAsParam_ReturnsZero() {
            Assert.AreEqual(0, StringCalculator.Add(""));
        }

        public static int Add(string numbers) {
            throw new NotImplementedException();
        }
    }
}

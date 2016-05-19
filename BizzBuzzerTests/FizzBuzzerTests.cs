using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzer.Library;
namespace FizzBuzzerTests.Library
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        
        public FizzBuzzerTests()
        {
            
        }
        [Test]
        public void FizzBuzzer_When1_Returns1([Values(1)] int input)
        {
            string output = FizzBuzzer.Library.FizzBuzzer.getNumber(input);

            Assert.AreEqual("1", output);
        }

        [Test]
        public void FizzBuzzer_When2_Returns2([Values(2)] int intput)
        {
            string output = FizzBuzzer.Library.FizzBuzzer.getNumber(intput);

            Assert.AreEqual("2", output);
        }

        [Test]
        public void FizzBuzzer_When5_ReturnsBuzz([Values(5)] int input)
        {
            String output = FizzBuzzer.Library.FizzBuzzer.getNumber(input);

            Assert.AreEqual("Buzz", output);

        }
        [Test]
        public void FizzBuzzer_When3_ReturnsFizz([Values(3)] int input)
        {
            String output = FizzBuzzer.Library.FizzBuzzer.getNumber(input);

            Assert.AreEqual("Fizz", output);

        }
        [Test]
        public void FizzBuzzer_WhenDiv3_ReturnsFizz([Values(3,6,9,12,18)] int input)
        {
            String output = FizzBuzzer.Library.FizzBuzzer.getNumber(input);

            Assert.AreEqual("Fizz", output);


        }

        [Test]
        public void FizzBuzzer_WhenDiv5_ReturnsBuzz([Values(5,10,20,25)] int input)
        {
            string output = FizzBuzzer.Library.FizzBuzzer.getNumber(input);

            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void FizzBuzzer_WhenDiv3andDiv5_ReturnsFizzBuzzer([Values (15, 30)] int input)
        {
            string output = FizzBuzzer.Library.FizzBuzzer.getNumber(input);

            Assert.AreEqual("FizzBuzz", output);
        }
    }
}

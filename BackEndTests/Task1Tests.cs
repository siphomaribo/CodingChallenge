using System;
using System.Collections.Generic;
using System.Text;
using BackEnd;
using NUnit.Framework;

namespace BackEndTests
{
    public class Task1Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestForMultipleOfTwo()
        {
            //Arrange
            var input = "action";
            var expectedResult = "Stack";

            //Act
            var result = new Task1().GetWordMod(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestForMultipleOfFour()
        {
            //Arrange
            var input = "I don't know";
            var expectedResult = "Overflow";

            //Act
            var result = new Task1().GetWordMod(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestForMultipleOfTwoAndFour()
        {
            //Arrange
            var input = "name";
            var expectedResult = "Stack Overflow!";

            //Act
            var result = new Task1().GetWordMod(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

      
    }
}

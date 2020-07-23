using System.Collections.Generic;
using BackEnd;
using NUnit.Framework;

namespace BackEndTests
{
    public class Task2Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestThereAreNoLikes()
        {
            //Arrange
            var names = new List<string>();
            var expectedResult = "no one likes this";

            //Act
            var result = new Task2().ViewLikes(names);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestThereAreOnlyOneLike()
        {
            //Arrange
            var names = new List<string> { "Peter" };
            var expectedResult = "Peter likes this";

            //Act
            var result = new Task2().ViewLikes(names);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestThereAreOnlyTwoLikes()
        {
            //Arrange
            var names = new List<string> { "Jacob", "Alex" };
            var expectedResult = "Jacob and Alex like this";

            //Act
            var result = new Task2().ViewLikes(names);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestThereAreOnlyThreeLikes()
        {
            //Arrange
            var names = new List<string> { "Max", "John", "Mark" };
            var expectedResult = "Max, John and Mark like this";

            //Act
            var result = new Task2().ViewLikes(names);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void TestThereAreMoreThanFourLikes()
        {
            //Arrange
            var names = new List<string> {"Alex", "Jacob", "Mark", "Max"};
            var expectedResult = "Alex, Jacob and 2 others like this";

            //Act
            var result = new Task2().ViewLikes(names);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

     

    
    }
}
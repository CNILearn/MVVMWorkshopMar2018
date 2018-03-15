using System;
using Xunit;

namespace ClassLibForUnitTesting.Tests
{
    public class DemoTests
    {
        [Fact]
        public void TheAnswerOfTheUniverse_42()
        {
            // arrange
            int expected = 42;
            Demo d1 = new Demo();
            // act
            int actual = d1.TheAnswerOfTheUniverse();
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SomeStringHandlingShortString()
        {
            // arrange
            string expected = "ab";
            Demo d1 = new Demo();
            // act
            string actual = d1.SomeStringHandling("AB");
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SomeStringHandlingLongString()
        {
            // arrange
            string expected = "ABCDEF";
            Demo d1 = new Demo();
            // act
            string actual = d1.SomeStringHandling("abcdef");
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SomeStringHandling_ArgumentNullException()
        {
            // assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                // arrange
                Demo d1 = new Demo();
                // act
                string actual = d1.SomeStringHandling(null);
            });
        }
    }
}

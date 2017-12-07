using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UdemyLessons.UnitTests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(0, "FizzBuzz")]
        [InlineData(3000, "FizzBuzz")]
        [InlineData(-1, "-1")]
        [InlineData(-3, "Fizz")]
        [InlineData(-5, "Buzz")]
        [InlineData(-15, "FizzBuzz")]
        [InlineData(int.MinValue, "-2147483648")]
        [InlineData(int.MaxValue, "2147483647")]
        public void GetOutput_WhenArgument_ShouldReturnExpected(int argument, string expected)
        {
            // Arrange

            // Act
            string output = FizzBuzz.GetOutput(argument);

            // Assert
            Assert.Equal(expected, output);
        }
    }
}

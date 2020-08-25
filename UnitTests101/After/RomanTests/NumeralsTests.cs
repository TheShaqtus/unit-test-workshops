using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roman;

namespace RomanTests
{
    [TestClass]
    public class NumeralsTests
    {
        [TestMethod]
        public void ToRoman__Given_1__When_ConvertedToRomanNumerals__Then_ReturnI()
        {
            // Arrange
            const int number = 1;
            const string expectedNumerals = "I";

            // Act
            var actualNumerals = number.ToRoman();

            // Assert
            Assert.AreEqual(expectedNumerals, actualNumerals);
        }

        [TestMethod]
        public void ToRoman__Given_4__When_ConvertedToRomanNumerals__Then_ReturnIV()
        {
            // Arrange
            const int number = 4;
            const string expectedNumerals = "IV";

            // Act
            var actualNumerals = number.ToRoman();

            // Assert
            Assert.AreEqual(expectedNumerals, actualNumerals);
        }

        [TestMethod]
        public void ToRoman__Given_9__When_ConvertedToRomanNumerals__Then_ReturnIX()
        {
            // Arrange
            const int number = 9;
            const string expectedNumerals = "IX";

            // Act
            var actualNumerals = number.ToRoman();

            // Assert
            Assert.AreEqual(expectedNumerals, actualNumerals);
        }

        [TestMethod]
        public void ToRoman__Given_10__When_ConvertedToRomanNumerals__Then_ReturnX()
        {
            // Arrange
            const int number = 10;
            const string expectedNumerals = "X";

            // Act
            var actualNumerals = number.ToRoman();

            // Assert
            Assert.AreEqual(expectedNumerals, actualNumerals);
        }

        [TestMethod]
        public void ToRoman__Given_3999__When_ConvertedToRomanNumerals__Then_ReturnMMMCMXCIX()
        {
            // Arrange
            const int number = 3999;
            const string expectedNumerals = "MMMCMXCIX";

            // Act
            var actualNumerals = number.ToRoman();

            // Assert
            Assert.AreEqual(expectedNumerals, actualNumerals);
        }
    }
}

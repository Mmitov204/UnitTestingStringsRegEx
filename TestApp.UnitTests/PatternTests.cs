using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("joe", 2, "jOejOe")]
    [TestCase("sefan", 1 ,"sEfAn")]
    [TestCase("georgi", 6, "gEoRgIgEoRgIgEoRgIgEoRgIgEoRgIgEoRgI")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = "";
        int reputationFactor = 10 ;
        // Act


        // Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, reputationFactor),Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "JoeBanana";
        int reputationFactor = -10;
        // Act


        // Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, reputationFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "stefi";
        int reputationFactor = 0;
        // Act


        // Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, reputationFactor), Throws.ArgumentException);
    }
}

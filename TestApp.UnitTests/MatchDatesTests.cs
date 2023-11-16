using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    //TODO: finish the test
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string input = "31-Dec-2022 random";
        string expected = "Day: 31, Month: Dec, Year: 2022";
        // Act
        string result = MatchDates.Match(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "Invalid date format";
        string expected = string.Empty;

        // Act
        string result = MatchDates.Match(input);
        // Assert
       Assert.That(result,Is.EqualTo(expected)); 
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string input = "14-Jan-2005, 07.Nov.2004, 17/Jan/2008";
        string expected = "Day: 14, Month: Jan, Year: 2005";
        // Act
        string result = MatchDates.Match(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        string expected = string.Empty;

        // Act
        string result = MatchDates.Match(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string? input = null;
       

        // Act
        
        // Assert
        Assert.That(()=> MatchDates.Match(input), Throws.ArgumentException);
    }
}

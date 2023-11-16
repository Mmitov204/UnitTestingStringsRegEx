using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "man";
        string input = "A man is born free and is in chains all his life";

        // Act
        string reuslt = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(reuslt, Is.EqualTo("A is born free and is in chains all his life"));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "Immanuel";
        string input = "The book is by Immanuel Kant";

        // Act
        string reuslt = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(reuslt, Is.EqualTo("The book is by Kant"));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "mac";
        string input = "I love mac and cheese";

        // Act
        string reuslt = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(reuslt, Is.EqualTo("I love and cheese"));
    }


    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "MAC";
        string input = "MAC MAC MAC";

        // Act
        string reuslt = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(reuslt, Is.EqualTo(""));
    }
}
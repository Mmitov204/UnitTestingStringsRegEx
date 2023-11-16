using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "A man is born free and is in chains all his life"; ;
        string[] ban = new string[] { "Drink" };

        // Act
        string reuslt = TextFilter.Filter(ban, text);
        // Assert
        Assert.That(reuslt, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string text = "A man is born free and is in chains all his life"; 
        string[] ban = new string[] { "his" };
        string expected = "A man is born free and is in chains all *** life";

        // Act
        string reuslt = TextFilter.Filter(ban, text);
        // Assert
        Assert.That(reuslt, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "A man is born free and is in chains all his life"; ;
        string[] ban = Array.Empty<string>();

        // Act
        string reuslt = TextFilter.Filter(ban, text);
        // Assert
        Assert.That(reuslt, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string text = "A man is born free and is in chains all his life";
        string[] ban = new string[] { "man", "is", "born free" };
        string expected = "A *** ** ********* and ** in chains all h** life";

        // Act
        string reuslt = TextFilter.Filter(ban, text);
        // Assert
        Assert.That(reuslt, Is.EqualTo(expected));
    }
}

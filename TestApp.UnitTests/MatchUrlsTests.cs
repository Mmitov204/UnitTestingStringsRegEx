using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";
        List<string> expexted = new();
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.EquivalentTo(expexted));
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        string text = "No valid URLs!!!";
       
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "Single URL: \"https://www.youtube.com\"";
        List<string> expexted = new() { "https://www.youtube.com" };
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.EquivalentTo(expexted));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "Multiple URL: https://www.google.com ,https://www.bg-gledai.live ,https://onlineradiobox.com";
        List<string> expexted = new() { "https://onlineradiobox.com", "https://www.bg-gledai.live", "https://www.google.com" };
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.EquivalentTo(expexted));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "Single URL: \"\"https://www.youtube.com\"\"";
        List<string> expexted = new() { "https://www.youtube.com" };
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.EquivalentTo(expexted));
    }
}

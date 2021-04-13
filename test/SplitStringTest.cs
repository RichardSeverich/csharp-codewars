using NUnit.Framework;
using System;


namespace csharp_codewars
{
    [TestFixture]
    class SplitStringTest
    {
        [Test]
        [TestCase("Unscrupulous", 2, ExpectedResult = new string[] { "Unscru", "pulous" })]
        [TestCase("Incomprehensible", 4, ExpectedResult = new string[] { "Inco", "mpre", "hens", "ible" })]
        [TestCase("Evaluation", 10, ExpectedResult = new string[] { "E", "v", "a", "l", "u", "a", "t", "i", "o", "n" })]
        [TestCase("Strengthened", 6, ExpectedResult = new string[] { "St", "re", "ng", "th", "en", "ed" })]
        [TestCase("Fool's Errand", 20, ExpectedResult = new string[] { "Error" })]
        [TestCase("Flavorless", 1, ExpectedResult = new string[] { "Flavorless" })]
        [TestCase("Evolutionary Biology", 8, ExpectedResult = new string[] { "Error" })]
        [TestCase("Indefatigable Defender", 2, ExpectedResult = new string[] { "Indefatigab", "le Defender" })]
        [TestCase("Unimaginatively", 3, ExpectedResult = new string[] { "Unima", "ginat", "ively" })]
        [TestCase("Peppered Moth", 6, ExpectedResult = new string[] { "Error" })]

        public static string[] SplitNCases(string input, int cases)
        {
            return SplitString.SplitNCases(input, cases);
        }
    }
}

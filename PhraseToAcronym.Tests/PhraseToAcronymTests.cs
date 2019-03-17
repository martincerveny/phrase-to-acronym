using NUnit.Framework;

namespace PhraseToAcronym.Tests
{
    public class Tests
    {
        [TestCase("")]
        public void ReturnsEmptyString_When_InputIsEmptyString(string phrase)
        {
            Assert.That(PhraseToAcronym.MakeAcronym(phrase), Is.EqualTo(""));
        }

        [TestCase(null)]
        public void ReturnsEmptyString_When_InputIsNull(string phrase)
        {
            Assert.That(PhraseToAcronym.MakeAcronym(phrase), Is.EqualTo(""));
        }
        
        [TestCase("Don't repeat yourself")]
        public void ReturnsDRY_When_InputIsDontRepeatYourself(string phrase)
        {
            Assert.That(PhraseToAcronym.MakeAcronym(phrase), Is.EqualTo("DRY"));
        }
        
        [TestCase("Asynchronous Javascript and XML")]
        public void ReturnsAJAX_When_InputIsAsynchronousJavascriptAndXML(string phrase)
        {
            Assert.That(PhraseToAcronym.MakeAcronym(phrase), Is.EqualTo("AJAX"));
        }
        
        [TestCase("Complementary metal-oxide semiconductor")]
        public void ReturnsCMOS_When_InputIsComplementaryMetalOxideSemiconductor(string phrase)
        {
            Assert.That(PhraseToAcronym.MakeAcronym(phrase), Is.EqualTo("CMOS"));
        }
    }
}
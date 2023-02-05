using CodeWars._6Kyu.CountCharactersInYourString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSampleTests
{
    [TestFixture]
    public class _6KyuTests
    {
        [Test]
        [TestCase(new Dictionary<char, int> { {'a',4 } },"aaaa")]
        public static void CountCharactersInYourString(Dictionary<char, int> expected, string text)
        {
            //Arrange

            //Act
            var result = CountCharactersInYourStringSolutions.Solution(text);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }

    public string ToAssertableString(IDictionary<string, List<string>> dictionary)
    {
        var pairStrings = dictionary.OrderBy(p => p.Key)
                                    .Select(p => p.Key + ": " + string.Join(", ", p.Value));
        return string.Join("; ", pairStrings);
    }
}

using SqueakyClean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeZone.UnitTests
{
    [TestFixture]
    public class IdentifierTests
    {
        [Test]
        public void Clean_StringContainsBlankSpaces_ReplaceBlankSpacesWithDash() 
        {
            string word = "impos  sible";

            var result = Identifier.Clean(word);

            Assert.That(result, Is.EqualTo("impos__sible"));
        }

        [Test]
        public void Clean_StringContainsControlCharacter_ReplaceControlCharacterWithCTRL()
        {
            string word = "my\0Id";

            var result = Identifier.Clean(word);

            Assert.That(result, Is.EqualTo("myCTRLId"));
        }

        [Test]
        public void Clean_StringIsNull_ReturnString()
        {
            string word = null;

            var result = Identifier.Clean(word);

            Assert.That(result, Is.Null);
        }


        [Test]
        public void Clean_StringIsEmpty_ReturnString()
        {
            string word = "";

            var result = Identifier.Clean(word);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Clean_StringIsKebabCase_ConvertStringToCamelCase()
        {
            string word = "my-origin";

            var result = Identifier.Clean(word);

            Assert.That(result, Is.EqualTo("myOrigin"));
        }

        [Test]
        public void Clean_NotAllCharactersAreLetters_OmitCharactersThatAreNotLetters()
        {
            string word = "1😀2😀3😀";

            var result = Identifier.Clean(word);

            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void Clean_StringContainsGreekLowerCase_OmitGreekLowerCaseLetters()
        {
            string word = "MyΟβιεγτFinder";

            var result = Identifier.Clean(word);

            Assert.That(result, Is.EqualTo("MyΟFinder"));
        }
    }
}

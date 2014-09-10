using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace MostCommonCharacter.UnitTesting
{
    public class NUnitTest : AssertionHelper
    {
        [TestCase("aab")]
        [TestCase("aaab")]
        public void MostCommonChar(string word)
        {
            int[] charCount = new int[1000];
            char maxChar = ' ';
            int maxCount = 0;

            for (var i = word.Length - 1; i >= 0; i++)
            {
                char currentChar = word[i];

                if (++charCount[currentChar] >= maxCount)
                {
                    maxChar = currentChar;
                    maxCount = charCount[currentChar];
                }
            }

            // Inherited syntax
            Expect(maxChar, EqualTo('a'));
        }


        /*[Test]
        public void SumOfTwoNumbers()
        {
            Assert.AreEqual(10, 5 + 5);
        }

        [Test]
        public void AreValuesTheSame()
        {
            Assert.AreSame(10, 5 + 6);
        }

        [Test]
        public void AreValuesNotEqual()
        {
            Assert.AreNotEqual(5, 5);
        }*/
    }
}

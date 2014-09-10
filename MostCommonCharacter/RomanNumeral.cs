using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTest.UnitTesting
{
    class RomanNumeral : AssertionHelper
    {

        public int convert(string input)
        {
            int totalNumber = 0;
            int previousNumber = 0;

            for (var i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                int currentNumber = convertCharToNumber(currentChar);

                if (previousNumber < currentNumber)
                {
                    totalNumber += (currentNumber - previousNumber * 2);
                }
                else
                {
                    totalNumber += currentNumber;
                }

                previousNumber = currentNumber;
            }


            return totalNumber;
        }

        public int convertCharToNumber(int currentChar)
        {
            switch (currentChar)
            {
                case 'i':
                    return 1;
                case 'v':
                    return 5;
                case 'x':
                    return 10;
                default:
                    return 0;
            }
        }

        [Test]
        public void input_is_i()
        {
            Expect(convert("i"), EqualTo(1));
        }

        [Test]
        public void input_is_v()
        {
            Expect(convert("v"), EqualTo(5));
        }

        [Test]
        public void input_is_x()
        {
            Expect(convert("x"), EqualTo(10));
        }

        [Test]
        public void input_is_xv()
        {
            Expect(convert("xv"), EqualTo(15));
        }

        [Test]
        public void input_is_ii()
        {
            Expect(convert("ii"), EqualTo(2));
        }

        [Test]
        public void input_is_iv()
        {
            Expect(convert("iv"), EqualTo(4));
        }

        [Test]
        public void input_is_xiv()
        {
            Expect(convert("xiv"), EqualTo(14));
        }

        [Test]
        public void input_is_ix()
        {
            Expect(convert("ix"), EqualTo(9));
        }
    }
}

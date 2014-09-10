using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTest.UnitTesting
{
    [TestFixture]
    class LeastCommonMultiple : AssertionHelper
    {

        public int LCM(int[] input)
        {
            int currentLCM = 0;

            for (var i = input.Length - 1; i >= 0; i--)
            {
                if (i == (input.Length - 1))
                {
                    int[] modifyInput = { input[i], input[i - 1] };
                    currentLCM = calculateLCM(modifyInput);
                    i--;
                }
                else
                {
                    int[] modifyInput = { input[i], currentLCM };
                    currentLCM = calculateLCM(modifyInput);
                }

            }

            return currentLCM;

        }

        public int calculateLCM(int[] input)
        {
            int firstNumber = input[0];
            int secondNumber = input[1];

            int firstNumberMult = 1;
            int secondNumberMult = 1;

            var LCM = -1;

            while (LCM < 0)
            {
                int currentFirst = firstNumber * firstNumberMult;
                int currentSecond = secondNumber * secondNumberMult;

                if (currentFirst < currentSecond)
                {
                    firstNumberMult++;
                }
                else if (currentFirst > currentSecond)
                {
                    secondNumberMult++;
                }
                else
                {
                    LCM = currentFirst;
                }
            }

            return LCM;
        }

        [Test]
        public void LCM_1_And_2()
        {
            int[] input = { 1, 2 };
            Expect(LCM(input), EqualTo(2));
        }

        [Test]
        public void LCM_3_And_5()
        {
            int[] input = { 3, 5 };
            Expect(LCM(input), EqualTo(15));
        }

        [Test]
        public void LCM_9_And_12()
        {
            int[] input = { 9, 12 };
            Expect(LCM(input), EqualTo(36));
        }

        [Test]
        public void LCM_1_And_2_And_3()
        {
            int[] input = { 1, 2, 3 };
            Expect(LCM(input), EqualTo(6));
        }

        [Test]
        public void LCM_5_And_7_And_20()
        {
            int[] input = { 5, 7, 20 };
            Expect(LCM(input), EqualTo(140));
        }

        [Test]
        public void LCM_1_And_5_And_9_And_10_And_15_And_15_And_25_And_30()
        {
            int[] input = { 1, 5, 9, 10, 15, 25, 30 };
            Expect(LCM(input), EqualTo(450));
        }
    }
}

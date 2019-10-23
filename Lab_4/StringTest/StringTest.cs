using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringEdit;

namespace StringTest
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void ConvertLetterToUp1()
        {
            String str1 = "Привет.         как дела";
            str1 = StrEdit.ConvertLettersUp(str1);
            String expected = "Привет. Как дела.";
            Assert.AreEqual(expected, str1);
        }

        [TestMethod]
        public void ConvertLetterToUp2()
        {
            String str1 = "Рыбак ловит рыбу.   Плавец плывёт. человек побежал";
            str1 = StrEdit.ConvertLettersUp(str1);
            String expected = "Рыбак ловит рыбу. Плавец плывёт. Человек побежал.";
            Assert.AreEqual(expected, str1);
        }

        [TestMethod]
        public void ConvertLetterToUp3()
        {
            String str1 = "Let's go to river. i want swiming";
            str1 = StrEdit.ConvertLettersUp(str1);
            String expected = "Let's go to river. I want swiming.";
            Assert.AreEqual(expected, str1);
        }

        [TestMethod]
        public void ConvertRubToUsd_nine()
        {
            String actual = StrEdit.ConvertRubToUsd("nine");
            String expected = "eighteen";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRubToUsd_TwentyNine()
        {
            String actual = StrEdit.ConvertRubToUsd("twenty NINE");
            String expected = "fifty eight";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertRubToUsd_NineThousandNineHundredNinetyNine()
        {
            String actual = StrEdit.ConvertRubToUsd("Nine thousand nine hundred ninety NINE");
            String expected = "nineteen thousand nine hundred ninety eight";
            Assert.AreEqual(expected, actual);
        }
    }
}

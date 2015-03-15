using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace LogicTests
{
    [TestClass]
    public class CodebreakerTests
    {
        [TestMethod]
        public void Guess__FirstGuessIs_WWBB()
        {
            var sut = new Codebreaker();
            var actual = sut.Guess("");
            const string expected = "WWBB";
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Guess__CodeIsBYGB_SecondGuessIs_YYGG()
        {
            var sut = new Codebreaker();
            Assert.AreEqual("WWBB", sut.Guess(""));
            var actual = sut.Guess("");
            const string expected = "YYGG";
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Guess__CodeIsWWWW_GuessWWBB_GuesYYGG_GuessBBRR()
        {
            var sut = new Codebreaker();
            Assert.AreEqual("WWBB", sut.Guess(""));
            Assert.AreEqual("YYGG", sut.Guess("WW"));
            var actual = sut.Guess("");
            const string expected = "BBRR";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Guess__CodeIsBBWW_SecondGuessIs_BBWW()
        {
            var sut = new Codebreaker();
            Assert.AreEqual("WWBB", sut.Guess(""));
            var actual = sut.Guess("BBBB");
            const string expected = "BBWW";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Guess__CodeIsGGYY_ThirdGuessIs_GGYY()
        {
            var sut = new Codebreaker();
            Assert.AreEqual("WWBB", sut.Guess(""));
            Assert.AreEqual("YYGG", sut.Guess(""));
            var actual = sut.Guess("BBBB");
            const string expected = "GGYY";
            Assert.AreEqual(expected, actual);
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using fractionСlassLibrary;


namespace UnitTestProject1
{
    [TestClass]
    public class factoriotest
    {
        [TestMethod]
        public void AreNotEqual_Test()
        {
            //arc
            string text = "1/1";
            //arrange
            Drob obj = new Drob();
            string result = obj.FixWrongResult(text);
            string expt = "10/10";
            //assets
            Assert.AreNotEqual(expt, result);

        }

        [TestMethod]
        public void FractionTest_Correct_True()
        {
            //arc
            string text = "1/10";
            //arrange
            Drob obj = new Drob();
            string result = obj.FixWrongResult(text);
            string expt = "1/10";
            //assets
            Assert.AreEqual(expt, result);
        }
        [TestMethod]
        public void FractionTest_CorrectReplace_True()
        {
            //arc
            string text = "256/10";
            //arrange
            Drob obj = new Drob();
            string result = obj.FixWrongResult(text);
            string expt = "10/10";
            //assets
            Assert.AreEqual(expt, result);
        }
        [TestMethod]
        public void FractionTest_CorrectMinus_True()
        {
            //arc
            string text = "-10/10";
            //arrange
            Drob obj = new Drob();
            string result = obj.FixWrongResult(text);
            string expt = "-10/10";
            //assets
            Assert.AreEqual(expt, result);
        }
        
        
        [TestMethod]
        public void FractionTest_Empty_False()
        {
            //arc
            string text = "";
            //arrange
            Drob obj = new Drob();
            
            Action actiona = () => obj.FixWrongResult(text);
            
            //assets
            Assert.ThrowsException<Exception>(actiona);
        }
        [TestMethod]
        public void FractionTest_EmptyDash_False()
        {
            //arc
            string text = "/";
            //arrange
            Drob obj = new Drob();

            Action actiona = () => obj.FixWrongResult(text);

            //assets
            Assert.ThrowsException<Exception>(actiona);
        }
        [TestMethod]
        public void FractionTest_Manynumber_False()
        {
            //arc
            string text = "35/10/10/25";
            //arrange
            Drob obj = new Drob();

            Action actiona = () => obj.FixWrongResult(text);

            //assets
            Assert.ThrowsException<Exception>(actiona);
        }

        [TestMethod]
        public void FractionTest_letters_False()
        {
            //arc
            string text = "35/1b";
            //arrange
            Drob obj = new Drob();

            Action actiona = () => obj.FixWrongResult(text);

            //assets
            Assert.ThrowsException<FormatException>(actiona);
        }


        [TestMethod]
        public void FractionTest_onlynumbers_False()
        {
            //arc
            string text = "3512";
            //arrange
            Drob obj = new Drob();

            Action actiona = () => obj.FixWrongResult(text);

            //assets
            Assert.ThrowsException<IndexOutOfRangeException>(actiona);
        }
    }
}
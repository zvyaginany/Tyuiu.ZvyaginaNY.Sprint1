using Tyuiu.ZvyaginaNY.Sprint1.Task6.V8.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMoveFirstLetterToEnd()
        {
            DataService ds = new DataService();
            string text = "hello world";
            string wait = "elloh orldw";
            string res = ds.MoveFirstLetterToEnd(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void SingleWord()
        {
            DataService ds = new DataService();
            string text = "programming";
            string wait = "rogrammingp";
            string res = ds.MoveFirstLetterToEnd(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void MultipleWordsWithPunctuation()
        {
            DataService ds = new DataService();
            string text = "Hello, world! How are you?";
            string wait = "elloH, orldw! owH rea ouy?";
            string res = ds.MoveFirstLetterToEnd(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void WordsWithNumbers()
        {
            DataService ds = new DataService();
            string text = "test123 word456";
            string wait = "estt123 ordw456";
            string res = ds.MoveFirstLetterToEnd(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void SingleLetterWords()
        {
            DataService ds = new DataService();
            string text = "a b c d";
            string wait = "a b c d";
            string res = ds.MoveFirstLetterToEnd(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void EmptyString()
        {
            DataService ds = new DataService();
            string text = "";
            string wait = "";
            string res = ds.MoveFirstLetterToEnd(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void WhitespaceOnly()
        {
            DataService ds = new DataService();
            string text = "   \t\n";
            string wait = "   \t\n";
            string res = ds.MoveFirstLetterToEnd(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void MixedCaseWords()
        {
            DataService ds = new DataService();
            string text = "Hello WORLD Test";
            string wait = "elloH ORLDW estT";
            string res = ds.MoveFirstLetterToEnd(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void WordsWithHyphens()
        {
            DataService ds = new DataService();
            string text = "well-known test-case";
            string wait = "ellw-known estt-case";
            string res = ds.MoveFirstLetterToEnd(text);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ComplexText()
        {
            DataService ds = new DataService();
            string text = "The quick brown fox jumps over the lazy dog.";
            string wait = "heT uickq rownb oxf umpsj vero het azyl ogd.";
            string res = ds.MoveFirstLetterToEnd(text);
            Assert.AreEqual(wait, res);
        }
    }
}
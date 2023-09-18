using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringCheckLibrary;


namespace UnitTestProject1
{
    [TestClass]
    public class StringCheckLibraryTests
    {
        /// <summary>
        /// Тестирование на пустую строку
        /// </summary>
        [TestMethod]
        public void CheckName_isEmpty_falseReturned()
        {
            //Arrange
            string stringName="";
            //Act
            StringCheck obj = new SrtingCheck();
            bool result = obj.CheckName(StringName);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Тестирование на корректное имя
        /// </summary>
        [TestMethod]
        public void CheckName_isCorectName_trueReturned()
        {
            //Arrange
            string stringName = "Важенина-ина Ульяна";
            //Act
            StringCheck obj = new SrtingCheck();
            bool result = obj.CheckName(StringName);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Тестирование на некорректное имя(латинские буквы)
        /// </summary>
        [TestMethod]
        public void CheckName_isLatinеLetters_falseReturned()
        {
            //Arrange
            string stringName = "Vazhenina Ulyana";
            //Act
            StringCheck obj = new SrtingCheck();
            bool result = obj.CheckName(StringName);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Тестирование на некорректное имя(спец символы)
        /// </summary>
        [TestMethod]
        public void CheckName_isSpecialSymbol_falseReturned()
        {
            //Arrange
            string stringName = "Важенина123 Ульяна#";
            //Act
            StringCheck obj = new SrtingCheck();
            bool result = obj.CheckName(StringName);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Тестирование на некорректное имя(только тире)
        /// </summary>
        [TestMethod]
        public void CheckName_isTire_falseReturned()
        {
            //Arrange
            string stringName = " ----";
            //Act
            StringCheck obj = new SrtingCheck();
            bool result = obj.CheckName(StringName);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Тестирование на некорректное имя(больше 50 символов)
        /// </summary>
        [TestMethod]
        public void CheckName_isMoreThan50_falseReturned()
        {
            //Arrange
            string stringName = "Важенина Ульянаааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааподвжлапьлваитловаыподулкптва";
            //Act
            StringCheck obj = new SrtingCheck();
            bool result = obj.CheckName(StringName);
            //Assert
            Assert.IsFalse(result);
        }

    }
}

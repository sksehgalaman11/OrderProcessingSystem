using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessingSystem;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystemUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Positive Test case scenario 
        /// </summary>
        [TestMethod]
        public void ClientFirstNameCheck()
        {
            // Arrange
            Client ClientObj = new Client();
            // Act
            ClientObj.FirstName = "Aman";
            // Assert
            Assert.AreEqual("Aman", ClientObj.FirstName, "Name mismatch");
        }

        /// <summary>
        /// Negetive test case scenario
        /// </summary>
        [TestMethod]
        public void ClientLastNameCheck()
        {
            // Arrange
            Client ClientObj = new Client();
            // Act
            ClientObj.LastName = "Sehgal";
            // Assert
            Assert.AreEqual("Sehgal", ClientObj.FirstName, "Name mismatch");
        }

        /// <summary>
        /// Positive Test case scenario
        /// </summary>
        [TestMethod]
        public void ClientLastNameCheck2()
        {
            // Arrange
            Client ClientObj = new Client();
            // Act
            ClientObj.LastName = "Sehgal";
            // Assert
            Assert.AreEqual("Sehgal", ClientObj.LastName, "Name mismatch");
        }

        /// <summary>
        /// Positive test case scenario
        /// </summary>
        [TestMethod]
        public void BookDetails()
        {
            // Arrange
           BookProduct bookObj = new BookProduct();
            // Act
           var _bookvar =  bookObj.BookDetails("Mybook");
            // Assert
            Assert.AreEqual("book order Successful: Mybook", _bookvar, "Name mismatch");
        }


        /// <summary>
        /// Negetive test case scenario
        /// </summary>
        [TestMethod]
        public void BookDetails2()
        {
            // Arrange
            BookProduct bookObj = new BookProduct();
            // Act
            var _bookvar = bookObj.BookDetails("Mybook");
            // Assert
            Assert.AreEqual("book order Successful: Mybook", _bookvar, "Name mismatch");
        }

    }
  
}

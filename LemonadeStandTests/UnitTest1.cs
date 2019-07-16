using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lemonadeStand;

namespace LemonadeStandTests
{
    [TestClass]
    public class LemonadeStandUnitTests
    {
        [TestMethod]
        public void Multiply_TenLemons_ReturnsCorrectValue()
        {
            //Arrange
            Store store = new Store();
            double lemonsNeeded = 10;
            double totalMoney = 20;
            double result;
            double expectedResult = totalMoney - (lemonsNeeded * .02);
            //Act
            result = store.PurchaseLemons(10, 20);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Multiply_ManyLemons_NegativeValueAllowed()
        {
            //Arrange
            Store store = new Store();
            double lemonsNeeded = 200000;
            double totalMoney = 20;
            double result;
            double expectedResult = totalMoney - (lemonsNeeded * .02);
            //Act
            result = store.PurchaseLemons(200000, 20);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CheckValue_NoLemons_ShouldReturnEmpty()
        {
            //Arrange
            Lemon lemon = new Lemon();

            bool result;
            bool expectedResult = true;
            //Act
            result = lemon.CheckEmpty(0, 1);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CheckValue_ManyLemons_ShouldReturnNotEmpty()
        {
            //Arrange
            Lemon lemon = new Lemon();

            bool result;
            bool expectedResult = false;
            //Act
            result = lemon.CheckEmpty(1230498112341234, 1);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Add_EndOfDayInventoryTotals_ShouldReturnTwenty()
        {
            //Arrange
            Day testDay = new Day();
            double result;
            double totalLemons = 0;
            double totalSugar = 0;
            double totalMoney = 20;
            double totalCups = 0;
            double expectedResult = totalMoney + (totalLemons * .02) + (totalSugar * .02) + (totalCups * .02);
            //Act
            result = testDay.LiquidationSummation(0, 0, 0, 20);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Add_EndOfDayInventoryTotals_ShouldReturnZero()
        {
            //Arrange
            Day testDay = new Day();
            double result;
            double totalLemons = 500;
            double totalSugar = 500;
            double totalMoney = 20;
            double totalCups = 500;
            double expectedResult = totalMoney + (totalLemons * .02) + (totalSugar * .02) + (totalCups * .02);
            //Act
            result = testDay.LiquidationSummation(500, 500, 500, 20);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}

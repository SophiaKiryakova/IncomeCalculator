using IncomeCalculator.Utilities.Contracts;
using NUnit.Framework;
using System;

namespace IncomeCalculator.Utilities.Tests
{
    public class Tests
    {
        private IIncomeInputValidator _incomeInputValidator;

        [SetUp]
        public void Setup()
        {
            _incomeInputValidator = new IncomeInputValidator();
        }

        [Test]
        public void ValidateNames_ShouldThrowException_WhenNamesAreNull()
        {
            string names = null;

            var ex = Assert.Throws<Exception>(() => _incomeInputValidator.ValidateNames(names)); ;

            Assert.That(ex.Message, Is.EqualTo("Tax Payer's name cannot be null."));
        }
    }
}
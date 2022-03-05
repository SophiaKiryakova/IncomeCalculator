using IncomeCalculator.Utilities.Contracts;

namespace IncomeCalculator.Utilities
{
    public class IncomeInputValidator: IIncomeInputValidator
    {
        public void ValidateNames(string names)
        {
            if (names == null)
            {
                throw new Exception("Tax Payer's name cannot be null.");
            }

            var namesArr = names.Split(' ');

            if (namesArr.Length < 2)
            {
                throw new Exception("At least two names should be provided");
            }

            foreach (var name in namesArr)
            {
                if (!name.All(char.IsLetter))
                {
                    throw new Exception("A name should contain only letters");
                }
            }
        }

        public void ValidateSSN(int ssn)
        {
            var ssnLength = ssn.ToString().Length;

            if (ssn < 0 || ssnLength < 5 || ssnLength > 10)
            {
                throw new Exception("SSN is invalid. Should be a positive number between 5 and 10 digits.");
            }
        }

        public void ValidateGrossIncome(decimal grossIncome)
        {
            if (grossIncome < 0)
            {
                throw new Exception("Gross income is invalid. Should be a positive number.");
            }
        }

        public void ValidateCharitySpent(decimal? charitySpent)
        {
            if (charitySpent != null && charitySpent < 0)
            {
                throw new Exception("Charity spent is invalid. Should be a positive number.");
            }
        }
    }
}
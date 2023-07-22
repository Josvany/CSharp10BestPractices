namespace carvedrock.bl.CleanClassesAndMethods.Static
{
    public class BankAccount
    {
        public string AccountName = null!; // Instance member

        public decimal Balance; // Instance member

        public decimal InterestRate; // Shared member

        public void GetPrice(decimal price, string twoLetterStateCode)
        {
            /// Multiple calculations made
            decimal tax = CheckoutFunctions.CalculateTax(price, twoLetterStateCode);
            /// <summary>
            /// A set of additional calculations
            /// </summary>
        }
    }
}
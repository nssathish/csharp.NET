using System;

namespace DesignPatterns
{

    /// <summary>
    /// Method call that uses abstract classes and it's implementations, to
    /// give the developer the most appropriate class for the job
    /// </summary>
    public abstract class Transaction
    {
        private string _soruceAccount;
        private string _destinationAccount;
        private decimal _amount;

        public decimal Amount { get; set; }

        private DateTime _transactionDate;
        private DateTime _effectiveDate;

        public Transaction(string source, string destination, decimal amount)
        {
            this._soruceAccount = source;
            this._destinationAccount = destination;
            this.Amount = amount;
            _transactionDate = DateTime.Now;
        }
        public Transaction(string source, string destination, decimal amount, DateTime effectivedate) : this (source,destination,amount)
        {
            this._effectiveDate = effectivedate;
        }
        protected decimal AdjustBalance (string accountNumber, decimal amount)
        {
            decimal newBalance = Decimal.MinValue;
            return newBalance;
        }
        public abstract bool Complete();
    }

    public class Credit : Transaction
    {
        private string _sourceAccount;
        private string _destinationAccount;
        private decimal amount;

        public Credit(string sourceAccount, string _destinationAccount, decimal amount)
            : base(sourceAccount, _destinationAccount, amount)
        {
            _sourceAccount = sourceAccount;
            this.amount = amount;
        }

        public override bool Complete()
        {
            this.AdjustBalance(_sourceAccount, amount);
            return true;
        }
    }
    public class FactoryPattern
    {

    }
}

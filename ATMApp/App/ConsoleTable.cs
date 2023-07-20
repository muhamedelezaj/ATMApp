using ATMApp.Domain.Enums;

namespace ATMApp
{
    internal class ConsoleTable
    {
        internal object Options;
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;

        public ConsoleTable(string v1, string v2, string v3, string v4, string v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        internal void AddRow(long transactionId, DateTime transactionDate, TransactionType transactionType, string descriprion, decimal transactionAmount)
        {
            throw new NotImplementedException();
        }

        internal void Write()
        {
            throw new NotImplementedException();
        }
    }
}
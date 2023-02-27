using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Bank
    {
        public int ACCOUNTNO;
        public string BankerName;
        public string AccountType;
        public string TransactionType;
        public double amount;
        public double balance = 2000;

        public void GetDetails()
        {
            Console.WriteLine("Enter Account Number:");
            this.ACCOUNTNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer's Name:");
            this.BankerName = Console.ReadLine();
            Console.WriteLine("Enter Account Type:");
            this.AccountType = Console.ReadLine();
            Console.WriteLine("Enter Transaction Type (d->deposit / w->withdrawal):");
            this.TransactionType = Console.ReadLine();
            Console.WriteLine("Enter Amount:");
            this.amount = Convert.ToDouble(Console.ReadLine());
            if (TransactionType == "d")
            {
                TransactionType = "Deposit";
                balance = balance + amount;
            }
            else if (TransactionType == "w" && amount < balance)
            {
                TransactionType = "Withdrawal";
                balance = balance - amount;
            }
            else if (TransactionType == "w" && amount > balance)
            {
                TransactionType = "Transaction is not possible.";
            }
            Console.WriteLine($"Account Number: {ACCOUNTNO}  Customer's Name: {BankerName} Account Type: {AccountType} Tansaction Type: {TransactionType} Amount: {amount} Remaining Balance: {balance}");
        }

    }
}

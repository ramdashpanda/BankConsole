using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class SavingAccount : Account
    {
        public SavingAccount()
        {
        }
        public SavingAccount(int accountno)
        {
            AccountNumber = accountno;
        }
        public override void DepositAmount(double amount)
        {
            Amount += amount;
        }
        public override void WithdrawAmount(double amount)
        {

            if (amount < Amount)
            {
                Amount -= amount;
            }
            else
                Console.WriteLine("You Do not have sufficent balance to Withdraw.");
        }

        public override void ShowAccountDetails()
        {
            Console.WriteLine("**************************************\n");
            Console.WriteLine("Name of the Account Holder : {0}", AccountHolderName);
            Console.WriteLine("Account Number: {0}", AccountNumber);
            Console.WriteLine("After Withdraw Amount balnace is : {0}", Amount);
            Console.WriteLine("**************************************\n");
        }

    }
}

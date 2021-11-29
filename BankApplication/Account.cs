using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Account
    {
        public string AccountHolderName { get; set; }
        public int AccountNumber { get; set; }
        public double Amount { get; set; }

        public virtual void DepositAmount(double amount)
        {

        }
        public virtual void WithdrawAmount(double amount)
        {

        }
        public virtual void ShowAccountDetails()
        {

        }
    }
}

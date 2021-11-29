using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BankApplication
{
    public class Customer
    {
        public string Name { get; set; }

        public List<Account> Accounts { get; set; }

        public Customer()
        {

        }

        public Customer(bool hasDefaultData)
        {
            if(hasDefaultData)
            {
                Name = "Ramdash";
                Accounts = new List<Account>();
                Accounts.Add(new SalaryAccount(12));
                Accounts.Add(new SavingAccount(1234));
                Accounts.Add(new SavingAccount(12345));
                Accounts.Add(new FixedAccount(123456));
                Accounts.Add(new FixedAccount(123));
            }            
        }
    }
}

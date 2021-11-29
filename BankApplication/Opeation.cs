using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Opeation
    {
        public void Banking(Customer Customer)
        {
            try
            {
                char selectAccount = 'N';
                do
                {
                    Account Acct = null;
                    int allaccount;
                    Console.WriteLine("Please select your Account");
                    Console.WriteLine("\nPlease Press 1 for Saving Account. \n  And Press 2 for Salary Account. \n  And Press 3 for Fixed Deposite.");
                    allaccount = Convert.ToInt32(Console.ReadLine());

                    switch (allaccount)
                    {
                        case 1:
                            Acct = new SavingAccount();
                            break;
                        case 2:
                            Acct = new SalaryAccount("Prorigo");
                            break;
                        case 3:
                            Acct = new FixedAccount();
                            break;
                        default:
                            Console.WriteLine("Invalid Selection!!!");
                            break;
                    }
                    if (Acct != null)
                    {
                        Customer.Accounts = new List<Account>();
                        Acct.AccountHolderName = Customer.Name;
                        Console.WriteLine("Please insert new account number :");
                        Acct.AccountNumber = Convert.ToInt32(Console.ReadLine());

                        Customer.Accounts.Add(Acct);
                        Transaction(Customer);
                    }
                    Console.WriteLine("\nDo you want to continue? (y/n)");
                    selectAccount = Convert.ToChar(Console.ReadLine());
                } while (selectAccount.ToString().ToLower() == "y");

            }
            catch (Exception ex)
            {

            }
        }
        public void Transaction(Customer Customer)
        {
            try
            {
                char findAccount = 'N';
                Console.WriteLine("WELCOME TO YOUR ACCOUNT");

                do
                {
                   
                    Console.WriteLine("***************************");
                    Console.WriteLine("Selet your Account");

                    Console.WriteLine("Enter Account Number  :");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());

                    if (Customer.Accounts != null)
                    {
                        foreach (var item in Customer.Accounts)
                        {

                            if (item.AccountNumber == accountNumber)

                            {
                                double finalAmount = ConfirmTransation(item);
                                item.Amount = finalAmount;
                            }

                            else
                                Console.WriteLine("No Account Found !");
                        }
                    }
                    
                   
                    Console.WriteLine("\nDo you want to continue? (y/n)");
                    findAccount = Convert.ToChar(Console.ReadLine());

                } 
                while (findAccount.ToString().ToLower() == "y") ;
            }
            catch (Exception ex)
            { }
        }

        public double ConfirmTransation(Account Acct)
        {
            try
            {

                if (Acct != null)
                {
                    Console.WriteLine("\n Press 1 for Deposit an Amount. \n Press 2 for Withdraw an Amount. \n Press 3 for viwe the details");
                    int saveamount = Convert.ToInt32(Console.ReadLine());

                    switch (saveamount)
                    {
                        case 1:
                            Console.WriteLine("Enter Deposit Amount :");
                            double Deposit = Convert.ToDouble(Console.ReadLine());
                            Acct.DepositAmount(Deposit);
                            break;
                        case 2:
                            Console.WriteLine("Enter Withdraw Amount :");
                            double withdraw = Convert.ToDouble(Console.ReadLine());
                            Acct.WithdrawAmount(withdraw);
                            break;
                        case 3:                            
                            Acct.ShowAccountDetails();
                            break;
                        default:
                            Console.WriteLine("Invalid Selection!!!");
                            break;
                    }

                }
                return Acct.Amount;
            }
            catch (Exception ex)
            { return 0; }
        }
    }
}

using System;
using System.Collections.Generic;

namespace BankApplication
{    
    class Program
    {
        
      
        static void Main(string[] args)
        {
            char  choiceCustomer = 'N';
            List<Customer> CustomerList = new List<Customer>();

            do
            {
                Customer customer = null;

                Console.WriteLine("******** WELCOME ***********");
                Console.WriteLine("\nPlease Press 1 for New Customer. \n   Press 2 Existing Customer. \n   Press 3 List All Customer.");
                int customerOptions = Convert.ToInt32(Console.ReadLine());

                switch (customerOptions)
                {
                    case 1:
                        customer = new Customer();
                        Console.WriteLine("\nEnter Cutomer Name: ");
                        customer.Name = Console.ReadLine();
                        CustomerList.Add(customer);
                        break;
                    case 2:                       
                        if (CustomerList != null && CustomerList.Count > 0)
                        {
                            Console.WriteLine("\nEnter Cutomer Name To Search: ");
                            string name = Console.ReadLine();
                            foreach (var item in CustomerList)
                            {
                                if (item.Name.ToLower() == name.ToLower())
                                    customer = item;
                            }

                            if(customer == null)
                                Console.WriteLine("No Customer Found!");
                        }
                        else
                        {
                            Console.WriteLine("No Customer Exists in the system!");
                        }
                        break;
                    case 3:
                        if(CustomerList != null && CustomerList.Count > 0)
                        {
                            foreach (var item in CustomerList)
                            {
                                Console.WriteLine("Name - {0}", item.Name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Customer Found!");
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                }

                if(customer != null)
                {
                    Console.WriteLine("\nDo you want to create account for {0} ? (y/n)", customer.Name);
                    char choiceAccount = Convert.ToChar(Console.ReadLine());

                    if(choiceAccount.ToString().ToLower() == "y")
                    {
                        try
                        {
                            if(customer.Accounts != null && customer.Accounts.Count >= 5)
                            {
                                throw new Exception("Customer is already having five accounts");
                            }
                            else
                            {
                                Opeation BankingOperation = new Opeation();
                                BankingOperation.Banking(customer);
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }                       
                    }
                    else
                    {
                        Console.WriteLine("\nDo you want to operate an account for {0} ? (y/n)", customer.Name);
                        int choiceOperateAccount = Convert.ToChar(Console.ReadLine());

                        Opeation BankingOperation = new Opeation();
                        BankingOperation.Transaction(customer);
                    }
                }
                Console.WriteLine("\nDo you want to continue this program? (y/n)");

                choiceCustomer = Convert.ToChar(Console.ReadLine());
            } while (choiceCustomer.ToString().ToLower() == "y");

            Console.ReadKey();
        }
       
    }
}

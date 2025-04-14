using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pro1
{
    public abstract class Payment
    {
        public abstract void Pay(double amount);
        public void ReciptGeneration()
        {
            Console.WriteLine("Recipt Generated");
        }
    }
        public class Runner
    {
        public void Run()
        {
            double amount;
            try
            {
                Console.WriteLine("Enter amount to pay:");
                amount = Convert.ToDouble(Console.ReadLine());// we cant declare here 
            }
            catch (FormatException)
            {
                Console.WriteLine("Pls proivde valid number");
                return;
            }

            try
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Pls enter the ammount greater than 1");
                }
                else
                {



                    Console.WriteLine("Choose payment method:");
                    Console.WriteLine("1. UPI");
                    Console.WriteLine("2. Credit Card");
                    Console.WriteLine("3. Cash");

                    Console.Write("Enter your choice (1/2/3): ");
                    string choice = Console.ReadLine();

                    Payment payment;
                    try
                    {

                        switch (choice)
                        {
                            case "1":
                                payment = new Upi();
                                break;
                            case "2":
                                payment = new Credit();
                                break;
                            case "3":
                                payment = new Cash();
                                break;
                            default:
                                Console.WriteLine("Invalid choice!");
                                return;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    try
                    {

                        payment.Pay(amount);
                        payment.ReciptGeneration();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

    }




    public class Upi : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid ₹{amount} using upi.");
        }

    }

    public class Cash : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid ₹{amount} using cash.");
        }

    }

    public class Credit : Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid ₹{amount} using creditcard.");
        }

    }







}

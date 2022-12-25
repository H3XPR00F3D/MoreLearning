using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a class that represents a bank account. The class should have a name, balance, and account number. It should have methods for depositing, withdrawing, and displaying the balance.
*/

public class Bank
{
    private bool correct = true;
    private string name = "Donna Marilynn Holfstedder";
    private double acctNum = 82643791300;
    public double balance = 181920.45;
    private bool loop = true;
    private string amtWthdw;
    private int actions;

    public void RunBank()
        {

        Console.WriteLine("Welcome to Bank of Consolia.");
        Console.WriteLine("We have read your credentials and accessed your account.");
        Console.WriteLine("Your name is:           " + name);
        Console.WriteLine("Your account number is: " + acctNum);
        Console.WriteLine();
        Console.WriteLine("What would you like to do?\n1) Check your account balance\n2) Make a Deposit\n3) Make a Withdrawl");
        actions = Convert.ToInt32(Console.ReadLine());
        if(actions == 1)
        {
            Bank.Display();


        }


        }


        public void Deposit()
        {

        }

        public void Withdraw()
        {

            Console.WriteLine("How much would you like to Withdraw?");


            Console.WriteLine("You have Withdrawn " + amtWthdw + ". Your new balance is " + balance);

            Console.WriteLine("An error has occured");
            

        }

        public static void Display()
        {
            Bank b= new Bank(balance);
            Console.WriteLine();
            Console.WriteLine("Your Balance is " + b);
        }


    }

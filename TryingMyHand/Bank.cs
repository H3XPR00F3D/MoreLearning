using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

/*
Write a class that represents a bank account. The class should have a name, balance, and account number. It should have methods for depositing, withdrawing, and displaying the balance.
*/

public class Bank
{
    public double newBal;
    private string name = "Donna Marilynn Holfstedder";
    private double acctNum = 82643791300;
    public double balance = 12345678.90;
    private double amtWthdw;
    private int actions;
    private double amtDpt;
 

    public void RunBank()
        {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Welcome to Bank of Consolia.");
        Console.WriteLine("We have read your credentials and accessed your account.");
        Console.WriteLine();
        Console.WriteLine("Your name is:                 " + name);
        Console.WriteLine("Your account number is:       " + acctNum);
        Console.WriteLine();
        Console.WriteLine("What would you like to do?\n1) Check your account balance\n2) Make a Deposit\n3) Make a Withdrawl\n4) Close the system\n ");
        actions = Convert.ToInt32(Console.ReadLine());


        if(actions == 1)
        {
           Display();
           RunBank();
        }
        else if(actions ==2)
        {
            Deposit();
            RunBank();
        }
        else if(actions == 3) 
        {
            Withdraw();
            RunBank();
         }
        else if(actions == 4)
        {
            Environment.Exit(0);
        }

        }


        public double Deposit()
        {
            Bank newBal= new Bank();
            Console.WriteLine("You have chosen to make a Deposit. What is the amount being deposited?");
            amtDpt = Convert.ToDouble(Console.ReadLine());
            newBal.balance = balance + amtDpt;


        Console.WriteLine("You have Deposited ");
        Console.BackgroundColor = ConsoleColor.Green;// changes font color
        Console.ForegroundColor = ConsoleColor.Black;// changes font color
        Console.Write(amtDpt);
        Console.ResetColor();// resets font color
        Console.Write(". Your new balance is ");
        Console.BackgroundColor = ConsoleColor.Green;// changes font color
        Console.ForegroundColor = ConsoleColor.Black;// changes font color
        Console.Write(newBal.balance);
        Console.ResetColor();// resets font color
        Console.WriteLine();
        Console.WriteLine();
        balance = newBal.balance;
        return balance;


    }

        public double Withdraw()
        {
            Bank newBal= new Bank();

            Console.WriteLine("How much would you like to Withdraw?");
            amtWthdw=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            
            if(amtWthdw <=balance)
        {
            newBal.balance = balance -  amtWthdw;
            Console.WriteLine("You have Withdrawn ");
            Console.BackgroundColor = ConsoleColor.Green;// changes font color
            Console.ForegroundColor = ConsoleColor.Black;// changes font color
            Console.Write(amtWthdw);
            Console.ResetColor();// resets font color
            Console.Write(". Your new balance is ");
            Console.BackgroundColor = ConsoleColor.Green;// changes font color
            Console.ForegroundColor = ConsoleColor.Black;// changes font color
            Console.Write(newBal.balance);
            Console.ResetColor();// resets font color
            Console.WriteLine() ;
            Console.WriteLine();
            balance= newBal.balance;
            return balance;

        }
            else if (amtWthdw > balance)
        {
            Console.BackgroundColor = ConsoleColor.Red;// changes font color
            Console.ForegroundColor = ConsoleColor.Black;// changes font color
            Console.WriteLine("You do not have enough in your account.");
            Console.ResetColor();// resets font color

            return balance;//returns balance as it  was at start of statment
        }
            else
        {
            
            Console.BackgroundColor = ConsoleColor.Red; // changes font color
            Console.ForegroundColor = ConsoleColor.Black; //changes font color 
            Console.WriteLine("There was an error");//produces error message
            Console.ResetColor();// resets font color

            return balance; //returns balance as it  was at start of statment
        }
   }
        

    //displays current balance
        public void Display()
        {
        //printing balance out
            Console.WriteLine();
            Console.WriteLine("Your Balance is ");
        //changes font color
            Console.BackgroundColor= ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.Black;    
        //prints balance valus
            Console.Write(balance);
            Console.ResetColor();// resets font color
        Console.WriteLine() ;
        //ends method
            Console.ResetColor();// resets font color
    }


    }





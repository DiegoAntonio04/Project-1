using System;

class Program
{ 
   static void Main(string[] args) 
   {
    string username;
    string password;
    int attempts= 3;

    do
    {
        System.Console.WriteLine("Enter Admin Username: ");
        username= Console.ReadLine();

        System.Console.WriteLine("Enter Admin Password:");
        password= Console.ReadLine();
        
        if(username == "Admin" && password == "Admin1234!")
        {
            System.Console.WriteLine("Login Success!");
            break;
        }
        else
        {
            System.Console.WriteLine("Incorrect! Try Again.");
            attempts--;
            System.Console.WriteLine($"Attempts left;{attempts}");
        }
    }
    while(attempts>0);

    if (attempts==0)
    {
        System.Console.WriteLine("Access Locked");
    }
   }
}

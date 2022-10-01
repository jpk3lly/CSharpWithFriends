using System;

namespace CSharpWithFriends 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputMessages outputMessages = new OutputMessages();
            Console.WriteLine(outputMessages.welcome);
        }
    }
}
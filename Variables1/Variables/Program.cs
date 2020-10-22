using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string muppet = "Kermit";
            int age = 8;
            char bloodType = 'A';
            bool isPuppet = false;
            double howManyExist = 1;
            decimal money = 5.25m;

            Console.WriteLine($"My muppet's name is {muppet}, " +
                $"I am {age} years old, my blood type is {bloodType}, you are {isPuppet}, " +
                $"2 is better than {howManyExist}, do you want {money} in peso?");
        }
    }
}

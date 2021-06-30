using System;

namespace StudentClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student molly = new Student("Molly Cat", 1234);

            Console.WriteLine("molly's Id Number: {0}", molly.GetidNumber());
            Console.WriteLine("molly's Name: {0}", molly.GetName());

            Student bella = new Student("Bella");

            Console.WriteLine("bella's Id Number: {0}", bella.GetidNumber());
            Console.WriteLine("bella's Name: {0}", bella.GetName());

            Student kitkat = new Student("Kitkat");

            Console.WriteLine("kitkat's Id Number: {0}", kitkat.GetidNumber());
            Console.WriteLine("kitkat's Name: {0}", kitkat.GetName());


        }
    }
}

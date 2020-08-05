using System;

namespace Kurs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zad. 5 \r\n");
            Console.WriteLine("Please enter your personal data as below:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Name: " + name1);

            string srn = Console.ReadLine();
            Console.WriteLine("Surname: " + srn);

            string age1 = Console.ReadLine();
            int age2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Age: " + age2);

            string weight = Console.ReadLine();
            int weight1 = Int32.Parse(weight);
            Console.WriteLine("Weight: " + weight1);

            string height = Console.ReadLine();
            int height1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Height: " + height1);
            string sex = Console.ReadLine();
            Console.WriteLine("Sex: " + sex);
            string ShoeNumber = Console.ReadLine();
            int SN = Int32.Parse(ShoeNumber);
            Console.WriteLine("Shoe number: " + SN);
            string Pesel1 = Console.ReadLine();
            double Pesel2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("PESEL: " + Pesel2);
            string Idc = Console.ReadLine();
            int Idcard = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ID card number: " + Idcard);
            string DateOfBirth = Console.ReadLine();
            int DoB = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Date of birth (without special signs): " + DoB);
            string city = Console.ReadLine();
            Console.WriteLine("City: " + city);
            string adress = Console.ReadLine();
            Console.WriteLine("Adress: " + adress);
            string PostalCode = Console.ReadLine();
            int PC = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Postal Code: " + PC);
            string job = Console.ReadLine();
            Console.WriteLine("Job: " + job);
            Console.ReadKey();

        }

    }
}

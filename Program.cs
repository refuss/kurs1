using System;

namespace kurs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zad.1\r\n");
            Console.WriteLine("Employee data:");
            string name = "Daniel";
            Console.WriteLine("Name: " + name);
            string surname = "Lieber";
            Console.WriteLine("Surname: " + surname);
            int age = 25;
            Console.WriteLine("Age: " + age);
            char male = 'm';
            Console.WriteLine("Sex: " + male);
            double pesel = 850105002912;
            Console.WriteLine("PESEL number: " + pesel);
            double id = 2904;
            Console.WriteLine("Id employee number: " + id);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("zad. 2\r\n");
            char one = 'a';
            char two = 'b';
            char three = 'c';
            Console.WriteLine(three);
            Console.WriteLine(two);
            Console.WriteLine(one);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("zad. 3\r\n");
            int a = 10;
            int b = 15;
            Console.WriteLine("Długość przekątnej wynosi " + Math.Sqrt(a*a+b*b));
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("zad. 4\r\n");
            int c;
            string d;
            double e;
            c = 10;
            d = "Szkoła DotNeta";
            e = 12.5;
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);
            Console.ReadKey();

            Console.WriteLine("zad. 5 \r\n");
            Console.Write("Please enter your personal data as below:");
            string name1 = Console.ReadLine();
            Console.Write("Name: " + name1);
            //string srn = Console.ReadLine();
            //Console.WriteLine("Surname: " + srn);
            //string age1 = Console.ReadLine();
            //int age2 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Age: " + age2);
            string weight = Console.ReadLine();
            int weight1 = Int32.Parse(weight);
            Console.WriteLine("Weight: " + weight1);
            //string height = Console.ReadLine();
            //int height1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Height: " + height1);
            //string sex = Console.ReadLine();
            //Console.WriteLine("Sex: " + sex);
            //string ShoeNumber = Console.ReadLine();
            //int SN = Int32.Parse(ShoeNumber);
            //Console.WriteLine("Shoe number: " + SN);
            //string Pesel1 = Console.ReadLine();
            //double Pesel2 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("PESEL: " + Pesel2);
            //string Idc = Console.ReadLine();
            //int Idcard = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("ID card number: " + Idcard);
            //string DateOfBirth = Console.ReadLine();
            //int DoB = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Date of birth (without special signs): " + DoB);
            //string city = Console.ReadLine();
            //Console.WriteLine("City: " + city);
            //string adress = Console.ReadLine();
            //Console.WriteLine("Adress: " + adress);
            //string PostalCode = Console.ReadLine();
            //int PC = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Postal Code: " + PC);
            //string job = Console.ReadLine();
            //Console.WriteLine("Job: " + job);
            Console.ReadKey();
        }
    }
}

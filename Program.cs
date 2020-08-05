using System;

namespace kurs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zad.1 \r\n");
            Console.WriteLine("Employee personal data: ");
            string name = "Adam";
            Console.WriteLine("Name: " + name);
            string surname = "Kowalski";
            Console.WriteLine("Surname: " + surname);
            int age = 25;
            Console.WriteLine("Age: " + age);
            string sex = "male";
            Console.WriteLine("Sex: " + sex);
            long Pesel = 870105002901;
            Console.WriteLine("PESEL: " + Pesel);
            int IDcard = 240911;
            Console.WriteLine("IDcard number: " + IDcard);

            Console.WriteLine("Zad. 2 \r\n");
            char one = 'a';
            char two = 'b';
            char three = 'c';
            Console.WriteLine(three);
            Console.WriteLine(two);
            Console.WriteLine(one);

            Console.WriteLine("Zad. 3 \r\n");
            int d = 10;
            int e = 15;
            Console.WriteLine(Math.Sqrt(d*d+e*e));

            Console.WriteLine("Zad. 4 \r\n");
            int f;
            string g;
            double h;
            f = 10;
            g = "Szkoła DotNeta";
            h = 12.5;
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);

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
            string sex1 = Console.ReadLine();
            Console.WriteLine("Sex: " + sex1);
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

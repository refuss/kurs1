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
            Console.WriteLine(Math.Sqrt(d * d + e * e));

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
            Console.Write("Name: ");
            string nm = Console.ReadLine();
            Console.Write("Surname: ");
            string srn = Console.ReadLine();
            Console.Write("Age: ");
            string age1 = Console.ReadLine();
            int age2 = Int32.Parse(age1);
            Console.Write("Weight (kg): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Height (cm): ");
            int height = Int32.Parse(Console.ReadLine());
            Console.Write("Sex(male/female): ");
            string sex1 = Console.ReadLine();
            Console.Write("Shoe number: ");
            int SN = Int32.Parse(Console.ReadLine());
            Console.Write("PESEL (11 numbers): ");
            double Pesel = double.Parse(Console.ReadLine());
            Console.Write("ID card number (4 digits): ");
            int Idcard = Int32.Parse(Console.ReadLine());
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("Adress: ");
            string adress = Console.ReadLine();
            Console.Write("Postal Code (only numbers): ");
            int PC = Int32.Parse(Console.ReadLine());
            Console.Write("Job: ");
            string job = Console.ReadLine();
            Console.Write("Thank you for entering the data");
            Console.ReadKey();
        }
    }
}

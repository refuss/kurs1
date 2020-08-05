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
            Console.WriteLine("Name: ");
            string name1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Surname: ");
            string srn = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Age: ");
            string age1;
            int age2 = Int32.Parse(age1);
            Console.WriteLine();
            Console.WriteLine("Weight: ");
            string weight = Console.ReadLine();
            double weight1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Weight: ");
            string height = Console.ReadLine();
            int height1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sex: ");
            string sex1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Shoe number: ");
            string ShoeNumber = Console.ReadLine();
            int SN = Int32.Parse(ShoeNumber);
            Console.WriteLine();
            Console.WriteLine("PESEL: ");
            string Pesel1 = Console.ReadLine();
            double Pesel2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("ID card number: ");
            string Idc = Console.ReadLine();
            int Idcard = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Date of birth (format: YYYYMMdd): ");
            string DateOfBirth = Console.ReadLine();
            //DateTime.TryParse(DateOfBirth, out parsedDate)
            Console.WriteLine();
            Console.WriteLine("City: ");
            string city = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Adress: ");
            string adress = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Postal Code: ");
            string PostalCode = Console.ReadLine();
            int PC = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Job: ");
            string job = Console.ReadLine();
            Console.WriteLine("Thank you for entering the data");
            Console.ReadKey();
        }
    }
}

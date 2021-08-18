using System;

// not using a database! This is a simple C# console login program using some methods and if / else statements

namespace SimpleLoginSystem
{
    class Program
    {
        static string uporabniskoIme;
        static string geslo;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.Write("Prosim vnesite vaše uporabniško ime: ");
            uporabniskoIme = Console.ReadLine();
            Console.Write("Prosim vnesite vaše geslo: ");
            geslo = Console.ReadLine();
            Console.WriteLine("Registracija zaključena!\n");
            Console.WriteLine("-----------------------\n");
        }

        public static void Login()
        {
            Console.Write("Prosim vnesite vaše uporabniško ime: ");
            if (uporabniskoIme == Console.ReadLine())
            {
                Console.Write("Prosim vnesite vaše geslo: ");
                if (geslo == Console.ReadLine())
                {
                    Console.WriteLine("Prijava uspešna");
                } else
                {
                    Console.WriteLine("Prijava ni uspela, vnesli ste napačno geslo");
                }
            } else
            {
                Console.WriteLine("Prijava ni uspela. Vnesli ste napačno uporabniško ime / geslo.");
            }
        }
    }
}

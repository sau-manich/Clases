using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesEjemplo
{
    class Program
    {
        class persona
        {
            private int año;
            private string nombre;

            public persona()
            {
                nombre = "Saul";
            }

            public persona(string nom, int age)
            {
                this.nombre = nom;
                this.año = age;
            }

            public void PrintPers()
            {
                Console.WriteLine("{0}, {1} years old.", nombre, año);
            }
        }

        class StringTest
        {
            static void Main(string[] args)
            {
                persona per1 = new persona("Rolf", 11);
                persona per2 = new persona("Wolf", 10);
                persona per3 = new persona();

                Console.Write("Persona #1: ");
                per1.PrintPers();
                Console.Write("Persona #2: ");
                per2.PrintPers();
                Console.Write("Persona #3: ");
                per3.PrintPers();
                Console.ReadKey();

            }
        }
    }
}
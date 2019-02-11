using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Carlos Vegeta", 45);
            p1.Saludar(); 

            Empleado e1 = new Empleado("Alfonso D´Askr", 18, "Lider", 5000);
            e1.Saludar();
            e1.Trabajar();

            Estudiante es1 = new Estudiante("Poyo Jon", 21, 420911, "Cuarto");
            es1.Saludar();
            es1.Estudiar();

            Console.ReadKey();
        }
    }
}

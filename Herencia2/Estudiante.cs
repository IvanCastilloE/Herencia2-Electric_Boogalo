using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    class Estudiante: Persona
    {
        public int Matricula { get; set; }
        public string Grado { get; set; }

        public Estudiante(string nombre, int edad, int matricula, string grado): base(nombre, edad)
        {
            Matricula = matricula;
            Grado = grado;
        }
        public void Estudiar()
        {
            Console.WriteLine("{0} esta estudiando como puerco \n", Nombre);
        }
        public override void Saludar()
        {
            Console.WriteLine("Hola, mi nombre es {0}, tengo {1} años, mi matricula es {2} y estoy en {3} grado"
                , Nombre, Edad, Matricula, Grado);
        }
    }
}

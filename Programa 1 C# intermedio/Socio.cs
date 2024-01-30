using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_1_C__intermedio
{
    class Socio
    {
        public Socio() {
            Console.WriteLine("Ingrese el nombre del socio");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la antiguedad del socio");
            Antiguedad = int.Parse(Console.ReadLine());
        }
        public string? Nombre { get; set; }

        public int Antiguedad { get; set; }

        public void obtenerNombre() {
            Console.WriteLine("El socio más antiguo es: " + Nombre);
        }
    }
}

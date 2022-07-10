using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionIker
{
    class Estudiante
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string institucion { get; set; }
        public int cedula { get; set; }
        public Estudiante(string nombre, string apellido, string institucion, int cedula)
        {
            this.nombre=nombre;
            this.apellido=apellido;
            this.institucion=institucion;
            this.cedula=cedula;
        }
        public void imprimir()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Nombre: " + nombre + "Apellido: " + apellido);
            Console.WriteLine("Nombre de institucion: " + institucion);
            Console.WriteLine("Cedula: " + cedula);
        }

    }
}

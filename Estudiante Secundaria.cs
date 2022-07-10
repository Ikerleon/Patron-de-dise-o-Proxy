using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionIker
{
    class Estudiante_Secundaria:Estudiante, ICalcular
    {
        public int nivelcursado { get; set; }
        public int preciofijon;
        public Estudiante_Secundaria(string nombre, string apellido, string institucion, int cedula, int nivelcursado):base(nombre,apellido,institucion,cedula)
        {
            this.nivelcursado = nivelcursado;
            this.preciofijon = 20;
        }
        public void Calcularvalor()
        {
            int total = nivelcursado * preciofijon;
            Console.WriteLine("El valor de la matricula es: "+total);
        }
    }
}

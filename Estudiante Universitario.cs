using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionIker
{
    class Estudiante_Universitario:Estudiante, ICalcular
    {
        public int cantidadprecio { get; set; }
        public int preciocredito { get; set; }
        public Estudiante_Universitario(string nombre, string apellido, string institucion, int cedula,int cantidadprecio):base(nombre,apellido,institucion,cedula)
        {
            this.cantidadprecio = cantidadprecio;
            this.preciocredito = 7;
        }
        public void Calcularvalor()
        {
            int total = cantidadprecio * preciocredito;
            Console.WriteLine("El valor de la matricula anual es:" + total);
        }
    }
}

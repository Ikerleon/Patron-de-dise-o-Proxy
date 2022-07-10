using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionIker
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante_Primaria oestudiante = new Estudiante_Primaria("iker", "leon", "moderna", 1351725559);
            oestudiante.imprimir();
            oestudiante.Calcularvalor();
            Estudiante_Secundaria oestudiantes = new Estudiante_Secundaria("luis","rodrigo","san jose",135555587,7);
            oestudiantes.imprimir();
            oestudiantes.Calcularvalor();
            Estudiante_Universitario oestudianteuni = new Estudiante_Universitario("jose","juan","4 de noviembre",1352545555,8);
            oestudianteuni.imprimir();
            oestudianteuni.Calcularvalor();
            ////Aqui podemos evidenciar como solo se puede utilizar por medio de un proxy 
            Console.WriteLine("PARA ACCEDER A LOS NOMBBRES DE LOS ESTUDIANTES QUE DEBEN INGRESE LA CONTRASEÑA");
            CProxy.Personas secreto = new CProxy.ProxySeguro();
            secreto.Peticion(1);
            
        }
    }
}

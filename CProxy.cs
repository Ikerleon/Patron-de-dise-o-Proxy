using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionIker
{
    class CProxy
    {
        //Creamos la interfaz con su metodo de petición
        public interface Personas
        {
            void Peticion(int pOpcion);
        }
        //Hacemos anidamiento de clases para que cualquier clase privada o anidada solo sea conocida por nuestro "CProxy"
        public class ProxySeguro : Personas
        {
            private CNombres nombre;

            //Implementación del metodo "Petición" de la interfaz "Personas"
            public void Peticion(int pOpcion)
            {
                //Presentamos nuestro codigo de seguridad 
                string password;

                password = Console.ReadLine();
                //Dejamos declarado nuestro codigo de seguridad como "123456"
                if (password == "123456")
                {
                    //Si la instancia no ha sido creada
                    if (nombre == null)
                    {
                        //Se activa la instancia
                        Console.WriteLine("Activando el sujeto");
                        nombre = new CNombres();
                    }
                    //Eligiendo 1 invocamos nuestro metodo Nombre Secreto
                    if (pOpcion == 1)
                        nombre.NombreSecreto();
                }
                else
                {
                    Console.WriteLine("Acceso Denegado");
                }
            }
        }
        //CLASE PRIVADA PROTEGIDA POR PROXY
        //SOLO SE PUEDE ACCEDER POR MEDIO DEL PROXY
        private class CNombres
        {
            public void NombreSecreto()
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Las siguientes personas deben:");
                Console.WriteLine("Luis-----------30$");
                Console.WriteLine("Enrique--------70$");
                Console.WriteLine("Jerardo--------90$");
            }
        }
    }
}

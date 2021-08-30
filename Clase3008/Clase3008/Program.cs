using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaBibliotecaDeClases;
// import PruebaBibliotecaDeClases

namespace Clase3008
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            // Con get y set "a lo java"
            // persona.setNombre("Juan");
            //Console.WriteLine(persona.getNombre());

            // Con properties "largas"
            // persona.Nombre = "Juan";
            // Console.WriteLine(persona.Nombre);

            // Con auto implemented properties
            persona.Nombre = "Juan";
            Console.WriteLine(persona.Nombre);

            Persona p = new Persona();
            EjemploDuckTyping.Perro perro = new EjemploDuckTyping.Perro();

            SaludarEntidad(p);
            SaludarEntidad(perro);
            Console.ReadLine();
        }

        // Cuando utilizamos interfaces las mismas nos proveen la habilidad
        // de definir tipos en funcion de lo que hacen, y no del tipo que son
        // Agrupamos por funciones utilizando interfaces
        public static void SaludarEntidad(EjemploDuckTyping.ISaludable julio)
        {
            julio.Saludar();
        }
    }
}

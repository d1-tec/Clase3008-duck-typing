using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3008
{
    // Persona realiza la interfaz IPersona
    // o sea, implementa los metodos de la interfaz IPersona
    public class Persona : IPersona, EjemploDuckTyping.ISaludable
    {
        // auto implemented property
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
        public string Nombre { get; set; }

        public int ObtenerEdadEnDias()
        {
            throw new NotImplementedException();
        }

        public void Saludar()
        {
            Console.WriteLine("Soy una persona");
        }

        // NO ES LO MISMO QUE
        // public string nombre;
        // ESTO ES UN ATRIBUTO PUBLICO
    }

    //public class Persona
    //{
    //    private string _nombre;

    //    // property - el equivalente a getter y setter en java
    //    public string Nombre
    //    {
    //        get { return this._nombre; }
    //        set 
    //        { 
    //            // if (value.Length < 2) ... lanzar excepcion

    //            this._nombre = value;
    //        }
    //    }
    //}

    //public class Persona
    //{
    //    private string nombre;

    //    public string getNombre()
    //    {
    //        return this.nombre;
    //    }

    //    public void setNombre(string nombre)
    //    {
    //        this.nombre = nombre;
    //    }
    //}
}

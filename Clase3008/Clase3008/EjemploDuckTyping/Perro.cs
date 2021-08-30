using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3008.EjemploDuckTyping
{
    public class Perro : ISaludable
    {
        public void Saludar()
        {
            Console.WriteLine("Soy un perro");
        }
    }
}

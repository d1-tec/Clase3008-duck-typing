using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAComposicionDelegacion
{
    public class Computadora // : Reparable
    {
        private Arreglable arreglable;
        private Reparable reparable;

        public void Reparar()
        {
            this.reparable.Reparar();
            // base.Reparar();
            // super.Reparar(); en java
        }

        public void Arreglar()
        {
            this.arreglable.Arreglar();
        }
    }
}

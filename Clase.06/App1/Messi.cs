using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Messi : Jugador, IJugador
    {
        public Messi(int velocidad, int tiro, int regate, int defensa, int pase, int fisico) : base(velocidad, tiro, regate, defensa, pase, fisico)
        {
        }

        public void colocarPase()
        {
            Console.WriteLine("Messi dio pase con {0} de propiedad", this.Pase);
        }

        public void correr()
        {
            Console.WriteLine("Messi corrió con {0} de propiedad", this.Velocidad);
        }

        public void defender()
        {
            Console.WriteLine("Messi defendió con {0} de propiedad", this.Defensa);
        }

        public void regatear()
        {
            Console.WriteLine("Messi regateó con {0} de propiedad", this.Regate);
        }

        public void rematar()
        {
            Console.WriteLine("Messi remató con {0} de propiedad", this.Tiro);
        }

        public void soportarEmbate()
        {
            Console.WriteLine("Messi soportó embate con {0} de propiedad", this.Fisico);
        }
    }
}
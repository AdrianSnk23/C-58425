﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Ronaldo : Jugador, IJugador
    {
        public Ronaldo(int velocidad, int tiro, int regate, int defensa, int pase, int fisico) : base(velocidad, tiro, regate, defensa, pase, fisico)
        {
        }

        public void colocarPase()
        {
            Console.WriteLine("Cristiano Ronaldo dio pase con {0} de propiedad", this.Pase);
        }

        public void correr()
        {
            Console.WriteLine("Cristiano Ronaldo corrió con {0} de propiedad", this.Velocidad);
        }

        public void defender()
        {
            Console.WriteLine("Cristiano Ronaldo defendió con {0} de propiedad", this.Defensa);
        }

        public void regatear()
        {
            Console.WriteLine("Cristiano Ronaldo regateó con {0} de propiedad", this.Regate);
        }

        public void rematar()
        {
            Console.WriteLine("Cristiano Ronaldo remató con {0} de propiedad", this.Tiro);
        }

        public void soportarEmbate()
        {
            Console.WriteLine("Cristiano Ronaldo soportó embate con {0} de propiedad", this.Fisico);
        }
    }
}

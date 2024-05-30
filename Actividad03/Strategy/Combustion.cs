using Actividad03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad03.Strategy
{
    internal class Combustion : IEngine
    {
        public Combustion()
        {
        }
        public void Move()
        {
            Console.WriteLine("Moviendo con Combustion");
        }
    }
}

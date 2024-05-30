using Actividad03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad03.Model
{
    class Transport
    {
        private IDriver? driver;

        private IEngine engine;

        public Transport(IEngine engine) 
        {
            this.engine = engine;
        }

        public void SetDriver(IDriver driver) 
        {
            this.driver = driver;
        }

        public void SetEngine(IEngine engine) 
        {
            this.engine = engine;
        }

        public void Deliver(string name) 
        {
            Console.WriteLine(driver.Navigate(name));
            engine.Move();
        }
    }
}

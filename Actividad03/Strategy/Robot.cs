using Actividad03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad03.Strategy
{
    internal class Robot : IDriver
    {
        private string driverName;
        public Robot(string driverName)
        {
            this.driverName = driverName;
        }

        public string Navigate(string driverName)
        {
            return driverName;
        }
    }
}

using Actividad03.Model;
using Actividad03.Strategy;

Transport transport = new Transport(new Combustion());
transport.SetDriver(new Human("Maxi"));
transport.Deliver("Maxi");

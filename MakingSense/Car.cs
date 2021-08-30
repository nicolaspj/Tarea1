using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingSense
{
    class Car
    {
        public Car()
        {
             Modelo = modelo;
             Puertas = puertas;
             Id = id;
             Color = color;
             CajaCambio = cajaCambio;
        }

      


        private int Id;
        private string Modelo;
        private int Puertas;
        private string Color;
        private string CajaCambio;


        public int id  { get; set;}
        public int puertas{ get; set; }
        public string color { get; set; }

        public string cajaCambio { get; set; }

        public string modelo { get; set; }

    }
}

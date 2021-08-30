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

        }

        public Car(int Id,string Modelo, int Puertas, string Color, string CajaCambio)
        {
            this.Id = Id;
            this.Modelo = Modelo;
            this.Puertas = Puertas;
            this.Color  = Color;
            this.CajaCambio = CajaCambio;
         }


        private int Id;
        private string Modelo;
        private int Puertas;
        private string Color;
        private string CajaCambio;


        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public int puertas
        {
            get { return Puertas; }
            set { Puertas = value; }
        }
        public string color
        {
            get { return Color; }
            set { Color = value; }
        }
        public string cajaCambio
        {
            get { return CajaCambio; }
            set { CajaCambio = value; }
        }
        public string modelo
        {
            get { return Modelo; }
            set { Modelo = value; }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingSense
{   
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            
            Car car = new();
            CarCrud newCar = new();
            car.Id = 1;
            car.CajaCambio = "Manual";
            car.Color = "Rojo";
            car.Modelo = "Fiat";
            car.Puertas = 4;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese su opcion:\n1.Para Crear Auto\n2 Para buscar por Id\n3 Para Finalizar ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        newCar.Create(car);
                        break;

                    case 2:
                        newCar.Get(1);
                        break;
                }
            } while (opcion != 3);

        }

    }
}

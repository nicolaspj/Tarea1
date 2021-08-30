using System;

namespace MakingSense
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int opcion;
            Console.WriteLine("Ingrese su opcion:\n1.Para Crear Auto");
            opcion = Convert.ToInt32(Console.ReadLine());
            Car car = new Car();
            CarCrud newCar = new CarCrud();

            do
            {
                switch (opcion)
                {
                    case 1: newCar.Create(car);
                    break;

                   case 2: newCar.Get(car.id);
                    break;
                }



            } while (opcion != 1);



        }
        
    }
}
    
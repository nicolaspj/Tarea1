using System;

namespace MakingSense
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int opcion;
            Console.WriteLine("Ingrese su opcion:\n1.Para Crear Auto\n2 Para buscar por Id\n3");
            opcion = Convert.ToInt32(Console.ReadLine());
            Car car = new Car();
            CarCrud newCar = new CarCrud();

            do
            {
                switch (opcion)
                {
                    case 1: newCar.Create(1,"Fiat",4,"rojo","Manual");
                    break;

                    case 2: newCar.Get(1);
                    break;
                }



            } while (opcion != 2);



        }
        
    }
}
    
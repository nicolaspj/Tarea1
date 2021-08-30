using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingSense
{
    class CarCrud
    {

        public Car Create(Car car)
           {
            
            Console.WriteLine("Ingrese una nueva ID ");
            car.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese una marca de auto");
            car.cajaCambio = Console.ReadLine();
            Console.WriteLine("Ingrese color de auto ");
            car.color = Console.ReadLine();
            Console.WriteLine("Ingrese modelo de auto (automatico / manual) ");
            car.modelo = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de puertas del auto ");
            car.puertas = Convert.ToInt32(Console.ReadLine());
            string json1 = JsonSerializer.Serialize(car);
            string FileName = @"C:\Users\nico_\Desktop\proyectos\Tarea1\MakingSense\Json\json1.json";
            File.WriteAllText(FileName, json1);
            Console.WriteLine(json1);
           
            return car;
           }

            public int BuscarJson (int id)
             {
            int Id = id;
            string FileJson = @"C:\Users\nico_\Desktop\proyectos\Tarea1\MakingSense\Json\json1.json";
            StreamReader read = new StreamReader(FileJson);
            var json = read.ReadToEnd();

            return Id;
             }
            public Car Get(int id)
            {
            
            var Id = id;
            Console.WriteLine("*******************\n");
            Console.WriteLine("Ingrese un Id para Buscar Infomacion del auto\n");
            int i = Id; 
            i = Convert.ToInt32(Console.ReadLine());
            
            BuscarJson(i);

            return i;
            
            }
           
    }


}


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MakingSense
{
    class CarCrud
    {
        public Car Create(Car car)
        {
            Car newCar = car;
            newCar.CajaCambio = car.CajaCambio;
            newCar.Color = car.Color;
            newCar.Id = car.Id;
            newCar.Modelo = car.Modelo;
            newCar.Puertas = car.Puertas;
            string json1 = JsonSerializer.Serialize(newCar);
            string FileName = @"C:\Users\nico_\Desktop\proyectos\Tarea1\MakingSense\Json\json1.json";
            File.WriteAllText(FileName, json1);
            Console.Clear();
            Console.WriteLine(json1);
            
            return newCar;
        }

        public int Get(int id)
        {

            string FileJson = @"C:\Users\nico_\Desktop\proyectos\Tarea1\MakingSense\Json\json1.json";
            string JsonFile;
            int i = id;
            using (var reader = new StreamReader(FileJson))
            {
                JsonFile = reader.ReadToEnd();
            }

            var auto = JsonSerializer.Deserialize<Car>(JsonFile);
            if (i == auto.Id)
            {
                Console.Clear();
                Console.WriteLine(auto.Id);
                Console.WriteLine(auto.Modelo);
                Console.WriteLine(auto.Color);
                Console.WriteLine(auto.CajaCambio);
                Console.WriteLine(auto.Puertas);
            }
            return i;
        }
    }
}

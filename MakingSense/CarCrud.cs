using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingSense
{
    class CarCrud
    {
        //public Car(int Id, string Modelo, int Puertas, string Color, string CajaCambio)
        //{
        //    this.Id = Id;
        //    this.Modelo = Modelo;
        //    this.Puertas = Puertas;
        //    this.Color = Color;
        //    this.CajaCambio = CajaCambio;
        //}
        public Car Create(int Id, string Modelo, int Puertas, string Color, string CajaCambio)
        {
            var newCar = new Car();
            Console.WriteLine("Ingrese una nueva ID ");
            //newCar.d = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese una marca de auto");
            //newCar.cajaCambio = Console.ReadLine();
            //Console.WriteLine("Ingrese color de auto ");
            //newCar.color = Console.ReadLine();
            //Console.WriteLine("Ingrese modelo de auto (automatico / manual) ");
            //newCar.modelo = Console.ReadLine();
            //Console.WriteLine("Ingrese la cantidad de puertas del auto ");
            //newCar.puertas = Convert.ToInt32(Console.ReadLine());
            newCar.id = Id;
            newCar.modelo = Modelo;
            newCar.puertas = Puertas;
            newCar.color = Color;
            newCar.cajaCambio = CajaCambio;
            string json1 = JsonSerializer.Serialize(newCar);
            string FileName = @"C:\Users\nico_\Desktop\proyectos\Tarea1\MakingSense\Json\json1.json";
            File.WriteAllText(FileName, json1);
            Console.WriteLine(json1);
            
            return newCar;
           }

            public int Get(int id)
             {
            
                 string FileJson = @"C:\Users\nico_\Desktop\proyectos\Tarea1\MakingSense\Json\json1.json";
                 string JsonFile;
                 int i = id;
                 using( var reader = new StreamReader(FileJson))
                 {
                       JsonFile = reader.ReadToEnd();
                 }
                
                var auto = JsonSerializer.Deserialize<Car>(JsonFile);
                if ( i == auto.id )
                 {
                    
                   
                    Console.WriteLine(auto.id);
                    Console.WriteLine(auto.modelo);
                    Console.WriteLine(auto.color);
                    Console.WriteLine(auto.cajaCambio);
                    Console.WriteLine(auto.puertas);
                    
                 }
            return i;
            }

            
        /*    public Car Get(int id)
            {
            
            
         
            
            }
         */  
    }


}


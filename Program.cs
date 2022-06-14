using System;
using System.Text;
using System.Text.Json;

namespace TP9
{
    class json
    {
        static void Main(string[] args){
            string path  = @"C:\Users\facun\OneDrive\Escritorio\Facultad NOTE\json";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(path + @"/Jugadores.json" ))
            {
                File.Create(path + @"/Jugadores.json");
            }else
            {
                File.Create(path + @"/Jugadores.json").Close();
            }
            Console.WriteLine("Cuantos productos desea generar");
            int cant = Convert.ToInt32(Console.ReadLine());
            List<Productos>productos = new List<Productos>();
            for (int i = 0; i < cant; i++)
            {
                Productos pro = new Productos();
                productos.Add(pro);
               
                

            }
             string json = JsonSerializer.Serialize(productos);
             File.WriteAllText(path + @"/Jugadores.json", json);

             Console.WriteLine("Mostraremos los objetos");

             List<Productos> jsonist = new List<Productos>();

             string archivo = path + @"/Jugadores.json";
             string jsonread = File.ReadAllText(archivo);


             jsonist = JsonSerializer.Deserialize<List<Productos>>(jsonread);

             foreach (Productos item in jsonist)
             {
                Console.WriteLine("Nombre : {0}" , item.Nombre);
                Console.WriteLine("Precio: {0}" , item.Precio);
                Console.WriteLine("Tamaño : {0}" , item.Tamanio);
                Console.WriteLine("Fecha de ven : {0}" , item.Fechavencimiento);
                Console.WriteLine("\n");
                
             }

            
            
            



          
            
        }
    }
}

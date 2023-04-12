using System;
using System.IO;


namespace archivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario que ingrese un número entero
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            // Guardar el número en el archivo "numeros.txt"
            //el streamwriter sirve para escribir el numero en el archivo
            //el file.appendtext sirve para abrir el archivo y agregarle cosas al final DEJANDO EL CONTENIDO ANTERIOR
            string ruta = "numeros.txt";
            using (StreamWriter writer = File.AppendText(ruta))
            {
                writer.WriteLine(numero);
            }

            // Leer el archivo 
            Console.WriteLine("Contenido del archivo:");
            //streamreader sirve para leer el numero en el archivo
            //file.opentext abrimos el archivo
            using (StreamReader reader = File.OpenText(ruta))
            {
                string linea;
                //va a comprobar que en cada linea haya algo, si hay algo lo imprime, si no, sale
                while ((linea = reader.ReadLine()) != null)
                {
                    //imprime lo que hay en el archivo
                    Console.WriteLine(linea);
                }
            }
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

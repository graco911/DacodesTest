using System;
using System.Collections.Generic;

namespace DacodesLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOGIC TEST");
            
            var resultlist = new List<string>();

            //Try para la excepcion en caso de que se inserte un valor no numerico
            try
            {
                Console.WriteLine("Numero de casos");

                var cases = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < cases; i++)
                {   
                    Console.WriteLine("Filas (N)");
                    var rows = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Columnas (M)");
                    var columns = Convert.ToInt32(Console.ReadLine());

                    /// El modulo realiza toda la logica, sin necesidad de recorrer
                    /// la cuadricula.
                    /// El Software de Karel el Robot hacia algo similar pero visualmente.

                    ///Caso 1 
                    ///Cuadricula Cuadrada
                    ///
                    ///
                    ///   X X X 
                    ///   X X X
                    ///   X X X
                    ///
                    if (rows == columns && rows > 1)
                    {
                        resultlist.Add(rows % 2 == 0 ? "L" : "R");
                    }
                    ///Caso 2
                    ///Cuadricula rectangulo alto
                    ///
                    ///   X X X
                    ///   X X X
                    ///   X X X
                    ///   X X x 
                    ///
                    else if (rows > columns && columns > 1)
                    {
                        resultlist.Add(columns % 2 == 0 ? "U" : "D");
                    }
                    ///Caso 3
                    ///Cuadricula rectangulo ancho
                    ///
                    ///   X X X
                    ///   X X X
                    ///   
                    ///
                    else if (columns > rows)
                    {
                        resultlist.Add(rows % 2 == 0 ? "L" : "R");
                    }
                    ///Caso 4
                    ///Cuadricula unica
                    ///
                    ///   X 
                    ///   
                    ///
                    else if (columns == 1)
                    {
                        resultlist.Add(rows == 1 ? "R" : "D");
                    }
                }

                Console.WriteLine("Output");

                foreach (var item in resultlist)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                //Entrada a la excepcion
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }

            Console.WriteLine("Programa terminado.");
            Console.ReadLine();
        }
    }
}

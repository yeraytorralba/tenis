using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenis
{
   
    class Program
    {

        static void Main(string[] args)
        {


            jugador uno = new jugador();
            jugador dos = new jugador();

            GenerarPuntaje nPuntaje = new GenerarPuntaje();

            string cadena;

            Console.WriteLine("Se introducira por teclado que jugador gana punto( 1, 2) hasta que gane uno de ellos");
            do
            {
                Console.WriteLine("Introducir que jugardor puntua: 1, 2");
                cadena = Console.ReadLine();

                Console.WriteLine(nPuntaje.marcador(cadena));

            } while (nPuntaje.gana() == false);
            cadena = Console.ReadLine();

        }
        
       




    }
}

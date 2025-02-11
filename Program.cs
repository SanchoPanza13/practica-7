namespace Practica7
{
    using System;

    internal class Program
    {
        static char[,] mapa = new char[10, 10];                       //Inicializacion matriz bidimensinal (mapa)

        static int coordJugX = 0;                                     //Coordenadas del jugador

        static int coordJugY = 0;

        static Random generadorEspacios = new Random();               //Un random que se empleara en la generacion del mapa




        static void Main(string[] args)
        {
            generadorMapa();                                          //Metodo de generacion de mapa

            bool juegoActivo = true;

            while (juegoActivo)
            {
                MostrarMapa();                                        //Metodo para mostrar el mapa

                char input=Console.ReadKey().KeyChar;                 //Detectar input del jugador

            }


        }



        static void MostrarMapa()
        {
            for (int x = 0; x < mapa.Length; x++)                    //Lee filas y columnas con los dos bucles for
            {
                for (int y = 0; y < mapa.Length; y++)
                {
                    Console.Write(mapa[x, y]);                 //Muestra lo que hay en cada celda
                }
                Console.WriteLine();                           //Salta la linea
            }
        }


        static void generadorMapa()
        {
            for(int x=0; x< mapa.Length; x++)                         //Lee filas y columnas
            {
                for (int y=0; y< mapa.Length; y++)
                {
                    if (x == 0 && y == 0)                             //Si las coordenadas son 0 Y 0, pondrá una P (el jugador)
                    {
                        mapa[x, y] = 'P';
                    }
                    else                                              //Si no, usara el random declarado antes para poner obstaculos
                    {
                        int prob = generadorEspacios.Next(100);       //Lo ponemos a escala de 100 por ciento

                        if (prob < 20)                                //Si el numero es menor a 20 saldra obstaculo (20% probabilidad de obstaculo)
                        {
                            mapa[x, y] = 'X';
                        }else if (prob < 30 && prob >= 20)            //Si el numero es menor a 30 saldra mina (10%)
                        {
                            mapa[x, y] = 'M';
                        }else if (prob >=30 && prob <= 100)           //Para todo numero mayor a 30 habra vacio (70%)
                        {
                            mapa[x, y] = ' ';
                        }

                    }
                }
            }
        }
    }
}
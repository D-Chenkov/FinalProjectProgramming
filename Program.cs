using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCarrascoHernandezMarin
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();
            Menu();
        }

        static void Menu()
        {
            
            int seleccion = 0;
            int Ejer = 0;
            Console.WriteLine("Escoja un tipo de problema");
            Console.WriteLine("1- Ejercicio IF");
            Console.WriteLine("2- Ejercicio Switch");
            Console.WriteLine("3- Ejercicio While");
            Console.WriteLine("4- Ejercicio For");
            Console.WriteLine("5- Ejercicio Array");
            seleccion = int.Parse(Console.ReadLine());
            switch (seleccion)
            {
                case 1:
                    {
                        Console.WriteLine("Cual desea hacer?");
                        Console.WriteLine("Ejercicio If-1");
                        Console.WriteLine("Ejercicio If-2");
                        Console.WriteLine("Ejercicio If-3");
                        Ejer = Console.ReadLine();
                        switch (Ejer)
                        {
                            case 1:
                                {
                                    //EjercicioIfUno();
                                }
                                break;
                            case 2:
                                {
                                    //EjercicioIfDos();
                                }
                                break;
                            case 3:
                                {
                                 //   EjercicioIfTres();
                                }
                                break;
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Ejercicio Switch-1");
                        Console.WriteLine("Ejercicio Switch-2");
                        Console.WriteLine("Ejercicio Switch-3");
                        switch (Ejer)
                        {
                            case 1:
                                {
                                   // EjercicioSwitchUno();
                                }
                                break;
                            case 2:
                                {
                                    //EjercicioSwitchDos();
                                }
                                break;
                            case 3:
                                {
                                    //EjercicioSwitchTres();
                                }
                                break;
                        }
                    }
                    break;
                case 3:
                    {

                        Console.WriteLine("Ejercicio While-1");
                        Console.WriteLine("Ejercicio While-2");
                        Console.WriteLine("Ejercicio While-3");
                        switch (Ejer)
                        {
                            case 1:
                                {
                                //    EjercicioWhileUno();
                                }
                                break;
                            case 2:
                                {
                                //    EjercicioWhileDos();
                                }
                                break;
                            case 3:
                                {
                                //    EjercicioWhileTres();
                                }
                                break;
                        }
                    }
                    break;
                case 4:
                    {

                        Console.WriteLine("Ejercicio For-1");
                        Console.WriteLine("Ejercicio For-2");
                        Console.WriteLine("Ejercicio For-3");
                        switch (Ejer)
                        {
                            case 1:
                                {
                                 //   EjercicioForUno();
                                }
                                break;
                            case 2:
                                {
                                //    EjercicioFordos();
                                }
                                break;
                            case 3:
                                {
                                   // EjercicioForTres();
                                }
                                break;
                        }
                    }
                    break;

                case 5:
                    {
                        Console.WriteLine("Ejercicio Array/Struct-1");
                        Console.WriteLine("Ejercicio Array/Struct-2");
                        Console.WriteLine("Ejercicio Array/Struct-3");
                        switch (Ejer)
                        {
                            case 1:
                                {
                                //    EjercicioArrayUno();
                                }
                                break;
                            case 2:
                                {
                                  //  EjercicioArrayDos();
                                }
                                break;
                            case 3:
                                {
                                 //   EjercicioArraytres();
                                }
                                break;
                        }
                        break;
                    }
            }
        }

        public void Ejercicio()
        {

        }



        static void staircase(int n)
        {
            int i, p;
            i = 0;
            n = n + 1;
            p = n - 1;
            for (i = 0; i < n; i++)
            {
                string result = new String('#', i);
                string pos = new String(' ', p);
                Console.WriteLine(pos + (result) + result);
                p--;
            }
            Console.ReadLine();
        }
        static void EjercicioForDos(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
        }

        static void Header()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("This meme was made by                                         ");
            Console.WriteLine("Carlos Carrasco, Juan Pablo Hernandez, David Marin Gang       ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();
        }





    }
}

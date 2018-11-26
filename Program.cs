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
            while (exit=0)
                {
            Header();
            Menu();
            Console.WriteLine("Salir?");
            Console.WriteLine("0- No 1- Si");
            Console.Clear();
                }
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
                                    EjercicioIfDos();
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
                                    EjercicioFordos();
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
            Console.Clear();
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
        static void EjercicioIfDos()
            {
            Header();
            int yesno=0;
            Console.WriteLine("Este es la Guia Maestra de Acampar");
            Console.WriteLine("Porfavor conteste...");
            Console.WriteLine("Le falta la linterna?");
            Console.WriteLine("1- Si 2- No");
            if (yesno=1)
                {
                Console.WriteLine("Le falta la linterna, consiguela e intente denuevo");
                }
                else if (yesno=2)
                    {
                    Console.WriteLine("Le falta la mochila?");
                    Console.WriteLine("1- Si 2- No");
                    if (yesno=1)
                    {
                    Console.WriteLine("Consiga la mochila e intente denuevo");
                    }
                    else if (yesno=2)
                    {
                    Console.WriteLine("Le falta la linterna?");
                    Console.WriteLine("1- Si 2- No");
                    if (yesno=1)
                        {
                        Console.WriteLine("Le falta la linterna, consiguela e intente denuevo");
                        }
                        else if (yesno=2)
                            {
                            Console.WriteLine("Le falta las llaves?");
                            Console.WriteLine("1- Si 2- No");
                            if (yesno=1)
                            {
                            Console.WriteLine("Consiga las llaves e intente denuevo");
                            }
                            else if (yesno=2)
                            {
                                Console.WriteLine("Le falta el lonche?");
                                Console.WriteLine("1- Si 2- No");
                                if (yesno=1)
                                    {
                                    Console.WriteLine("Le falta el lonche consiguela e intente denuevo");
                                    }
                                    else if (yesno=2)
                                        {
                                        Console.WriteLine("Le falta las escaleras?");
                                        Console.WriteLine("1- Si 2- No");
                                        if (yesno=1)
                                        {
                                        Console.WriteLine("Consiga las escaleras e intente denuevo");
                                        }
                                        else if (yesno=2)
                                        {
                                        Console.WriteLine("Esta completamente listo para su viaje!");
                                    
                                        }
                                    }
                            }
                        }
                    }
                }
            Console.ReadLine();
            Console.Clear();
        }
        static void EjercicioSwitchDos()
            {
            Header();
            string opcion ="";
            Console.WriteLine("Cual libro le interesa?");
            Console.WriteLine("Los Hermanos Karamzov");
            Console.WriteLine("The Dilbert Future");
            Console.WriteLine("The Shadows of the Wind");
            Console.WriteLine("Mobile Suit Gundam");
            Console.WriteLine("Dagpm");
            Console.WriteLine("Tengen Toppan Gurren Lagann");
            Console.WriteLine("The Rats in the Wall");
            Console.WriteLine("Herbert West : Reanimator");
            opcion = 
            Console.WriteLine("Escribe la  opcion que desee");
            switch (opcion)
                {
                    case "Los Hermanos Karamazov":
                    {
                        Console.WriteLine("Genero-Filosofia ");
                        Console.WriteLine("Autor-Dostoyevsky ");
                        Console.WriteLine("Estrellas- 5 ");
                        Console.WriteLine("Sinopsis- Un hombre decide si vale la pena matar a una vieja, si lo que gana vale mas de lo que ella pierde ");
                    }
                    break;
                    case "The Dilbert Future":
                    {
                        Console.WriteLine("Genero- Comedia ");
                        Console.WriteLine("Autor- Doug Watterson");
                        Console.WriteLine("Estrellas- 3");
                        Console.WriteLine("Sinopsis- Las perspectivas que nos dara el futuro por Doug Watterson");
                    }
                    break;
                    case "The Shadows of the Wind":
                    {
                        Console.WriteLine("Genero- Misterio");
                        Console.WriteLine("Autor- Augustus Mauricio");
                        Console.WriteLine("Estrellas- 5");
                        Console.WriteLine("Sinopsis- En españa un autor descubre un horrible secreto de familia y decide hacer algo al respecto");
                    }
                    break;
                    case "Mobile Suit Gundam":
                    {
                        Console.WriteLine("Genero- Accion");
                        Console.WriteLine("Autor- Sagoru Miyazaki");
                        Console.WriteLine("Estrellas- 5");
                        Console.WriteLine("Sinopsis- En el futuro lejano las armas convencionales no funcionan, solamente robots GIGANTESCOS DE PELEA");
                    }
                    break;
                    case "Dagon":
                    {
                        Console.WriteLine("Genero- Horror");
                        Console.WriteLine("Autor- H.P. Lovecraft");
                        Console.WriteLine("Estrellas- 5");
                        Console.WriteLine("Sinopsis- Una isla pequeña de Inglaterra tiene un horrible secreto el cual su poblacion esconde");
                    }
                    break;
                    case "Tengen Toppan Gurren Laggan":
                    {
                        Console.WriteLine("Genero- Accion");
                        Console.WriteLine("Autor- Studio Trigger");
                        Console.WriteLine("Estrellas- 5");
                        Console.WriteLine("Sinopsis- Las personas han sido atrapadas bajo tierra por miles de años, finalmente salen a ver un mundo muerto");
                    }
                    break;
                    case "The Rats in the Wall":
                    {
                        Console.WriteLine("Genero- Horror");
                        Console.WriteLine("Autor- Howard Phillips");
                        Console.WriteLine("Estrellas- 5");
                        Console.WriteLine("Sinopsis- Las ratas en las paredes tormentan al autor, solamente se escuchan pero nunca se veen.");
                    }
                    break;
                    case "Herbert West : Reanimator":
                    {
                        Console.WriteLine("Genero- Horror");
                        Console.WriteLine("Autor- Lewis Theobald Humphrey Littlewit Ward Phillips Edward Softly");
                        Console.WriteLine("Estrellas- 5");
                        Console.WriteLine("Sinopsis- Un hombre intenta distorsionar la barrera entre la vida y la muerte.");
                    }
                    break;
                }
            Console.WriteLine("Suena como una excelente opcion");
            Console.ReadLine();
            break;


            }
        static void EjercicioForDos(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
        }
        static void EjercicioWhileDos()
            {
            Header();
            Console.WriteLine("");
            string matricula = "";
            while(exit=0)
                {
            Console.WriteLine("Cual es su matricula?");
            Console.WriteLine("E.j. T024032");
            matricula = Console.ReadLine();
            if (MyString[0]=T)
                    {
                    Console.WriteLine("Matricula verificada");
                    }
            else 
                    {
                    Console.WriteLine("Matricula no aceptable, Denegada");
                    }
            Console.WriteLine("Desea salir del verificador?");
            Console.WriteLine("0- No 1- Si");
            exit = int.Parse(Console.ReadLine());
            }
            }
        static void EjercicioArrayDos()
            {
            
            }
    }
}

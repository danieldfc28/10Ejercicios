using System;
using System.Text.RegularExpressions;

namespace _10Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            
            do
            {
                Menu();
                Marco();

                Console.SetCursorPosition(47, 18); Console.Write("╔═");
                Console.SetCursorPosition(52, 18); Console.Write("═╗");
                Console.SetCursorPosition(47, 22); Console.Write("╚═");
                Console.SetCursorPosition(52, 22); Console.Write("═╝");
                Console.SetCursorPosition(50, 20); option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    // 1. Leer un número por teclado y definir si es par o impar
                    case 1:
                        Console.Clear();
                        ParImpar();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    // 2. Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10
                    case 2:
                        Console.Clear();
                        TablasMultiplicarN();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    // 3. Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10
                    case 3:
                        Console.Clear();
                        TablasMultiplicar();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    // 4. Leer un número por teclado y definir si es primo o no
                    case 4:
                        Console.Clear();
                        NumeroPrimo();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    // 5. Dado el vector edad = [12,50,23,10,18,35,41,85,16,45], ordenarlos en forma ascendiente
                    case 5:
                        Console.Clear();
                        OrdenarVector();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    /* 6. Datos los vectores
                    edad = [12,50,23,10,18,35,41,85,16,45]
                    nombre = ["juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady"]
                    Leer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje
                    que el nombre no existe */
                    case 6:
                        Console.Clear();
                        LeerNombreMostrarEdad();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    // 7. Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres con su edad. 
                    case 7:
                        Console.Clear();
                        EdadMayorMenor();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    // 8. Dado una palabra definir si es palíndromo o no.
                    case 8:
                        Console.Clear();
                        Palidromo();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    case 0:

                        break;
                    default:
                        OpcionIncorrecta();
                        option = int.Parse(Console.ReadLine());
                        break;
                }
            } while (option != 0);


        }

        static void Menu()        
        {
            
            Console.Clear();
            Console.SetCursorPosition(50, 3); Console.WriteLine("MENU");
            Console.SetCursorPosition(35, 6); Console.WriteLine("1. Numero par o impar");
            Console.SetCursorPosition(35, 7); Console.WriteLine("2. Tablas de multiplicar de n del 1 al 10");
            Console.SetCursorPosition(35, 8); Console.WriteLine("3. Tablas de multiplicar del 2 al 9");
            Console.SetCursorPosition(35, 9); Console.WriteLine("4. Numero primo");
            Console.SetCursorPosition(35, 10); Console.WriteLine("5. Ordenar numeros de forma ascendente");
            Console.SetCursorPosition(35, 11); Console.WriteLine("6. Leer nombre y mostrar edad");
            Console.SetCursorPosition(35, 12); Console.WriteLine("7. Edad mayor y menor");
            Console.SetCursorPosition(35, 13); Console.WriteLine("8. Palabra palindromo");
            Console.SetCursorPosition(35, 14); Console.WriteLine("0. Salir del programa");
            Console.SetCursorPosition(35, 15); Console.WriteLine("Ingresa el numero de ejercicio que quieres ver...");


        }

        static void OpcionIncorrecta()
        {
            Console.Clear();
            for (int i = 35; i <= 85; i++)
            {
                Console.SetCursorPosition(i, 1); Console.Write("═");
                Console.SetCursorPosition(i, 15); Console.Write("═");
            }

            for (int i = 2; i <= 15; i++)
            {
                Console.SetCursorPosition(35, i); Console.Write("▓");
                Console.SetCursorPosition(85, i); Console.Write("▓");
            }

            Console.SetCursorPosition(35, 1); Console.Write("╔");
            Console.SetCursorPosition(85, 1); Console.Write("╗");
            Console.SetCursorPosition(35, 15); Console.Write("╚");
            Console.SetCursorPosition(85, 15); Console.Write("╝");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(50, 5); Console.WriteLine("Esta opcion no existe...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(40, 10); Console.WriteLine("Presione una tecla para regresar al menu...");
            Console.ReadKey();
            Menu();

        }

        // 1. Leer un número por teclado y definir si es par o impar
        static void ParImpar()
        {            
            int num;
            Console.WriteLine("Ingresa un numero");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " es par");
            }
            else
            {
                Console.WriteLine(num + " es impar");

            }
        }

        // 2. Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10
        static void TablasMultiplicarN()
        {
            int num, result;
            Console.WriteLine("Ingresa el numero de tabla de multiplicar que quieres ver");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine(num + " x " + i + " = " + result);
            }

        }

        // 3. Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10
        static void TablasMultiplicar()
        {
            int result;
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine("Tabla del " + i);
                for (int j = 1; j <= 10; j++)
                {
                    result = i * j;
                    Console.WriteLine(i + " x " + j + " = " + result);
                }
                Console.WriteLine();
            }
        }

        // 4. Leer un número por teclado y definir si es primo o no
        static void NumeroPrimo()
        {
            int num, m;
            bool esPrimo = true;
            Console.WriteLine("Ingresa un numero");
            num = int.Parse(Console.ReadLine());
            m = num / 2;
            for (int i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("El numero no es primo");
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo == true)
                Console.WriteLine("El numero es primo");
        }

        // 5. Dado el vector edad = [12,50,23,10,18,35,41,85,16,45], ordenarlos en forma ascendiente
        static void OrdenarVector()
        {
            int[] edades = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
            int temp;

            Console.WriteLine("Vector inicial desordenado");
            MostrarVector(edades);

            for (int i = 1; i < edades.Length; i++)
            {
                for (int j = 0; j < edades.Length - i; j++)
                {
                    if (edades[j] > edades[j + 1])
                    {
                        temp = edades[j];
                        edades[j] = edades[j + 1];
                        edades[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Vector final ordenado");
            MostrarVector(edades);
        }

        static void MostrarVector(int[] vector)
        {
            foreach (int item in vector)
            {
                Console.Write(item + "|");
            }
            Console.WriteLine();
        }

        /* 6. Datos los vectores
            edad = [12,50,23,10,18,35,41,85,16,45]
            nombre = ["juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady"]
            Leer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje
            que el nombre no existe */
        static void LeerNombreMostrarEdad()
        {
            int[] edades = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
            string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            string nombre;
            bool existe = false;

            Console.WriteLine("Ingrese un nombre para ver su edad");
            nombre = Console.ReadLine();

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombre.ToLower() == nombres[i])
                {
                    Console.WriteLine("La edad de " + nombres[i] + " es " + edades[i]);
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                Console.WriteLine("Este nombre no existe");
            }
        }

        /* 7. Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres
        con su edad. */
        static void EdadMayorMenor()
        {
            int[] edades = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
            string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            int mayor = -1, menor = int.MaxValue;
            string nombreMayor = "", nombreMenor = "";

            Console.WriteLine("Considerando lo siguiente");
            MostrarVector(edades);

            foreach (string item in nombres)
            {
                Console.Write(item + "|");
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < edades.Length; i++)
            {
                if (edades[i] > mayor)
                {
                    mayor = edades[i];
                    nombreMayor = nombres[i];
                }
                else if (edades[i] < menor)
                {
                    menor = edades[i];
                    nombreMenor = nombres[i];
                }
            }

            Console.WriteLine(
                "El mayor es " + nombreMayor + " con " + mayor + " años de edad" +
                "\nEl menor es " + nombreMenor + " con " + menor + " años de edad"
            );
        }

        // 8. Dado una palabra definir si es palíndromo o no.
        static void Palidromo()
        {
            string palabra, palabraInvertida = "";

            Console.WriteLine("Ingrese una palabra para verificar si es palidromo o no");
            palabra = Console.ReadLine();

            foreach (char letra in palabra)
            {
                palabraInvertida = letra + palabraInvertida;
            }

            if (RemoverEspaciosBlancos(palabra) == RemoverEspaciosBlancos(palabraInvertida))
            {
                Console.WriteLine("La palabra '" + palabra + "' es un palidromo");

            }
            else
            {
                Console.WriteLine("La palabra '" + palabra + "' no es un palidromo");
            }

        }

        static void Marco()
        {
            for (int i = 1; i <= 110; i++)
            {
                Console.SetCursorPosition(i, 1); Console.Write("█");
                Console.SetCursorPosition(i, 25); Console.Write("█");
            }

            for (int i = 1; i <= 25; i++)
            {
                Console.SetCursorPosition(1, i); Console.Write("█");
                Console.SetCursorPosition(110, i); Console.Write("█");
            }

            Console.SetCursorPosition(1, 1); Console.Write("╔═");
            Console.SetCursorPosition(109, 1); Console.Write("═╗");
            Console.SetCursorPosition(1, 25); Console.Write("╚═");
            Console.SetCursorPosition(109, 25); Console.Write("═╝");
        }


        static string RemoverEspaciosBlancos(string palabra)
        {
            return Regex.Replace(palabra, @"\s+", "");
        }
    }
}

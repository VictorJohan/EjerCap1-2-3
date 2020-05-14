using System;

namespace EjerCap1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte op = 0, op2 = 0, op3 = 0;
            

            do
            {
                Console.Clear();
                Console.Write("Elige un capitulo:\n1.Capitulo 1\n2.Capitulo 2\n3.Capitulo 3\n4.Salir\n\nOpcion: ");

                op = byte.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1://Capitulo 1************************************************************************************
                        
                        do
                        {
                            Console.Clear();
                            Console.Write("1.Ejercicio 1\n2.Ejercicio 5\n3.Salir\n\nOpcion: ");
                            op = byte.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1://Capitulo 1 - Ejercicio 1-------------------------------------------------------------------
                                    Console.Clear();
                                    Console.WriteLine("Victor Johan Palma Rodriguez");
                                    Console.ReadKey();
                                    break;
                                case 2://Capitulo 1 - Ejercicio 5------------------------------------------------------------------
                                    Console.Clear();
                                    Console.WriteLine("Yo estudio Ing. Sitemas");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("No hay un caso contemplado para esta opcion...");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (op != 3);
                        break;
                    case 2://Capitulo 2******************************************************************************************

                        do
                        {
                            Console.Clear();
                            Console.Write("1.Ejercicio 1\n2.Ejercicio 3\n3.Ejercicio 5\n4.Salir\n\nOpcion: ");
                            op2 = byte.Parse(Console.ReadLine());
                            switch (op2)
                            {
                                case 1://Capitulo 2 - Ejercicio 1------------------------------------------------------------------------
                                    Console.Clear();
                                    float cantLado = 0, longLado = 0, resulatado = 0;
                                    Console.Write("¿Cuantos lados tiene el poligono regular?: ");
                                    cantLado = int.Parse(Console.ReadLine());

                                    Console.Write("\nLongitud de lados: ");
                                    longLado = int.Parse(Console.ReadLine());

                                    resulatado = cantLado * longLado;

                                    Console.WriteLine($"Perimetro: {resulatado}");
                                    Console.ReadKey();
                                    break;
                                case 2://Capitulo 2 - Ejercicio 3---------------------------------------------------------------------
                                    Console.Clear();
                                    const int MEMDIO_RADIO = 180;
                                    const float PI = 3.14f;
                                    float grados = 0, radianes = 0;

                                    Console.Write("Grados: ");
                                    grados = int.Parse(Console.ReadLine());

                                    radianes = grados * (PI / MEMDIO_RADIO);

                                    Console.WriteLine($"\nRadianes: {radianes}");

                                    Console.ReadKey();
                                    break;
                                case 3://Capitulo 2 - Ejercicio 5-------------------------------------------------------------------
                                    Console.Clear();
                                    float valorDolar = 0, valorEuro = 0, dolar = 0, euro = 0, dolarAEuro = 0, euroADolar = 0;

                                    Console.Write("Cuantos euros vale el dolar: E");
                                    valorDolar = float.Parse(Console.ReadLine());

                                    Console.Write("\nCuantos dolares vale el euro: $");
                                    valorEuro = float.Parse(Console.ReadLine());

                                    Console.Write("\nDolar a euro: $");
                                    dolar = float.Parse(Console.ReadLine());

                                    Console.Write("\nEuro a dolar: E");
                                    euro = float.Parse(Console.ReadLine());

                                    dolarAEuro = valorEuro * dolar;
                                    euroADolar = valorDolar * euro;

                                    Console.WriteLine($"Dolar: ${euroADolar}\nEuro: E{dolarAEuro}");
                                   
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("No hay un caso contemplado para esta opcion...");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (op2 != 4);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("No hay un caso contemplado para esta opcion...");
                        Console.ReadKey();
                        break;
                    case 3://Capitulo 3***************************************************************************

                        do
                        {
                            Console.Clear();
                            Console.Write("1.Ejercicio 1\n2.Ejercicio 4\n3.Salir\n\nOpcion: ");
                            op = byte.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1://Capitulo 3 - Ejercicio 1--------------------------------------------------------------
                                    Console.Clear();
                                    int num = 0;

                                    Console.Write("Diginte un numero: ");
                                    num = int.Parse(Console.ReadLine());

                                    if (num % 2 == 0)
                                    {
                                        Console.WriteLine($"{num} es par");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{num} no es par");
                                    }
                                    Console.ReadKey();
                                    break;
                                case 2://Capitulo 3 - Ejercicio 4--------------------------------------------------------------
                                    Console.Clear();
                                    Console.Write("Digita un dia un numero de 1-7: ");
                                    op3 = byte.Parse(Console.ReadLine());

                                    switch (op3)
                                    {
                                        case 1:
                                            Console.WriteLine("Lunes");
                                            Console.ReadKey();
                                            break;
                                        case 2:
                                            Console.WriteLine("Martes");
                                            Console.ReadKey();
                                            break;
                                        case 3:
                                            Console.WriteLine("Miercoles");
                                            Console.ReadKey();
                                            break;
                                        case 4:
                                            Console.WriteLine("Jueves");
                                            Console.ReadKey();
                                            break;
                                        case 5:
                                            Console.WriteLine("Viernes");
                                            Console.ReadKey();
                                            break;
                                        case 6:
                                            Console.WriteLine("Sabado");
                                            Console.ReadKey();
                                            break;
                                        case 7:
                                            Console.WriteLine("Domingo");
                                            Console.ReadKey();
                                            break;
                                        default:
                                            Console.WriteLine($"El dia {op} no existe");
                                            Console.ReadKey();
                                            break;
                                    }
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("No hay un caso contemplado para esta opcion...");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (op != 3);
                        break;
                    case 4:
                        break;

                }
            } while (op != 4);
        }
    }
}

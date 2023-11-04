using Calculos_Especiales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculadora Sencilla");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Area de un rectamgulo");
                Console.WriteLine("6. Area de un circulo");
                Console.WriteLine("7. Promedio de tres numeros");
                Console.WriteLine("8. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    if (opcion == 8)
                    {
                        break;
                    }

                    Console.Write("Ingrese los números separados por espacios: ");
                    string entrada = Console.ReadLine();
                    string[] numerosStr = entrada.Split(' ');
                    double[] numeros = new double[numerosStr.Length];

                    for (int i = 0; i < numerosStr.Length; i++)
                    {
                        if (double.TryParse(numerosStr[i], out double numero))
                        {
                            numeros[i] = numero;
                        }
                        else
                        {
                            Console.WriteLine("Error: Uno de los números no es válido.");
                            break;
                        }
                    }

                    try
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Resultado: " + Calculadora.Sumar(numeros));
                                break;
                            case 2:
                                Console.WriteLine("Resultado: " + Calculadora.Restar(numeros));
                                break;
                            case 3:
                                Console.WriteLine("Resultado: " + Calculadora.Multiplicar(numeros));
                                break;
                            case 4:
                                Console.WriteLine("Resultado: " + Calculadora.Dividir(numeros));
                                break;
                            case 5:
                                Console.WriteLine("Ingrese la base del rectangulo: ");
                                Console.WriteLine("Ingrese la altura del rectangulo: ");
                                Console.WriteLine($"El area del rectangulo es: {Area_Rec} " + Area_Rec + "cm2");
                                
                                break;
                            case 6:
                                Console.WriteLine("Ingrese el radio del circulo: ");
                                Console.WriteLine("El radio del circulo es: " + Area_Cir );
                            break;
                            case 7: 
                                Console.WriteLine(" Ingrese 3 numeros: ");
                                Console.WriteLine("");

                            default:
                                Console.WriteLine("Opción no válida.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }

                Console.WriteLine();
            }
        }
    }
}

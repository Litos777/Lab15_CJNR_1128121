using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_CJNR_1128121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO, SELECCIONE UNA OPCION");
            string opcion = "";
            do
            {
                Console.WriteLine("1 - Opcion 1\n" +
                              "2 - Opcion 2\n" +
                              "3 - Salir");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        string[] nombre = new string[5];
                        int[] edad = new int[5];
                        int edadM = 0, id = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Ingrese su nombre");
                            nombre[i] = Console.ReadLine();
                            Console.WriteLine("Ingrese su edad");
                            edad[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            if (i == 0)
                            {
                                edadM = edad[i];
                                id = i;
                            }
                            else
                            {
                                if (edadM < edad[i])
                                {
                                    edadM = edad[i];
                                    id = i;
                                }
                            }
                        }
                        Console.WriteLine("{0} tiene {1} años y es el mayor", nombre[id], edadM);
                        break;
                    case "2":
                        double notaM = 0.0, notam = 0.0, prom = 0.0;
                        string[] persona = new string[5];
                        double[] notas = new double[5];
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Ingrese su nombre y apellido");
                            persona[i] = Console.ReadLine();
                            Console.WriteLine("Ingrese su nota");
                            notas[i] = Convert.ToDouble(Console.ReadLine());
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            prom += notas[i];
                            if (i == 0)
                            {
                                notaM = notas[i];
                                notam = notas[i];
                            }
                            else
                            {
                                if (notaM < notas[i])
                                {
                                    notaM = notas[i];
                                }
                                if (notam > notas[i])
                                {
                                    notam = notas[i];
                                }
                            }
                        }
                        prom = prom / 5;
                        Console.WriteLine("La nota mas alta es {0}, la mas baja es {1} y la nota" +
                            "promedio es {2}", notaM, notam, prom);
                        for (int i = 0; i < 5; i++)
                        {
                            if (notas[i] >= 71)
                            {
                                Console.WriteLine("{0} aprobo con {1}", persona[i], notas[i]);
                            }
                            else
                            {
                                Console.WriteLine("{0} reprobo con {1}", persona[i], notas[i]);
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("Fin del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opcion != "3");
            Console.ReadKey();

        }
    }
}
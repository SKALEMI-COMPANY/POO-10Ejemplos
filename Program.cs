using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Skalemi Company
// Si te surge alguna duda, contáctame.
// michaelvinces.skalemi@gmail.com

namespace POO_10Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuActivo = true;
            while (menuActivo)
            {
                menuActivo = MenuBasico();
            }
            Console.ReadKey();
        }
        private static bool MenuBasico()
        {
            Console.WriteLine("--------| PRÁCTICA 1 |--------");
            Console.WriteLine("Programas elaborados por SKALEMI COMPANY\n");
            Console.WriteLine("01. Número Mayor");
            Console.WriteLine("02. Cuadrado de asteriscos");
            Console.WriteLine("03. Factura");
            Console.WriteLine("04. Salarios");
            Console.WriteLine("05. Pirámide de asteriscos");
            Console.WriteLine("06. Rombo de asteriscos");
            Console.WriteLine("07. Columnas de números del 1 al 100");
            Console.WriteLine("08. Contar números");
            Console.WriteLine("09. Tabla de Multiplicar");
            Console.WriteLine("10. Menú");
            Console.WriteLine("11. Salir");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Elija la opción que quiera procesar");
            Console.WriteLine("________________________________________________");
            string opcion = Console.ReadLine();
            Console.Clear();
            if (opcion == "1")
            {
                Console.WriteLine("Programa 1");
                Console.WriteLine("*************************************************");
                Console.WriteLine("**************     NÚMERO MAYOR      ************");
                Console.WriteLine("*************************************************");
                int contador = 0, mayor = 0;
                Console.WriteLine("Ingrese la cantidad de números quiere digitar: ");
                byte cantidad = byte.Parse(Console.ReadLine());
                Console.WriteLine("________________________________________________");
                while (contador < cantidad)
                {
                    contador++;
                    Console.WriteLine("Digite el número " + contador + ": ");
                    int numeros = int.Parse(Console.ReadLine());
                    Console.WriteLine("________________________________________________");
                    if (numeros > mayor)
                    {
                        mayor = numeros;
                    }
                }
                Console.WriteLine("El número mayor de los " + contador + " números ingresados es " + mayor + ".\n");
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();

                return true;
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Programa 2");
                Console.WriteLine("*************************************************");
                Console.WriteLine("********     CUADRADO DE ASTERISCOS      ********");
                Console.WriteLine("*************************************************");
                int superior = 0, laterales = 0, inferior = 0, lados = 0, contador = 0;
                Console.WriteLine("Digite un número entero: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("El cuadrado queda de la siguiente forma: ");
                while (numero > superior)
                {
                    superior++;
                    Console.Write("* ");
                }
                Console.WriteLine();
                lados = numero - 2;
                numero = numero - 2;
                while (lados > contador)
                {
                    contador++;
                    while (numero > laterales)
                    {
                        laterales++;
                        if (laterales == 1)
                        {
                            Console.Write("*");
                        }
                        Console.Write("  ");
                        if (laterales == numero)
                        {
                            Console.Write(" *");
                            Console.WriteLine();
                        }
                    }
                    laterales = 0;
                }
                numero = numero + 2;
                while (numero > inferior)
                {
                    inferior++;
                    Console.Write("* ");
                }
                Console.WriteLine("\nPresione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Programa 3");
                int contador = 0, salida = 1;
                float total = 0, efectivo = 0;
                Console.WriteLine("*************************************************");
                Console.WriteLine("*****************    FACTURA      ***************");
                Console.WriteLine("*************************************************");
                Console.WriteLine("Para terminar la factura en la cantidad digite 0.");
                do
                {
                    contador++;
                    Console.Write("Introduzca la cantidad vendida \ndel producto " + contador + ": ");
                    int cantidad = int.Parse(Console.ReadLine());
                    if (cantidad != 0)
                    {
                        Console.Write("Introduzca el precio del producto: ");
                        float precio = float.Parse(Console.ReadLine());
                        Console.WriteLine("________________________________________________");
                        total = cantidad * precio;
                        efectivo = efectivo + total;
                    }
                    else
                    {
                        salida = salida - 1;
                    }

                } while (salida != 0);
                Console.WriteLine("________________________________________________");
                Console.WriteLine("El total a pagar es de " + efectivo + "$.");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "4")
            {
                Console.WriteLine("Programa 4");
                Console.WriteLine("*************************************************");
                Console.WriteLine("**************     SALARIOS      ************");
                Console.WriteLine("*************************************************");
                int horasextras = 0, salarioextra = 0, salariosemanal = 0, continuar = 0;
                string Respuesta, Empleado;
                do
                {
                    Console.WriteLine("Ingrese el nombre del Empleado: ");
                    Empleado = Console.ReadLine();
                    Console.Write("Ingrese las horas que trabajo " + Empleado + " en la semana: ");
                    int horas = int.Parse(Console.ReadLine());
                    if (horas <= 35)
                    {
                        salariosemanal = horas * 15;
                    }
                    else
                    {
                        horasextras = horas - 35;
                        salarioextra = horasextras * 22;
                        salariosemanal = salarioextra + 525;
                    }
                    Console.WriteLine("El salario semanal de " + Empleado + " es de " + salariosemanal + "$.");
                    Console.WriteLine("________________________________________________");
                    do
                    {
                        continuar = 0;
                        Console.WriteLine("Desea calcular otro salario? Responda Si o No ");
                        Respuesta = Console.ReadLine();
                        Console.WriteLine("________________________________________________");
                        if (!Respuesta.Equals("Si") && !Respuesta.Equals("No"))
                        {
                            continuar = 1;
                            Console.WriteLine("ERROR.... Solo puede responder con Si o No.");
                            Console.WriteLine("________________________________________________");
                        }

                    } while (continuar == 1);
                } while (Respuesta.Equals("Si"));
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "5")
            {
                Console.WriteLine("Programa 5");
                Console.WriteLine("*************************************************");
                Console.WriteLine("*******      PIRÁMIDE DE ASTERISCOS      ********");
                Console.WriteLine("*************************************************");
                int aterisco = 1, contador = 0, altura = 0, veces = 0;
                Console.Write("Ingrese un número entero para mostrar\nsu piramide correspondiente: ");
                int numero = int.Parse(Console.ReadLine());
                while (numero > contador)
                {
                    contador++;
                    if (contador != numero)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("*");

                altura = numero;
                while (altura > 0)
                {
                    altura = altura - 1;
                    contador = 0;
                    while (altura > contador)
                    {
                        contador++;
                        if (contador != altura)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            aterisco = aterisco + 2;
                            veces = 0;
                            do
                            {
                                veces++;
                                Console.Write("*");
                            } while (aterisco > veces);
                            Console.WriteLine(" ");
                        }

                    }
                }
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "6")
            {
                Console.WriteLine("Programa 6");
                Console.WriteLine("*************************************************");
                Console.WriteLine("*********     ROMBO DE ASTERISCOS      **********");
                Console.WriteLine("*************************************************");
                int arriba, abajo;
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());
                arriba = 0;
                while (arriba < numero)
                {
                    arriba++;
                    abajo = numero - arriba;
                    while (abajo > 0)
                    {
                        abajo = abajo - 1;
                        Console.Write(" ");
                    }
                    abajo = 0;
                    while (abajo < arriba)
                    {
                        abajo++;
                        Console.Write(" *");
                    }
                    Console.WriteLine(" ");
                }
                arriba = -1;
                while (arriba <= numero)
                {
                    arriba++;
                    abajo = 0;
                    while (abajo <= arriba)
                    {
                        abajo++;
                        Console.Write(" ");
                    }
                    abajo = numero - arriba - 1;
                    while (abajo > 0)
                    {
                        abajo = abajo - 1;
                        Console.Write(" *");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "7")
            {
                Console.WriteLine("Programa 7");
                Console.WriteLine("*************************************************");
                Console.WriteLine("***********    Contar del 1 al 100      *********");
                Console.WriteLine("*************************************************");
                int ascendente = 101, decendente = 0;

                Console.WriteLine();
                Console.WriteLine("           Ascendente    Descendente");
                while (decendente < 100)
                {
                    decendente++;
                    ascendente = ascendente - 1;
                    Console.Write("               " + decendente);
                    if (decendente < 10)
                    {
                        Console.Write("            ");
                    }
                    if (decendente >= 10 && decendente < 100)
                    {
                        Console.Write("           ");
                    }
                    if (decendente == 100)
                    {
                        Console.Write("          ");
                    }
                    Console.WriteLine(ascendente);
                }
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "8")
            {
                Console.WriteLine("Programa 8");
                Console.WriteLine("*************************************************");
                Console.WriteLine("************     CONTAR NÚMEROS      ************");
                Console.WriteLine("*************************************************");
                int Entero, enUno = 0, enDos = -1, enTres = -2;
                do
                {
                    Console.Write("Ingrese un número entero positivo: ");
                    Entero = int.Parse(Console.ReadLine());
                    if (Entero <= 0)
                    {
                        Console.WriteLine("ERROR.... El número ingresado es incorrecto.");
                    }
                    else
                    {
                        Console.WriteLine("Columna1  Columna2  Columna3");
                        while (enUno < Entero)
                        {
                            enUno++;
                            enDos = enDos + 2;
                            enTres = enTres + 3;


                            if (enUno <= Entero && enDos <= Entero && enTres <= Entero)
                            {
                                if (enUno < 10)
                                {
                                    Console.Write("   " + enUno + "         ");
                                }
                                else
                                {
                                    Console.Write("   " + enUno + "        ");
                                }
                                if (enDos < 10)
                                {
                                    Console.Write(enDos + "         ");
                                }
                                else
                                {
                                    Console.Write(enDos + "        ");
                                }

                                Console.WriteLine(enTres);
                            }
                            else
                            {
                                if (enUno <= Entero && enDos <= Entero)
                                {
                                    Console.Write("   " + enUno + "        ");
                                    Console.WriteLine(enDos);
                                }
                                else
                                {
                                    Console.WriteLine("   " + enUno);
                                }

                            }
                        }
                    }
                } while (Entero < 0);
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "9")
            {
                Console.WriteLine("Programa 9");
                Console.WriteLine("*************************************************");
                Console.WriteLine("********     TABLA DE MULTIPLICAR      **********");
                Console.WriteLine("*************************************************");
                int Contador = 0, Resultado;
                Console.Write("Ingrese número entero para mostras su tabla de multiplicar: ");
                int Entero = int.Parse(Console.ReadLine());
                while (Contador < 15)
                {
                    Contador++;
                    Resultado = Contador * Entero;
                    Console.Write(Entero);
                    Console.Write(" * " + Contador);
                    Console.WriteLine(" = " + Resultado);
                }
                Console.WriteLine("Presione Enter para volver al menú...");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
            else if (opcion == "11")
            {
                Console.WriteLine("Gracias por usar mi Programa...\nMichael Vinces Andrade te agradece... :)");
                Console.ReadLine();
                Console.Clear();
                return false;
            }
            else if (opcion == "10")
            {
                Console.WriteLine("Programa 10");
                int Opcion;
                do
                {
                    do
                    {
                        Console.WriteLine("--------   Menú   --------");
                        Console.WriteLine("1.Salir ");
                        Console.WriteLine("2. Sumatoria");
                        Console.WriteLine("3. Factorial");
                        Console.WriteLine("Elija la opción que quiera procesar");
                        Opcion = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (Opcion < 1 || Opcion > 5)
                        {
                            Console.WriteLine("ERROR...Ingrese una opción válida.");
                        }
                    } while (Opcion < 1 || Opcion > 3);

                    switch (Opcion)
                    {
                        case 1:
                            {
                                Console.WriteLine("Presione Enter para volver al menú...");
                                break;
                            }
                        case 2:
                            {
                                Sumatoria Suma = new Sumatoria();
                                Console.WriteLine("Indique un numero entero para realizar\nsu respectiva sumatoria: ");
                                Suma.NumeroSum = Convert.ToInt32(Console.ReadLine());
                                int contador = 0, secuencia = 0;
                                while (contador < Suma.NumeroSum)
                                {
                                    contador++;
                                    if (contador == 1)
                                    {
                                        Console.Write("Sumatoria= ");
                                        secuencia = Suma.NumeroSum;
                                    }
                                    if (secuencia != 1)
                                    {
                                        Console.Write(secuencia + " + ");
                                        Suma.SumatoriaTotal = Suma.SumatoriaTotal + secuencia;
                                        secuencia = secuencia - 1;
                                    }
                                    else
                                    {
                                        Suma.SumatoriaTotal = Suma.SumatoriaTotal + secuencia;
                                        Console.WriteLine(secuencia + " = " + Suma.SumatoriaTotal);
                                    }
                                }

                                Console.WriteLine("El resultado de la sumatoria del número " + Suma.NumeroSum + " es: " + Suma.SumatoriaTotal);
                                Console.WriteLine("________________________________________________");
                                Console.WriteLine("Presione Enter para volver al menú...");
                                Console.WriteLine("________________________________________________");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                        case 3:
                            {
                                Factorial Facto = new Factorial();
                                Console.WriteLine("Indique un numero entero para realizar\nsu respectivo factorial: ");
                                Facto.NumeroFact = Convert.ToInt32(Console.ReadLine());
                                int contador = 0, secuencia = 0;
                                while (contador < Facto.NumeroFact)
                                {
                                    contador++;
                                    if (contador == 1)
                                    {
                                        Console.Write(Facto.NumeroFact + "!= ");
                                        secuencia = Facto.NumeroFact;
                                    }
                                    if (secuencia != 1)
                                    {
                                        Console.Write(secuencia + " * ");
                                        if (secuencia > 1)
                                        {
                                            Facto.FactorialTotal = Facto.FactorialTotal * secuencia;
                                            secuencia = secuencia - 1;
                                        }

                                    }
                                    else
                                    {
                                        if (secuencia > 1)
                                        {
                                            Facto.FactorialTotal = Facto.FactorialTotal * secuencia;
                                        }


                                        Console.WriteLine(secuencia + " = " + Facto.FactorialTotal);
                                    }
                                }
                                Console.WriteLine("El resultado del factorial del número " + Facto.NumeroFact + " es: " + Facto.FactorialTotal);
                                Console.WriteLine("________________________________________________");
                                Console.WriteLine("Presione Enter para volver al menú...");
                                Console.WriteLine("________________________________________________");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                    }

                } while (Opcion != 1);
            }
            Console.ReadLine();
            Console.Clear();
            return false;

        }
    }

}

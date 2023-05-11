using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acthoy
{
    class Program
    {
        static void Main(string[] args)
        {
            int viajes, cantMenores, pasaje, pasajemenor, edadmenor, edad, i, seguro;
            double recaudacionviaje, recaudaciontotal, ticket, descuento,total;
            Console.WriteLine("Ingrese la cantidad de viajes a realizar");
            viajes = Convert.ToInt32(Console.ReadLine());
            recaudaciontotal = 0;
            for (i = 0; i < viajes; i++)
{
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Inicia el viaje {0}", i + 1);
                cantMenores = 0;
                recaudacionviaje = 0;
                pasaje = 0;
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Ingrese la edad - -1 para terminar");
                edad = Convert.ToInt32(Console.ReadLine());
                pasajemenor = pasaje;
                edadmenor = edad;
                while (edad != -1)
                    {
                    descuento = 0;
                    seguro = 0;
                    pasaje++;
                    ticket = 3;
                    

                    if (edad < 12)
                    {
                        cantMenores++;
                        descuento = ticket / 2;
                    }
                    else
                    {
                        if (edad < 17)
                        {
                            descuento = ticket * (1.0 / 4.0);
                        }
                    }

                    if (edad < edadmenor)
                    {
                        edadmenor = edad;
                        pasajemenor = pasaje;
                    }

                    total = ticket - descuento;

                    if (edad > 12)
                    {
                        seguro = 1;
                        total+= seguro;
                    }

                    Console.WriteLine("Precio del ticket: "+ticket);
                    Console.WriteLine("Descuento por menor de edad: " + descuento);
                    Console.WriteLine("Extra por seguro: " + seguro);
                    Console.WriteLine("Precio final del ticket: " + total);
                    recaudacionviaje += total;
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Ingrese la edad - -1 para terminar");
                    edad = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("En el viaje hubieron {0} menores",cantMenores);
                Console.WriteLine("La recaudacion total del viaje fue de: {0:c}",recaudacionviaje);
                recaudaciontotal += recaudacionviaje;
                if (pasaje > 0)
                {
                    Console.WriteLine("El pasajero nro {0} fue el de menor edad con {1} años",pasajemenor,edadmenor);
                }
                else
                {
                    Console.WriteLine("No hubo pasajeros");
                }
            }
            Console.WriteLine("El total recaudado en el dia fue de: {0:c}", recaudaciontotal);
            Console.ReadKey();
        }
    }
}

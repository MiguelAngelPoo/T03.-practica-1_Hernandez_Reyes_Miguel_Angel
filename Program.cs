using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Evaluativa_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //instancia 
            Operaciones Op = new Operaciones();

            Persona Perso = new Persona();

            Inicio();


            //Menu de opciones para buscar
           void Inicio()
           {
                int ops;
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("1.Buscar Persona");
                Console.WriteLine("2.Mostrar todas las personas");

                Console.WriteLine("ingrese opcion");
                ops = Convert.ToInt32(Console.ReadLine());

                switch (ops)
                {
                    case 1:
                        //captura del id a buscar
                        Console.WriteLine("id a buscar: ");
                        Perso.Id = Convert.ToInt32(Console.ReadLine());
                        Op.BuscarPersona(Perso.Id);
                        Console.Clear();
                        Inicio();
                        break;


                    case 2:
                        //opcion extra que no estaba muy seguro si tenia que estar pero muestra los datos del archivo
                        Op.Mirar();
                        Console.Clear();
                        Inicio();
                        break;

                    case 3:

                        break;

                    default:
                        break;
                }
            }


           
            
            
            

        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P.Evaluativa_1
{
    public class Operaciones
    {
        Program Pro = new Program();
        int Val;

        public Persona BuscarPersona(int id)
        {
            var personas = ObtenerPersonas(id);
            var p = (from persona in personas
                     where persona.Id == id
                     select persona).First();
            return p;
            //Busca dentro de persona y en las personas si el id es igual al buscado se selecciona 
        }



        public List<Persona> ObtenerPersonas(int id)
        {
            var datos = ObtenerLineas();
            List<Persona> personas = new List<Persona>();
            Persona Pe = new Persona();
            //listas y instancias

            
            //busca dentro de la lista
            foreach (var item in datos)
            {
                string[] info = item.Split(',');
                Persona persona = new Persona
                {   //arreglo
                    Id = int.Parse(info[0]),
                    Nombre = info[1],
                    Profesion = info[2],
                    Edad = int.Parse(info[3])
                };

                //condicion para desplegar los valores  en caso de que id coincida con el de la lista
                if (id == persona.Id )
                {
                    Console.WriteLine("  Id:" + persona.Id + "  Nombre:" + persona.Nombre + "  Profecion:" + persona.Profesion + "  edad:" + persona.Edad);
                    Console.ReadKey();
                   
                    
                    //Val = 1; valor que se estaba probando para una condicion 
                }

               
                //agrega a personas
                personas.Add(persona);
              
            }

            


            return personas;
        }




        //opcion de mirar todos los datos del archivo
        public void Mirar()
        {
            using (StreamReader leer = new StreamReader("Datos.txt"))
            {
                //lee el archivo y muestra todo

                while (!leer.EndOfStream)
                {
                    string x = leer.ReadLine();
                    Console.WriteLine(x);
                    Console.ReadKey();
                }
            }

        }




        public List<string> ObtenerLineas()
        {
          try
           {

                

           List<string> lineas = new List<string>();

            string[] info = null;


                if (File.Exists("Datos.txt"))
                {
                    info = File.ReadAllLines("Datos.txt");
                    Console.ReadKey();
                }

            foreach (string item in info)
                {

                    lineas.Add(item);
                }

                return lineas;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Valor erroneo");

            }
            return null;
        }


    }





}

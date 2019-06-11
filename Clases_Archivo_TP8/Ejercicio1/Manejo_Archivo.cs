using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio1
{
    public class Manejo_Archivo
    {
        public StreamWriter writer;
        public StreamReader reader;
        //List<Empleado> ListaEmpleados = new List<Empleado>(); //temporal

        public void leerArchivo(List<Empleado> ListaEmpleados)
        {
            reader = new StreamReader(@"Registro.csv");
            string[] ArregloCadena;
                 while (!reader.EndOfStream) //LEE HASTA EL FINAL
                 {
                     string aux = reader.ReadLine();
                     ArregloCadena = aux.Split(',');//GUARDA EN CADA POSICION DEL ARREGLO UNA PALABRA, TERMINA EN LA ,
                     if(ArregloCadena.Length>= 7)
                     {
                        ListaEmpleados.Add(new Empleado(ArregloCadena[0], ArregloCadena[1], Convert.ToDateTime(ArregloCadena[2]), Convert.ToDateTime(ArregloCadena[3]), Convert.ToDecimal(ArregloCadena[4]), (Cargo)Convert.ToInt32(ArregloCadena[5]), (EstadoCivil)Convert.ToInt32(ArregloCadena[6]), (Genero)Convert.ToInt32(ArregloCadena[7])));
                     }
                 }
                  try
                 {
                    // reader = new StreamReader(@"Registro.csv");
                     while (!reader.EndOfStream) 
                     {
                         string aux = reader.ReadLine();
                     }

                 }catch (Exception e)
                 {
                     Console.WriteLine("Excepción: " + e.Message);
                 }
                 finally
                 {
                     Console.WriteLine("Bloque final.");
                    
            }
            reader.Close();
        }
        public void escribirArchivo(List<Empleado> ListaEmpleados)
        {
            //writer = File.AppendText(@"Registro.csv");
            StreamWriter sw = new StreamWriter(@"Registro.csv", append: true);
            sw.WriteLine("......");
            /*
            foreach (Empleado empleado in ListaEmpleados)
            {
                writer.WriteLine(empleado.Nombre+","+empleado.Apellido + "," + empleado.FechaNacimiento + "," + empleado.FechaIngreso + "," + empleado.Sueldo + "," + empleado.Cargo + "," + empleado.EstadoCivil + "," + empleado.Genero);
            }
            writer.Close();
            */
            sw.Close();
        }

    }
}

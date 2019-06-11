using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Ejercicio1
{
    class Program
    {
        //Next(1.10) devuelve numero entre 1-9
        static Random aleatorio = new Random(); //Se instancia solo 1 vez
        static decimal SUELDOBASICO = 5000;
        static decimal SueldoTotal = 0;
     
        static void Main(string[] args)
        {
            Manejo_Archivo archivito = new Manejo_Archivo();
            DateTime Nacimiento;
            DateTime Ingreso;
            Cargo Cargo;
            EstadoCivil EstadoCivil;
            Genero Genero;
            decimal Sueldo;
            //CARGA EMPLEADOS
            List<Empleado> ListaEmpleados = new List<Empleado>();
            for (int i = 0; i < 5; i++)
            {
                    Nacimiento = NacimientoAleatorio();
                    Ingreso = IngresoAleatorio();
                    Cargo = CargoAleatorio();
                    EstadoCivil = EstadoCivilAleatorio();
                    Genero = GeneroAleatorio();
                    Sueldo = CalcularSalario(Nacimiento, Ingreso, Cargo, EstadoCivil, Genero);
                    ListaEmpleados.Add(new Empleado("Empleado:" + (i + 1).ToString(), " Apellido:" + (i + 1).ToString(), Nacimiento, Ingreso, Sueldo, Cargo, EstadoCivil, Genero));
            }
            //MUESTRA EMPLEADOS
            foreach (Empleado empleado in ListaEmpleados)
            {
                Console.WriteLine($"{empleado.Nombre} |{empleado.Apellido} | Nacimiento: {empleado.FechaNacimiento.ToString("dd/MM/yyyy")} | Ingreso: {empleado.FechaIngreso.ToString("dd/MM/yyyy")} | Cargo: {empleado.Cargo} | Estado Civil: {empleado.EstadoCivil} | Genero: {empleado.Genero} | Sueldo: {empleado.Sueldo}");
            }

            Console.WriteLine($"La lista tiene {ListaEmpleados.Count()} empleados");
            //SALARIO TOTAL
            foreach (Empleado empleado in ListaEmpleados)
            {
                SueldoTotal += empleado.Sueldo;
            }
            Console.WriteLine($"El sueldo total de todos los empleados es {SueldoTotal}");
            archivito.leerArchivo(ListaEmpleados);

            Console.WriteLine("La nueva lista de empleados es:");
                        foreach (Empleado empleado in ListaEmpleados)
            {
                Console.WriteLine($"{empleado.Nombre} |{empleado.Apellido} | Nacimiento: {empleado.FechaNacimiento.ToString("dd/MM/yyyy")} | Ingreso: {empleado.FechaIngreso.ToString("dd/MM/yyyy")} | Cargo: {empleado.Cargo} | Estado Civil: {empleado.EstadoCivil} | Genero: {empleado.Genero} | Sueldo: {empleado.Sueldo}");
            }
            archivito.escribirArchivo(ListaEmpleados);
            Console.ReadKey();
            

            }

            //METODOS
            static DateTime NacimientoAleatorio()
            {
                //CONSIDERACIONES: El empleado no puede tener mas de 65 años por la jubilacion
                return (new DateTime(aleatorio.Next(1955, 2002), aleatorio.Next(1, 13), aleatorio.Next(1, 29)));
            }

            static DateTime IngresoAleatorio()
            {
                //CONSIDERACIONES: El empleado no puede ser menor a 18 años y tener una fecha de ingreso menor a 1 año
                return (new DateTime(aleatorio.Next(1955, 2002), aleatorio.Next(1, 13), aleatorio.Next(1, 29)));
            }

            static Genero GeneroAleatorio()
            {
                Genero aux = Genero.Masculino;
                switch (aleatorio.Next(1, 3))
                {
                    case 1:
                        aux = Genero.Masculino;
                        break;
                    case 2:
                        aux = Genero.Femenino;
                        break;
                }
                return aux;
            }

            static Cargo CargoAleatorio()
            {
                Cargo aux = Cargo.Auxiliar;
                switch (aleatorio.Next(0, 5))
                {
                    case 0:
                        aux = Cargo.Auxiliar;
                        break;
                    case 1:
                        aux = Cargo.Administrativo;
                        break;
                    case 2:
                        aux = Cargo.Ingeniero;
                        break;
                    case 3:
                        aux = Cargo.Especialista;
                        break;
                    case 4:
                        aux = Cargo.Investigador;
                        break;
                }
                return aux;
            }

            static EstadoCivil EstadoCivilAleatorio()
            {
                EstadoCivil aux = EstadoCivil.Soltero;
                switch (aleatorio.Next(0, 2))
                {
                    case 0:
                        aux = EstadoCivil.Soltero;
                        break;
                    case 1:
                        aux = EstadoCivil.Casado;
                        break;
                }
                return aux;
            }

            static decimal CalcularSalario(DateTime Nacimiento, DateTime Ingreso, Cargo cargo, EstadoCivil EstadoCivil, Genero Genero)
            {
            //int SUELDOBASICO = 5000;
            decimal adicional = 0;
            TimeSpan aux1 = DateTime.Now.Subtract(Nacimiento);
            int edad = aux1.Days / 365;
            TimeSpan aux2 = DateTime.Now.Subtract(Ingreso);
            int antiguedad = aux2.Days / 365;

            if (antiguedad <= 20)
            {
                adicional = SUELDOBASICO * ((decimal)0.02) * antiguedad;
            }
            else
            {
                adicional = SUELDOBASICO * (decimal)0.45;
            }
            if ((cargo == Cargo.Administrativo) | (cargo == Cargo.Especialista))
            {
                adicional *= (decimal)1.5;
            }
            if (EstadoCivil == EstadoCivil.Casado)
            {
                adicional = adicional + 5000;
            }
            return adicional + SUELDOBASICO;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{

    public enum Cargo { Auxiliar = 0, Administrativo, Ingeniero, Especialista, Investigador };
    public enum EstadoCivil { Soltero, Casado };
    public enum Genero { Masculino, Femenino };

    class Empleado
    {
            public string Nombre;
            public string Apellido;
            public DateTime FechaNacimiento;
            public DateTime FechaIngreso;
            public Cargo Cargo;
            public EstadoCivil EstadoCivil;
            public Genero Genero;
            public double Sueldo;

            //CONSTRUCTOR
            public Empleado(string _nombre, string _apellido, DateTime _fechaNacimiento, DateTime _fechaIngreso, double _sueldo, Cargo _cargo, EstadoCivil _estadoCivil, Genero _genero)
            {
                this.Nombre = _nombre;
                this.Apellido = _apellido;
                this.FechaNacimiento = _fechaNacimiento;
                this.FechaIngreso = _fechaIngreso;
                this.Cargo = _cargo;
                this.EstadoCivil = _estadoCivil;
                this.Genero = _genero;
                this.Sueldo = _sueldo;
            }
    }
}

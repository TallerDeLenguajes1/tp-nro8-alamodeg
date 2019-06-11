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

    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;
        private Cargo cargo;
        private EstadoCivil estadoCivil;
        private Genero genero;
        private decimal sueldo;

        public string Nombre
        {
            get {return nombre;}
            set {nombre = value;}
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }

            set
            {
                fechaIngreso = value;
            }
        }

        public Cargo Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public EstadoCivil EstadoCivil
        {
            get
            {
                return estadoCivil;
            }

            set
            {
                estadoCivil = value;
            }
        }

        public Genero Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public decimal Sueldo
        {
            get
            {
                return sueldo;
            }

            set
            {
                sueldo = value;
            }
        }

        //CONSTRUCTOR
        public Empleado(string _nombre, string _apellido, DateTime _fechaNacimiento, DateTime _fechaIngreso, decimal _sueldo, Cargo _cargo, EstadoCivil _estadoCivil, Genero _genero)
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

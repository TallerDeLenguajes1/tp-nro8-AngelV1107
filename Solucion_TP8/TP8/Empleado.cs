using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{

    public enum Cargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    class Empleado
    {
        string nombre;
        string apellido;
        string estadoCiv;
        string genero;
        float sueldoBasico;
        int cantHijos;
        DateTime fechaNac;
        DateTime fechaIng;
        Cargo cargo_actual;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
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

        public string EstadoCiv
        {
            get
            {
                return estadoCiv;
            }

            set
            {
                estadoCiv = value;
            }
        }

        public string Genero
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

        public float SueldoBasico
        {
            get
            {
                return sueldoBasico;
            }

            set
            {
                sueldoBasico = value;
            }
        }

        public int CantHijos
        {
            get
            {
                return cantHijos;
            }

            set
            {
                cantHijos = value;
            }
        }

        public DateTime FechaNac
        {
            get
            {
                return fechaNac;
            }

            set
            {
                fechaNac = value;
            }
        }

        public DateTime FechaIng
        {
            get
            {
                return fechaIng;
            }

            set
            {
                fechaIng = value;
            }
        }

        public Cargo Cargo_actual
        {
            get
            {
                return cargo_actual;
            }

            set
            {
                cargo_actual = value;
            }
        }




        public void Mostrar_Datos()
        {
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Apellido: {0}", Apellido);
            Console.WriteLine("Estado civil: {0}", EstadoCiv);
            Console.WriteLine("Genero: {0}", Genero);
            Console.WriteLine("Sueldo básico: {0}", SueldoBasico);
            Console.WriteLine("Cantidad de hijos: {0}", CantHijos);
            Console.WriteLine("Fecha de nacimiento: {0}", FechaNac.ToShortDateString());
            Console.WriteLine("Fecha de ingreso: {0}", FechaIng.ToShortDateString());
            Console.WriteLine("Cargo: {0}", Cargo_actual);
        }

        public int Antiguedad()
        {
            DateTime fecha = new DateTime((DateTime.Today - FechaIng).Ticks);
            return fecha.Year;
        }

        public int Edad()
        {
            DateTime fecha = new DateTime((DateTime.Today - FechaNac).Ticks);
            return fecha.Year;
        }

        public int AniosRestantesJubilacion()
        {
            //Devuelve la cantidad de años restantes para la jubilación del empleado
            if (Genero == "Hombre")
            {
                return 65 - this.Edad();
            }
            else
            {
                return 60 - this.Edad();
            }
        }

        public float Salario()
        {
            float adicional = 0;

            if (this.Antiguedad() >= 20)
            {
                //Si la antiguedad es mayor a 20 años 
                adicional += SueldoBasico * (float)0.25;
            }
            else
            {
                adicional += SueldoBasico * this.Antiguedad() * (float)0.02;
            }

            if (Cargo_actual == Cargo.Ingeniero || Cargo_actual == Cargo.Especialista)
            {
                adicional *= (float)1.5;
            }

            if ((estadoCiv.ToLower() == "casado") && (cantHijos > 2))
            {
                adicional += (float)5000.0;
            }

            return sueldoBasico + adicional;
        }



    }
}

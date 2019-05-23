using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = Crear_empleado();

            emp.Mostrar_Datos();

            Console.WriteLine("edad: ");
            Console.WriteLine(emp.Edad());
            Console.WriteLine("antiguead: ");
            Console.WriteLine(emp.Antiguedad());
            Console.WriteLine("salario: ");
            Console.WriteLine(emp.Salario());

            Console.ReadKey();
        }

        public static Empleado Crear_empleado()
        {
            Empleado emp = new Empleado();

            string[] nombresMasc = new string[5] { "Jorge", "Emanuel", "Pepe", "Santiago", "Hugo" };
            string[] nombresFeme = new string[5] { "Sofia", "Maria", "Amelia", "Liliana", "Marta" };
            string[] apellidos = new string[5] { "Armando", "Casas", "Fuertes", " Guerra", "Frías" };


            string genero;
            string nombre;
            string apellido;
            string estadoCiv;
            int sueldoBasico;
            int cantHijos;

            Random rand = new Random();

            if (rand.Next(0, 2) == 0)
            {
                genero = "Masculino";
                nombre = nombresMasc[rand.Next(0, 5)];
            }
            else
            {
                genero = "Femenino";
                nombre = nombresFeme[rand.Next(0, 5)];
            }

            apellido = apellidos[rand.Next(1, 5)];

            if (rand.Next(0, 2) == 1)
            {
                estadoCiv = "Casado";
            }
            else
            {
                estadoCiv = "Soltero";
            }

            sueldoBasico = rand.Next(2000, 20001);

            cantHijos = rand.Next(0, 4);

            int anio = rand.Next(1, 50);
            int mes = rand.Next(1, 13);
            int dia = rand.Next(1, 31);

            DateTime fecha_nac = new DateTime(1950, 1, 1);

            fecha_nac.AddYears(anio);
            fecha_nac.AddMonths(mes);
            fecha_nac.AddDays(dia);






            return emp;
        }
    }
}

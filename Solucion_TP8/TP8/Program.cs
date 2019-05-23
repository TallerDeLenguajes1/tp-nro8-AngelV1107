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
            Empleado emp = new Empleado();

            emp.Cargo_actual = Cargo.Ingeniero;

            DateTime fecha_naci = new DateTime(1997, 6, 2);
            DateTime fecha_ingr = new DateTime(2010, 6, 2);


            emp.FechaNac = fecha_naci;
            emp.FechaIng = fecha_ingr;


            emp.Mostrar_Datos();

            Console.WriteLine("edad: ");
            Console.WriteLine(emp.Edad());


            Console.ReadKey();
        }
    }
}

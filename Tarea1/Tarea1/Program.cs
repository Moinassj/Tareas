using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double total;
            string linea;
            ClassEmpleado empleado = new ClassEmpleado();
            //Ingresa nombre
            Console.WriteLine("Ingresa nombre: ");
            empleado.Nombre = Console.ReadLine();
            //Ingresa edad
            Console.WriteLine("Ingresa Edad: ");
            linea = Console.ReadLine();
            empleado.Edad = int.Parse(linea);
            //Ingresa salario
            Console.WriteLine("Ingresa Salario: ");
            linea = Console.ReadLine();
            empleado.Salario = double.Parse(linea);

            if (empleado.Salario >= 10000)
            {
                empleado.IVA = 0.20 * empleado.Salario;
                total = empleado.Salario - empleado.IVA;
                Console.WriteLine("tu salario es de : ");
                Console.WriteLine(total);
            }
            else
            {
                empleado.IVA = 0.16 * empleado.Salario;
                total = empleado.Salario - empleado.IVA;
                Console.WriteLine("tu salario es de : {1}", total);
                Console.WriteLine(total);
            }

            Console.ReadKey();
        }
    }
}

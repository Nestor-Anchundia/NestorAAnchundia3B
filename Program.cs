using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnchundiaNestorA3B.clases;


namespace AnchundiaNestorA3B
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente menu = new cliente();
            gasolina gasolina = new gasolina();
            float subtotal, iva, total;
           
            Console.WriteLine("Ingrese Apellido");
            menu.Apellidos = (Console.ReadLine());
            Console.WriteLine("Ingrese Nombres");
            menu.Nombre = (Console.ReadLine());
            Console.WriteLine("Ingrese Cedula de Identidad");
            menu.Cedula = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Direccion ");
            menu.Direccion = (Console.ReadLine());
            Console.WriteLine("Ingrese gasolina que desea");
            gasolina.Tipo = (Console.ReadLine());
            Console.WriteLine("Cuantos Galones desea");
            gasolina.Galones = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos precio");
            gasolina.Precio = float.Parse(Console.ReadLine());
            subtotal = gasolina.Galones * gasolina.Precio;
            iva= subtotal*0.12f;
            total = subtotal + iva;
            Console.WriteLine("***************************************************");
            Console.WriteLine("+++++++              EMPRESA                 ++++++");
            Console.WriteLine("+++++++       Tercer Nivel Cía. Ltda         ++++++");
            Console.WriteLine("***************************************************");
            Console.WriteLine(">>>>>>>>>>>>         FACTURA           <<<<<<<<<<<<");
            Console.WriteLine();
            Console.WriteLine("INFORMACION DE CLIENTE");
            Console.WriteLine("Nombre:"+ menu.Apellidos + menu.Nombre);
            Console.WriteLine("Cedula de identidad"+ menu.Cedula);
            Console.WriteLine("Direccion"+ menu.Direccion);
            Console.WriteLine("===================================================");
            Console.WriteLine("INFORMACION DE GASOLINA");
            Console.WriteLine("=="+ "Tipo de Gasolina:          "+gasolina.Tipo     );
            Console.WriteLine("=="+ "Valor por galon:           "+gasolina.Precio   );
            Console.WriteLine("=="+ "Cantidad de Gasolina:      "+gasolina.Galones  );
            Console.WriteLine(                       "Subtutal       "    +subtotal);
            Console.WriteLine(                       "Iva            "         +iva);
            Console.WriteLine(                       "Total          "       +total);
            Console.ReadLine();
        }
    }
}

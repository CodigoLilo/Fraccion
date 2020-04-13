using System;
using System.Collections.Generic;
using System.Text;

namespace Pinche_Josu
{
    class Mani
    {
        static void Main(string[] args)
        {
			int sw;
			Console.WriteLine("Elija una opcion\n" +
			"\n1. Crear dos objetos fraccion" +
			"\n2. Suma" +
			"\n3. Resta" +
			"\n4. Producto" +
			"\n5. Division" +
			"\n6. Simplificar fraccion\n" +
			"\n7. Me la Pelas Josu :v");
			Fraccion f3;
			Fraccion f1 = new Fraccion(2, 4);
			Fraccion f2 = new Fraccion(5, 8);
			do
			{
				sw = Int32.Parse(Console.ReadLine());
				switch (sw)
				{
					case 1:
						Console.WriteLine("Fraccion 1");
						f1.lee();
						f1.mostrar();
						Console.WriteLine("Fraccion 2 ");
						f2.lee();
						f2.mostrar();
						break;
					case 2:
						Console.WriteLine("opcion suma");

						f3 = f1 + f2;
						f3.mostrar();
						Console.WriteLine("Me la pelas Josu");
						break;
					case 3:
						Console.WriteLine("opcion resta");
						f3 = f1 - f2;
						f3.mostrar();
						Console.WriteLine("Me la pelas Josu");
						break;
					case 4:
						Console.WriteLine("opcion producto");
						f3 = f1 * f2;
						f3.mostrar();
						Console.WriteLine("Me la pelas Josu");
						break;
					case 5:
						Console.WriteLine("opcion division");
						f3 = f1 / f2;
						f3.mostrar();
						Console.WriteLine("Me la pelas Josu");
						break;
					case 6:
						Console.WriteLine("fraccion simplificada....");
						Console.WriteLine("Me la pelas Josu");
						break;
					default:
						sw = 7;//tienes solo 6 casos por eso 7 :v 
						break;
				}
			} while (sw != 7);
			Console.ReadKey();
		}
    }
}

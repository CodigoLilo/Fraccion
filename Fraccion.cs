using System;
using System.Collections.Generic;
using System.Text;

namespace Pinche_Josu
{
    class Fraccion
    {
		private int num;
		private int den;

		public int Num
		{
			get { return den; }
			set { num = value; }
		}


		public Fraccion(int num, int den)
		{
			this.num = num;
			this.den = den;
		}
		public void mostrar()
		{
			Console.WriteLine("\nObjeto Fraccion");
			Console.WriteLine(num + "/" + den);
		}
		public void lee()
		{
			num = Int32.Parse(Console.ReadLine());
			den = Int32.Parse(Console.ReadLine());

		}
		public static Fraccion operator +(Fraccion p, Fraccion q)
		{
			int nume = (p.num * q.den) + (p.den * q.num);
			int deno = (p.den * q.den);
			return (new Fraccion(nume, deno));
		}
		public static Fraccion operator -(Fraccion p, Fraccion q)
		{
			int nume = (p.num * q.den) - (p.den * q.num);
			int deno = p.den * q.den;
			return (new Fraccion(nume, deno));
		}
		public static Fraccion operator *(Fraccion p, Fraccion q)
		{
			int nume = p.num * q.num;
			int deno = p.den * q.den;
			return (new Fraccion(nume, deno));
		}
		public static Fraccion operator /(Fraccion p, Fraccion q)
		{
			int nume = p.num * q.den;
			int deno = p.den * q.num;
			return (new Fraccion(nume, deno));
		}

	}
}

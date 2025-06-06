namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monto, e1, e2, e3, e4, suma;
            double porc1, porc2, porc3, porc4;
            double m1, m2, m3, m4;

            Console.WriteLine("Ingrese el monto a repartir");
            monto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las edades de las 4 niñas");
            e1 = int.Parse(Console.ReadLine());
            e2 = int.Parse(Console.ReadLine());
            e3 = int.Parse(Console.ReadLine());
            e4 = int.Parse(Console.ReadLine());

            suma = e1 + e2 + e3 + e4;

            porc1 = 1.0 * e1 / suma * 100;
            porc2 = 1.0 * e2 / suma * 100;
            porc3 = 1.0 * e3 / suma * 100;
            porc4 = 1.0 * e4 / suma * 100;

            m1 = porc1 * monto / 100;
            m2 = porc2 * monto / 100;
            m3 = porc3 * monto / 100;
            m4 = porc4 * monto / 100;

            Console.WriteLine("El monto y porcentaje de la niña 1 es: " + m1 + " " + "%" + porc1);
            Console.WriteLine("El monto y porcentaje de la niña 2 es: " + m2 + " " + "%" + porc2);
            Console.WriteLine("El monto y porcentaje de la niña 3 es: " + m3 + " " + "%" + porc3);
            Console.WriteLine("El monto y porcentaje de la niña 4 es: " + m4 + " " + "%" + porc4);
        }
    }
}

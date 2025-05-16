


class Program
{
    static Random azar = new Random();
    public static void Main(string[] args)
    {
        #region declaracion de variables
        int posicion1, posicion2;
        string nombre1, nombre2;
        int pie1, cabecera1, pie2, cabecera2, cola, cabeza;
        bool sigue = true;
        int dado;
        #endregion

        #region Iniciar posicion jugador 1 y 2
        posicion1 = 1;
        posicion2 = 1;
        #endregion

        #region solicitar nombre jugador 1, y 2
        Console.WriteLine("Nombre jugador 1");
        nombre1 = Console.ReadLine();
        Console.WriteLine("Nombre jugador 2");
        nombre2 = Console.ReadLine();
        #endregion

        #region
        pie1 = azar.Next(1, 101);
        cabecera1 = azar.Next(pie1, 101);

        pie2 = azar.Next(1, 101);
        cabecera2 = azar.Next(pie2, 101);
        #endregion

        #region

        cola = azar.Next(1, 101);
        cabeza = azar.Next(cola, 101);
        #endregion


        #region iterar jugadas
        do
        {
            #region determinar avance jugador 1
            dado = azar.Next(1, 7);
            posicion1 += dado;

            if (cabeza == posicion1) posicion1 = cola;

            if (pie1 == posicion1) posicion1 = cabecera1;

            if (pie2 == posicion1) posicion1 = cabecera2;
            #endregion

            #region determinar avance jugador 2
            dado = azar.Next(1, 7);
            posicion1 += dado;

            if (cabeza == posicion2) posicion2 = cola;

            if (pie1 == posicion2) posicion2 = cabecera1;

            if (pie2 == posicion2) posicion2 = cabecera2;
            #endregion

            sigue = posicion1 >= 100 || posicion2 >= 100;

        } while (sigue);
        #endregion

        if (posicion1 >= 100 ^ posicion2 >= 100)
        {
            if (posicion1 >= 100) Console.WriteLine("Ganador: " + nombre1);
            else Console.WriteLine($"Ganador: {nombre2}");
        }
        else
        {
            Console.WriteLine("Ganador: {0}", nombre2);
        }
    }
}

using System;
using System.Threading;

namespace JuegoDeDragones
{
    class Program
    {
        static void Main(string[] args)
        {
            string jugarDeNuevo = "sí";

            while (jugarDeNuevo == "sí" || jugarDeNuevo == "si" || jugarDeNuevo == "s")
            {
                introduccion();
                int numeroCueva = elegirCueva();
                explorarCueva(numeroCueva);
                Console.WriteLine("¿Quieres jugar de nuevo? (sí / no)");
                jugarDeNuevo = Console.ReadLine();
            }
            
        }
        
        static void introduccion()
        {
            Console.WriteLine("Estás en una tierra llena de dragones. Frente a tí ");
            Console.WriteLine("hay dos cuevas. En una de ellas, el dragón es generoso y ");
            Console.WriteLine("amigable y compartirá su tesoro contigo. El otro dragón ");
            Console.WriteLine("es codicioso y está hambriento, y te devorará inmediatamente. ");
            Console.WriteLine();
        }

        static int elegirCueva()
        {
            int cueva = 0;

            while (cueva != 1 && cueva != 2)
            {
                Console.WriteLine("¿A qué cueva quieres entrar? (1 o 2)");
                cueva = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            return cueva;
        }

        static void explorarCueva(int cuevaElegida)
        {
            Console.WriteLine("Te aproximas a la cueva...");
            Thread.Sleep(2000);
            Console.WriteLine("Es oscura y espeluznante...");
            Thread.Sleep(2000);
            Console.WriteLine("¡Un gran dragón aparece frente a tí! Abre su boca y... ");
            Thread.Sleep(5000);
            Console.WriteLine();

            Random random = new Random();
            int cuevaAmigable = random.Next(1, 2);

            if (cuevaAmigable == cuevaElegida) Console.WriteLine("¡Te regala su tesoro!");
            else Console.WriteLine("¡Te come de un bocado!");
            Console.WriteLine();
        }
    }
}

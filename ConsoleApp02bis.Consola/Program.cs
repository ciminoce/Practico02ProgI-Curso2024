namespace ConsoleApp02bis.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número:");
            if (!int.TryParse(Console.ReadLine(), out int numero1))
            {
                Console.WriteLine("Número 1 mal ingresado");
                return;
            }
            Console.Write("Ingrese el segundo número:");
            if (!int.TryParse(Console.ReadLine(), out int numero2))
            {
                Console.WriteLine("Número 2 mal ingresado");
                return;
            }
            int mayor = Math.Max(numero1, numero2);//Devuelve el mayor
            int menor = Math.Min(numero1, numero2);//Devuelve el menor
            if (mayor != menor)
            {
                Console.WriteLine(menor);
                Console.WriteLine(mayor);

            }
            else
            {
                Console.WriteLine($"Ambos números son iguales a {numero1}");
            }
        }
    }
}

namespace ConsoleApp03A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número entero:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número entero (diferente del primero):");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Verificamos si los números son iguales
            if (num1 == num2)
            {
                Console.WriteLine("¡Error! Los números ingresados son iguales. Deben ser diferentes.");
            }
            else
            {
                // Determinamos el mayor y el menor
                int mayor = Math.Max(num1, num2);
                int menor = Math.Min(num1, num2);

                // Mostramos los resultados
                Console.WriteLine($"El mayor número es: {mayor}");
                Console.WriteLine($"El menor número es: {menor}");
            }
        }
    }
}

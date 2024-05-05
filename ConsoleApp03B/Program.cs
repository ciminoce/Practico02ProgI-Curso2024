namespace ConsoleApp03B
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
                Console.WriteLine("Los números ingresados son iguales.");
            }
            else
            {
                // Determinamos el mayor y el menor manualmente
                int mayor, menor;

                if (num1 > num2)
                {
                    mayor = num1;
                    menor = num2;
                }
                else
                {
                    mayor = num2;
                    menor = num1;
                }

                // Mostramos los resultados
                Console.WriteLine($"El mayor número es: {mayor}");
                Console.WriteLine($"El menor número es: {menor}");
            }
        }
    }
}

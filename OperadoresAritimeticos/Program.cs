

namespace OperadoresAritimeticos
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("BEM VINDO A CALCULADORA CSHARP");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Qual operacao deseja realizar? (1 - Soma, 2 - Subtracao, 3 - Multiplicacao, 4 - Divisao) ");

            int operacao = int.Parse(Console.ReadLine());

            if (operacao == 1)
            {
                Console.Write("Digite o primeiro numero: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                double num2 = double.Parse(Console.ReadLine());
                double resultado = num1 + num2;
                Console.WriteLine($"O resultado da soma é: {resultado}");
            }
            else if (operacao == 2)
            {
                Console.Write("Digite o primeiro numero: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                double num2 = double.Parse(Console.ReadLine());
                double resultado = num1 - num2;
                Console.WriteLine($"O resultado da subtracao é: {resultado}");
            }
            else if (operacao == 3)
            {
                Console.Write("Digite o primeiro numero: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                double num2 = double.Parse(Console.ReadLine());
                double resultado = num1 * num2;
                Console.WriteLine($"O resultado da multiplicacao é: {resultado}");
            }
            else if (operacao == 4)
            {
                Console.Write("Digite o primeiro numero: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                double num2 = double.Parse(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: Divisao por zero nao e permitida.");
                }
                else
                {
                    double resultado = num1 / num2;
                    Console.WriteLine($"O resultado da divisao é: {resultado}");
                }
            }
            else
            {
                Console.WriteLine("Operacao invalida. Por favor, escolha uma operacao entre 1 e 4.");

                Console.Write("Deseja tentar novamente? (S/N) ");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() == "S")
                {
                    Main();
                }
            }
    }
}   





















            }
    

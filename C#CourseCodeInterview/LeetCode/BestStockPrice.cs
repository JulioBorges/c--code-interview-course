using C_CourseCodeInterview.Base;

namespace C_CourseCodeInterview.LeetCode
{
    public class BestStockPrice : IExecution
    {
        public string Name => "121. Best Time to Buy and Sell Stock";

        public string Description => @"You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.";

        public void Run()
        {
            TestCase([7, 1, 5, 3, 6, 4]);
            TestCase([7, 6, 4, 3, 1]);
            TestCase([2, 4, 1]);
        }

        public void TestCase(int[] prices)
        {
            Console.WriteLine("---");
            Console.WriteLine($"The best profit in [{string.Join(", ", prices)}] is: {MaxProfit(prices)}");
            Console.WriteLine();
        }

        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue; // Inicializa o menor preço com o maior valor possível para garantir que qualquer preço será menor.
            int maxProfit = 0; // Inicializa o lucro máximo como 0, pois ainda não foi calculado nenhum lucro.

            for (int i = 0; i < prices.Length; i++) // Itera por todos os preços no array.
            {
                if (prices[i] < minPrice) // Verifica se o preço atual é menor que o menor preço registrado.
                {
                    minPrice = prices[i]; // Atualiza o menor preço com o preço atual.
                }
                else // Caso contrário, significa que o preço atual é maior ou igual ao menor preço.
                {
                    int profit = prices[i] - minPrice; // Calcula o lucro ao vender no preço atual após comprar no menor preço.

                    if (profit > 0 && profit > maxProfit) // Verifica se o lucro é positivo e maior que o lucro máximo registrado.
                    {
                        maxProfit = profit; // Atualiza o lucro máximo com o lucro atual.
                    }
                }
            }

            return maxProfit; // Retorna o maior lucro possível encontrado.
        }
    }
}

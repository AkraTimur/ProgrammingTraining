﻿namespace LinqApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"part 2
");
            var sandwiches = new[] { "ham and cheese", "salami with mayo",
                                       "turkey and swiss", "chicken cutlet" };
            var sandwichesOnRye =
                from sandwich in sandwiches
                select $"{sandwich} on rye"; // Секцию «select» можно рассматривать как механизм внесения одних и тех же изменений в каждый эвлкеомнеенцт д опбоасвллеядеотвасят «елoьnн rоyстe»и. — в данном случае в конец добавляется "on rye"
            foreach (var sandwich in sandwichesOnRye)
            {
                Console.WriteLine(sandwich);
            }
            Console.WriteLine(@"part 2
");
            var random = new Random();
            var numbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
            {
                numbers.Add(random.Next(100));
            }
            Console.WriteLine($@"Stats for these {numbers.Count()} numbers:
The first 5 numbers: {String.Join(",", numbers.Take(5))}
The last 5 numbers: {String.Join(",", numbers.TakeLast(5))}
The first is {numbers.First()} and the last is {numbers.Last()}
The smallest is {numbers.Min()}, and the biggest is {numbers.Max()}
The sum is {numbers.Sum()}
The average is {numbers.Average():F2}");
        }
    }
}
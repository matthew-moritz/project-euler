
namespace ProjectEuler.Problems
{
    class Problem001 : IProblem
    {
        public string Title => "Multiples of 3 and 5";

        public int Number => 1;

        public string Solve()
        {
            var sum = 0;

            for (var i = 1; i < 1000; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;

            return $"{sum}";
        }
    }
}

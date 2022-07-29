namespace HelloWorld
{
    class Program
    {
        public static void Main()
        {
            Func<int, int> func = (x) => x * x;

            var list = new List<int>();
            list.Add(1);
            list.Add(12);

            list = list.FindAll((node) => node % 2 == 0); 

            foreach (var item in list)
            {
                Console.WriteLine(fact(item));
            }
        }

        static int fact(int number)
        {
            if (number == 1)
                return 1;
            return fact(number - 1) * number;
        }
    }
}
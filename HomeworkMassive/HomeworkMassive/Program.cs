namespace HomeworkMassive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write(" Massiv uzunligini kiriting: ");
            string raqamm = Console.ReadLine();
            bool isnumber1 = int.TryParse(raqamm, out int uzun);

            int yigindi = 0;
            int kopaytma = 1;

            int[] arr = new int[uzun];

            if (isnumber1)
            {
                for (int i = 0; i < uzun; i++)
                {
                    arr[i] = random.Next(1, 9);
                    Console.Write(" " + arr[i]);
                    yigindi += arr[i];
                    kopaytma *= arr[i];
                }
                Console.WriteLine();
                Console.WriteLine(" Yig'indisi: " + yigindi);
                Console.WriteLine(" Ko'paymasi: " + kopaytma);
            }
            else
            {
                Console.WriteLine(" Faqat butun son kirita olasiz !!!");
            }
            Main(args);
        }
    }
}
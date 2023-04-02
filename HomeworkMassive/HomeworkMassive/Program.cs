namespace HomeworkMassive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write(" Massiv uzunligini kiriting: ");
            string raqamm = Console.ReadLine();
            bool isnumber1 = int.TryParse(raqamm, out int son1);
            int[] arr = new int[son1];
            Console.Write(" Istalgan raqam kiriting ");
            string raqam = Console.ReadLine();
            bool isnumber = int.TryParse(raqam, out int son2);
            if (isnumber && isnumber1)
            {
                for (int i = 0; i < son1; i++)
                {
                    arr[i] = random.Next(10,100);
                    if (arr[i] % son2 == 0)
                    {
                        Console.Write($"{arr[i]}{" "}");
                    }
                }
            }
            else
            {
                Console.WriteLine(" Ikkalasiga ham faqat butun son kirita olasz !!!");
            }
            Main(args);
        }
    }
}
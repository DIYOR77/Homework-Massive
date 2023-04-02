namespace HomeworkMassive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write(" Massiv uzunligini kiriting: ");
            string uz = Console.ReadLine();
            bool isnumber = int.TryParse(uz, out int son);
            int[] arr = new int[son];
            int sanoq = 0;
            if (isnumber)
            {

                for (int i = 0; i < arr.Length + 5; i++)
                {
                    arr[i] = random.Next(1, 99);

                    if (arr[i] % 2 == 1)
                    {
                        sanoq++;
                        Console.Write(" " + arr[i]);
                        if (sanoq == son) break;
                    }
                    else i = 0;

                }
            }
            else
            {
                Console.WriteLine(" Faqat butun son kirita olas")
            }
            Main(args);
        }
    }
}
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

            Console.Write(" Nechanchi  elementni almashtirmoqchisiz: ");
            string almash1 = Console.ReadLine();
            bool isnumber2 = int.TryParse(almash1, out int son1);

            Console.Write(" Nechanchi  elementda  bilan: ");
            string almash2 = Console.ReadLine();
            bool isnumber3 = int.TryParse(almash2, out int son2);

            int[] arr = new int[uzun];

            if (isnumber1 && isnumber2 && isnumber3 && 0 <= son1 && son1 <= son2 && son2 <= uzun)
            {
                for (int i = 0; i < uzun; i++)
                {
                    arr[i] = random.Next(10, 50);
                    Console.Write(" " + arr[i]);
                }
                Console.WriteLine();
                int saqla = arr[son1];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j == son1)
                    {
                        arr[j] = arr[son2];
                    }
                    if (j == son2)
                    {
                        arr[j] = saqla;
                    }
                    Console.Write(" " + arr[j]);
                }
            }
            else
            {
                Console.WriteLine(" Faqat butunsonlar kirita olasiz yoki kiritgan sonlar o'sish tartibida emas !!!");
            }
            Console.WriteLine();
            Main(args);

        }
    }
}
namespace HomeworkMassive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Massiv uzunligini kiriting: ");
            string raqamm = Console.ReadLine();
            bool isnumber1 = int.TryParse(raqamm, out int uzun);

            int[] arr = new int[uzun];
            int yigindi = 0;

            if (isnumber1)
            {
                for (int i = 0; i < uzun; i++)
                {
                    Console.Write(i + ": ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] % 2 == 0)
                    {
                        yigindi += arr[j];
                        if (uzun - 1 == j)
                        {
                            yigindi -= (arr[0] + arr[arr.Length - 1]);
                        }
                    }
                    else break;
                }
                Console.WriteLine(" Yig'indisi: " + yigindi);
            }
            else
            {
                Console.WriteLine(" Faqat butun son kirita olasz !!!");
            };
            Main(args);

        }
    }
}
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

            Console.Write(" Qaysi sonni izlayapsiz: ");
            string izla = Console.ReadLine();
            bool isnumber2 = int.TryParse(izla, out int son1);

            int[] arr = new int[uzun];

            if (isnumber1 || isnumber2)
            {
                for (int i = 0; i < uzun; i++)
                {
                    arr[i] = random.Next(1, 99);
                    Console.Write(" " + arr[i]);
                }
                Console.WriteLine();
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == son1)
                    {
                        Console.Write(" Siz izlagan son massivda mavjud: " + j + " shu indexda turibdi.");
                    }
                    else
                    {
                        Console.WriteLine(" Siz izlagan son mavjud emas. " + son1 + " Hohlasangiz yuqorini tekshirib kuring !");
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine(" Faqat butun sonlar kirita olasiz !!!");
            }
            Main(args);
        }
    }
}
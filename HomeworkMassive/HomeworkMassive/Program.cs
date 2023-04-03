namespace HomeworkMassive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write(" Massiv uzunligini kiriting: ");
            string son=Console.ReadLine();
            bool isnumber=int.TryParse(son, out int number);
            int[]arr=new int[number];
            if (isnumber)
            {
                for(int i=0; i < number; i++)
                {
                    arr[i]=random.Next(1,99);
                    Console.Write(" "+arr[i]);
                }
                Console.WriteLine();
                Array.Sort(arr);
                for(int i=0; i < number; i++)
                {
                    Console.Write(" " + arr[i]);
                }
            }
            else
            {
                Console.WriteLine(" Faqat butun son kirita olasiz: ");
            }
            
        }
    }
}
namespace JustLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            for(int i  = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach(int x in arr) { Console.Write($"{x} "); }
            Console.ReadKey();
        }
    }
}

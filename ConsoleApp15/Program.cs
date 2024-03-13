internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Напишите номер задачи 1 до 3 ");
            switch(Console.ReadLine())
            {
                
                case "1":
                    SedOne();
                    break;
                case "2":
                    SedTwo();  
                    break;
                case "3":
                    SedThri();
                break;
                default:
                    break;

            }
        }
    }
    public static void SedThri()
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };
       
        PrintReverse(array, array.Length - 1);
        Console.WriteLine();
    }
    static void PrintReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            PrintReverse(arr, index - 1);
        }
    }
    public static void SedTwo()
    {
        int m = 2;
        int n = 3;
        int result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        else if (m > 0 && n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));
        else
            return -1; // В случае некорректных входных данных
    }
    public static void SedOne()
    {
        int M = 1;
        int N = 5;
        
        PrintNumbersInRange(M, N);
        Console.WriteLine();
    }
    static void PrintNumbersInRange(int start, int end)
    {
        if (start <= end)
        {
            Console.Write($"{start}");
            if (start < end)
            {
                Console.Write(", ");
            }
            PrintNumbersInRange(start + 1, end);
        }
    }
}
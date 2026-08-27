class so
{
    static void IsPrime(int n)
    {
        if (n < 2)
        {
            Console.WriteLine($"{n} không phải là số nguyên tố");
            return;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine($"{n} không phải là số nguyên tố");
                return;
            }
        }
        Console.WriteLine($"{n} là số nguyên tố");
    }
    static void IsPerfectNumber(int n)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        if (sum == n)
        {
            Console.WriteLine($"{n} là số hoàn hảo");
        }
        else
        {
            Console.WriteLine($"{n} không phải là số hoàn hảo");
        }
    }
    static void Fibonacci(int n)
    {
        int a = 0, b = 1, c;
        Console.Write($"Dãy Fibonacci đến số {n}: ");
        while (a <= n)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
    public static void Run() // **Main** neu chay file rieng le
    {
        Console.WriteLine("Nhập một số nguyên:");
        int n = Convert.ToInt32(Console.ReadLine());
        IsPrime(n);
        IsPerfectNumber(n);
        Fibonacci(n);
    }

}
// Note : Vi dang su dung class cho menu nen la nhieu Main nen complier se bao loi , nen minh se de tam la run -> neu chay file rieng le thi la doi la Main
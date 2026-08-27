class pt2
{
    static void PhuongTrinh(double a, double b, double c)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phuong trình có vô số nghiệm");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
            }
            else
            {

                Console.WriteLine($"Phương trình có nghiệm duy nhất: x = {(-c / b):F2}");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"Phương trình có nghiệm kép: x = {(-b / (2 * a)):F2}");
            }
            else
            {
                Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {(-b + Math.Sqrt(delta)) / (2 * a):F2}, x2 = {(-b - Math.Sqrt(delta)) / (2 * a):F2}");
            }
        }
    }
    public static void Run()// **Main** neu chay file rieng le
    {
        Console.WriteLine("Nhập số a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập số b:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập số c:");
        double c = Convert.ToDouble(Console.ReadLine());
        PhuongTrinh(a, b, c);
    }
}
// Note : Vi dang su dung class cho menu nen la nhieu Main nen complier se bao loi , nen minh se de tam la run -> neu chay file rieng le thi la doi la Main
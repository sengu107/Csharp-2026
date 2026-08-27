class caculator
{
    static double cong(double a, double b)
    {
        return a + b;
    }

    static double tru(double a, double b)
    {
        return a - b;
    }

    static double nhan(double a, double b)
    {
        return a * b;
    }

    static double chia(double a, double b)
    {
        if (b is 0)
            throw new Exception("KHONG THE CHIA CHO 0");

        return a / b;
    }

    static double chialaydu(double a, double b)
    {
        if (b is 0)
            throw new Exception("KHONG THE CHIA CHO 0");
        return a % b;
    }


    public static void Run()// **Main** neu chay file rieng le
    {
        Console.WriteLine("1. Cộng");
        Console.WriteLine("2. Trừ");
        Console.WriteLine("3. Nhân");
        Console.WriteLine("4. Chia");
        Console.WriteLine("5. Chia lấy dư");
        Console.WriteLine("Nhập lựa chọn của bạn (1-5):");
        int options = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập số thứ nhất:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập số thứ hai:");
        double b = Convert.ToDouble(Console.ReadLine());

        try
        {
            double ketqua = options switch
            {
                1 => cong(a, b),
                2 => tru(a, b),
                3 => nhan(a, b),
                4 => chia(a, b),
                5 => chialaydu(a, b),
                _ => throw new Exception("Lựa chọn không hợp lệ")
            };

            Console.WriteLine($"Kết quả: {ketqua:F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
    }
}
// Note : Vi dang su dung class cho menu nen la nhieu Main nen complier se bao loi , nen minh se de tam la run -> neu chay file rieng le thi la doi la Main
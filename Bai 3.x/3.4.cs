class Menu
{
    static void Main()
    {
        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Caculator");
            Console.WriteLine("2. Phuong trinh Bac 2");
            Console.WriteLine("3. Kiem Tra So");
            Console.WriteLine("0. Exit");
            Console.Write("Chon mot lua chon: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("LUA CHON KHONG HOP LE");
                Console.WriteLine("NHAN PHIM BAT KY DE TIEP TUC...");
                Console.ReadKey();
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("CALCULATOR");
                    caculator.Run();
                    break;

                case 2:
                    Console.WriteLine("PHUONG TRINH BAC 2");
                    pt2.Run();
                    break;

                case 3:
                    Console.WriteLine("SO NGUYEN TO - HOAN HAO - FIBONACCI");
                    so.Run();
                    break;

                case 0:
                    Console.WriteLine("DA THOAT CHUONG TRINH");
                    break;

                default:
                    Console.WriteLine("LUA CHON KHONG HOP LE");
                    break;
            }

            if (choice != 0)
            {
                Console.WriteLine();
                Console.WriteLine("NHAN PHIM BAT KY DE TIEP TUC...");
                Console.ReadKey();
            }

        } while (choice != 0);

        Console.Clear();
    }
}
namespace Bai_4._6
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            while (true)
            {
                string user;
                using (var login = new FormLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK) break;
                    user = login.UserName;
                }

                var main = new FormMain { CurrentUser = user };
                Application.Run(main);

                if (!main.LoggedOut) break;
            }
        }
    }
}
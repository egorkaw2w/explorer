namespace Explorer
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    desk.view(desk.diski());
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
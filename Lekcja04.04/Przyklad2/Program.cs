using System.Diagnostics;

class Program
{
    static async Task F1() //samo slowo Task oznacza ze ta funkcja nic nie zwraca (void) ale obiekt Task przechowuje iformacje o wykonywanym zadaniu
    {
        while(true)
        {
            Console.Write("*");
            await Task.Delay(1000);
        }
    }

    static async Task F2() //samo slowo Task oznacza ze ta funkcja nic nie zwraca (void) ale obiekt Task przechowuje iformacje o wykonywanym zadaniu
    {
        while (true)
        {
            Console.Write("#");
            await Task.Delay(1000);
        }
    }



    public static async Task Main(String[] args)
    {
        Task t1 = F1();
        Task t2 = F2();

        await t1;
        await t2;
    }
}
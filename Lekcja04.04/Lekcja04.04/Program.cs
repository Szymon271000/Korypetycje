using System.Diagnostics;

class Program
{
    static async Task ZagotujWode() //samo slowo Task oznacza ze ta funkcja nic nie zwraca (void) ale obiekt Task przechowuje iformacje o wykonywanym zadaniu
    {
        await Task.Delay(1000);
        Console.WriteLine("Zagotowano wode");
    }

    static async Task ZrobKanapke()
    {
        await Task.Delay(3000);
        Console.WriteLine("Przygotowano kanapke");
    }

    static async Task ZrobJajacznice()
    {
        await Task.Delay(4000);
        Console.WriteLine("Jajecznica gotowa");
    }


    public static async Task Main(String[] args)
    {
        var timer = new Stopwatch();
        timer.Start();
        Task t1 = ZagotujWode();
        Task t2 = ZrobKanapke();
        Task t3 = ZrobJajacznice();

        await t1;
        await t2;
        await t3;

        timer.Stop();
        Console.WriteLine("Time ms: " + timer.ElapsedMilliseconds);
    }
}
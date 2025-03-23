using System.Diagnostics.Contracts;
using System.Security.Cryptography;
class SayaTubeVideo {
    Random rnd = new Random();
    private int id, playCount;
    private string title;
    public SayaTubeVideo(String title) {
        Contract.Requires(title.Length <= 100);
        Contract.Requires(title != "");
        this.title = title;
        id = rnd.Next(10000,99999);
        playCount = 0;
    }
    public void increasePlayCount(int x) {
        Contract.Requires(x <= 10000000);
        try
        {
            checked
            {
                playCount += x;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error Overflow");
        }
    }
    public void PrintVideoDetails() {
        Console.WriteLine("ID : " + id);
        Console.WriteLine("Judul Video : " + title);
        Console.WriteLine("Jumlah View : " + playCount);
    }
}

class Program
{
    public static void Main()
    {
        try
        {
            SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract – Yappier Albertus Febriandi Krisna Putra");
            vid.PrintVideoDetails();
            for (int i = 0; i < 220; i++)
            {
                vid.increasePlayCount(10000000);
            }  
            vid.PrintVideoDetails();
        }
        catch (Exception e)
        {
            Console.WriteLine("Terjadi kesalahan: " + e.Message);
        }
        
    }
}
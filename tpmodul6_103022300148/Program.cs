using System.Security.Cryptography;
class SayaTubeVideo {
    Random rnd = new Random();
    private int id, playCount;
    private string title;

    public SayaTubeVideo(String title) {
        this.title = title;
        id = rnd.Next(1,99999);
        playCount = 0;
    }
    public void increasePlayCount(int x) {
        playCount += x;
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
        SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract – Yappier Albertus Febriandi Krisna Putra");
        vid.increasePlayCount(5);
        vid.PrintVideoDetails();
    }
}
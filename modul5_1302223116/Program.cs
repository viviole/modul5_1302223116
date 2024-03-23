using modul5_1302223116;

internal class Program
{
    private static void Main(string[] args)
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(22);
        data.PrintAllData();
    }
}
// See https://aka.ms/new-console-template for more information
using modul5_1302223116;

public class Program
{
    public static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        penjumlahan.jumlahTigaAngka<int>(13, 02, 22);
    }
}


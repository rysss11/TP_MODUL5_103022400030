using System;

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo User " + user.ToString());
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Masukkan User: ");
        string usname = Console.ReadLine();

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(usname);

        Console.Write("Masukkan NIM: ");
        string nim = Console.ReadLine();

        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.printData();

    }
}


using System;

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo User " + user.ToString());
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
    }
}


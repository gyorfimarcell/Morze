internal class Program
{
    static List<Betu> betuk = File.ReadAllLines("morzeabc.txt").Skip(1).Select(x => new Betu(x)).ToList();

    private static void Main(string[] args)
    {
        Console.WriteLine($"3. feladat: A morze abc {betuk.Count()} db karakter kódját tartalmazza");

        Console.Write("4. feladat: Kérek egy karaktert: ");
        char karakter = Convert.ToChar(Console.Read());
        Console.WriteLine($"\tA {karakter} karakter morze kódja: {betuk.Find(x => x.Karakter == karakter).MorzeJel}");

        List<Idezet> idezetek = File.ReadAllLines("morze.txt").Select(x => new Idezet(x)).ToList();

        Console.WriteLine($"7. feladat: Az első idézet szerzője: {idezetek[0].Szerzo}");

        Idezet leghosszabb = idezetek.MaxBy(x => x.Szoveg.Length);
        Console.WriteLine($"8. feladat: A leghosszabb idézet szerzője és az idézet: {leghosszabb.TeljesIdezet}");

        Console.WriteLine($"9. feladat: Arisztotelész idézetei:");
        idezetek.Where(x => x.Szerzo == "ARISZTOTELÉSZ").ToList().ForEach(x => Console.WriteLine($"\t- {x.Szoveg}"));

        File.WriteAllLines("forditas.txt", idezetek.Select(x => x.TeljesIdezet));
    }

    public static string Morze2Szoveg(string morze)
    {
        return String.Join(" ", morze.Split("       ").Select(szo => 
            String.Join("", szo.Split("   ").Select(morzeBetu => betuk.Find(x => x.MorzeJel == morzeBetu).Karakter))));
    }
}
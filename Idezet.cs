public class Idezet {
    string szerzoMorze;
    string szovegMorze;

    public Idezet(string csvSor)
    {
        string[] mezok = csvSor.Split(';');

        this.szerzoMorze = mezok[0].Trim();
        this.szovegMorze = mezok[1].Trim();
    }

    public string SzerzoMorze { get => szerzoMorze; }
    public string SzovegMorze { get => szovegMorze; }
    public string Szerzo { get => Program.Morze2Szoveg(szerzoMorze); }
    public string Szoveg { get => Program.Morze2Szoveg(szovegMorze); }

    public string TeljesIdezet { get => $"{Szerzo}: {Szoveg}"; }
}
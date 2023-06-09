public class Betu
{
    char karakter;
    string morzeJel;

    public Betu(string csvSor)
    {
        string[] mezok = csvSor.Split('\t');

        this.karakter = Convert.ToChar(mezok[0]);
        this.morzeJel = mezok[1];
    }

    public char Karakter { get => karakter; }
    public string MorzeJel { get => morzeJel; }
}
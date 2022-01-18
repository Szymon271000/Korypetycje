using System;
using System.Collections.Generic;

class Zycie
{
    private String czas;

    public void set(String czas)
    {
        this.czas = czas;
    }

    public Pamiatka zapiszPamiatke()
    {
        //
        //
        Pamiatka p = new Pamiatka(czas);
        return p;
    }

    public void przywrocPamiatke(Pamiatka pamiatka)
    {
        // czas = ??
        //
        //
        czas = pamiatka.pobierzCzas();
    }

    public class Pamiatka
    {
        private String czas;

        public Pamiatka(String czas)
        {
            this.czas = czas;
        }

        public String pobierzCzas()
        {
            return czas;
        }
    }
}


class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Powrot do przyszlosci (Back to the Future)");
        Console.WriteLine();

        List<Zycie.Pamiatka> zapisaneStany = new List<Zycie.Pamiatka>();
        Zycie zycie = new Zycie();

        zycie.set("1985");
        zapisaneStany.Add(zycie.zapiszPamiatke());
        zycie.set("1955");
        zapisaneStany.Add(zycie.zapiszPamiatke());
        zycie.set("2015");
        zapisaneStany.Add(zycie.zapiszPamiatke());
        zycie.set("1885");

        zycie.przywrocPamiatke(zapisaneStany[0]);

    }
}